using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace project001
{
    public partial class Form3 : Form
    {
        
        string amountnew;
        
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource = 127.0.0.1; port=3306;username=root;password=;database=project01;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }


        Class_roomToOrder roomToOrder = new Class_roomToOrder();
        public Form3()
        {
            InitializeComponent();
        }

        Boolean dtstock;
        int check, amountold;
        
        private void submitBtn_Click(object sender, EventArgs e) //เพิ่มเข้าตะกร้า
        {
            
            Class_stockproduct stockproduct = new Class_stockproduct();
            string day = DateTime.Now.ToString("dd - MM - yyyy");
            string id = idBox.Text;
            string username = userBox.Text;
            string type = typeBox.Text;
            string name = nameBox.Text;
            string characteristics = characteristicBox.Text;
            string amount = comboamount.Text;
            string sum = textBoxSum.Text;
            string price = priceBox.Text;

            if (verify())
            {
                
                try
                {
                   
                    // รูปภาพ //
                    MemoryStream ms = new MemoryStream();
                    picture_pr.Image.Save(ms, picture_pr.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    if (roomToOrder.roomToOrder(id,type, name, characteristics, amount, price, sum,img)) 
                    {
                        showTable();
                        showTable1();
                        showprice();
                    }

                    Class_history history1 = new Class_history();
                    if (history1.inserthistoryr(id ,username, type, name, price, amount,sum, img, day))
                    {
                        showprice();
                    }

                    MySqlConnection conn = databaseConnection();
                    conn.Open();
                    MySqlCommand cmd;
                    cmd = conn.CreateCommand();
                    cmd.CommandText = $"SELECT *FROM stockproduct WHERE id='{id}'";
                    MySqlDataReader row = cmd.ExecuteReader();
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            amountold = int.Parse(row.GetString(4)); //จำนวนในตะกร้า
                        }
                        amountnew = (amountold - int.Parse(comboamount.Text)).ToString(); // จำนวนสินค้าในคลังลดลง
                        MySqlConnection conn1 = databaseConnection();
                        conn1.Open();
                        string sql = "UPDATE stockproduct SET amount = '" + amountnew + "' WHERE id = '" + id + "'";
                        MySqlCommand command1 = new MySqlCommand(sql, conn1);
                        command1.ExecuteReader();
                        conn1.Close();

                        showTable();
                        showTable1();
                        showprice();
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "เพิ่มไปยังตะกร้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            bool verify()
            {
                if ((typeBox.Text == "") || (nameBox.Text == "") ||
                (characteristicBox.Text == "") || (amountBox.Text == "") || (priceBox.Text == "") || (picture_pr.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }
        int sum = 0;
        private void showprice() // เเสดงราคารวม
        {
            sum = 0;
            MySqlConnection conn = databaseConnection();
            string sql = "SELECT * FROM `order`";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                sum = sum + int.Parse(read.GetString("sum").ToString());
            }
            textBoxSum.Text = sum.ToString();
            conn.Close();

        }
        
        public void showTable() //โชว์ตารางสินค้า
        {
            dataEquipment.ReadOnly = true;
            dataEquipment.DataSource = roomToOrder.getroomToOrder();
            dataEquipment.RowTemplate.Height = 30;
            DataGridViewImageColumn ImageColumn = new DataGridViewImageColumn();
            ImageColumn = (DataGridViewImageColumn)dataEquipment.Columns[6];
            ImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataEquipment.AllowUserToAddRows = false;
            dtstock = true;
        }
        public void showTable1() // โชว์ตารางออเดอร์ในจะกร้า
        {
            Class_order order = new Class_order();
            dataEquipment1.ReadOnly = true;
            dataEquipment1.DataSource = order.getorder();
            dataEquipment1.RowTemplate.Height = 30;
            DataGridViewImageColumn ImageColumn = new DataGridViewImageColumn();
            ImageColumn = (DataGridViewImageColumn)dataEquipment1.Columns[7];
            ImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataEquipment1.AllowUserToAddRows = false;
            dtstock = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "ประเภทสินค้า";
            comboamount.Text = "1";
            showprice();
            showTable();
            showTable1();
        }
        

        private void dataEquipment1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtstock = false;
            dataEquipment.CurrentRow.Selected = true;
            idBox.Text = dataEquipment.CurrentRow.Cells[0].Value.ToString();
            typeBox.Text = dataEquipment.CurrentRow.Cells[1].Value.ToString();
            nameBox.Text = dataEquipment.Rows[e.RowIndex].Cells[2].Value.ToString();
            characteristicBox.Text = dataEquipment.CurrentRow.Cells[3].Value.ToString();
            amountBox.Text = dataEquipment.Rows[e.RowIndex].Cells[4].Value.ToString();
            priceBox.Text = dataEquipment.CurrentRow.Cells[5].Value.ToString();

            byte[] pic;
            pic = (byte[])dataEquipment.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(pic);
            picture_pr.Image = Image.FromStream(ms);
        }
        
        public void combotype() //ประเภทสินค้า 
        {

            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();

            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stockproduct WHERE type =\"{comboBox1.SelectedItem.ToString()}\"";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();
            dataEquipment.DataSource = ds.Tables[0].DefaultView;
        }
        
        private void searchBut_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();

            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stockproduct WHERE name like \"%{searchBox.Text}%\"";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataEquipment.DataSource = ds.Tables[0].DefaultView;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login m = new login();
            m.Show();
        }

       
        int check_1, check_2, sum_old;
        private void button1_Click(object sender, EventArgs e) //แก้ไขจำนวนสินค้าในตะกร้า
        {
            if (comboamount.Text != "")
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT *FROM stockproduct WHERE id='{idBox.Text}'";
                MySqlDataReader row = cmd.ExecuteReader();
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        check_1 = int.Parse(row.GetString(4)); //จำนวนในสต๊อก
                        sum_old = int.Parse(row.GetString(5));
                    }
                }
                conn.Close();

                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT *FROM `order` WHERE id='{idBox.Text}'";
                row = cmd.ExecuteReader();
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        check_2 = int.Parse(row.GetString(4)); //จำนวนในตะกร้า
                    }
                }
                conn.Close();

                if (check_1 >= int.Parse(comboamount.Text)) //จำนวนในสต๊อกมากกว่าตำนวนที่เลือก
                {
                    if (int.Parse(comboamount.Text) > check_2)  //จำนวนที่เราเลือกเพิ่มมากว่าจำนวนที่อยู่ในตะกร้า //แก้ไขเพิ่มจำนวนมากกว่าเดิม
                    {
                        conn.Open();
                        string sql = "UPDATE `order` SET amount = '" + comboamount.Text + "', sum = '" + sum_old * int.Parse(comboamount.Text) + "' WHERE id = '" + idBox.Text + "'";
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        command.ExecuteReader();
                        conn.Close();

                        string amountstock = (check_1 - (int.Parse(comboamount.Text) - check_2)).ToString(); //จำนวนสินค้าในสต๊อกที่เหลืออยู่หลังจากที่เราเพิ่มสินค้าเข้าไปในตะกร้า
                        conn.Open();
                        sql = "UPDATE `stockproduct` SET `amount`= '" + amountstock + "' WHERE id = '" + idBox.Text + "'";
                        command = new MySqlCommand(sql, conn);
                        command.ExecuteReader();
                        conn.Close();
                    }
                    else
                    {
                        conn.Open(); //แก้ไขจำนวนในตะกร้าโดยลดลงกว่าเดิม
                        string sql = "UPDATE `order` SET amount = '" + comboamount.Text + "', sum = '" + sum_old * int.Parse(comboamount.Text) + "' WHERE id= '" + idBox.Text + "'";
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        command.ExecuteReader();
                        conn.Close();

                        string amountstock = ((check_2 - int.Parse(comboamount.Text)) + check_1).ToString(); //เอาจำนวนที่เราเอาออกจากตะกร้ามาบวกเข้ากับจำนวนเดิมในคลัง
                        conn.Open();
                        sql = "UPDATE `stockproduct` SET `amount` = '" + amountstock + "' WHERE id = '" + idBox.Text + "'";
                        command = new MySqlCommand(sql, conn);
                        command.ExecuteReader();
                        conn.Close();
                    }
                    MessageBox.Show("แก้ข้อมูลสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showTable();
                    showTable1();
                    showprice();
                }
                else
                {
                    MessageBox.Show("โปรดตรวจสอบจำนวนสินค้า", "แจ้งเตือน", MessageBoxButtons.OK , MessageBoxIcon.Warning);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e) //combotype เเสดงคำสั่ง ประเภทสินค้า
        {
            combotype();
        }

        private void reBut_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            idBox.Text = "";
            typeBox.Text = "";
            nameBox.Text = "";
            characteristicBox.Text = "";
            amountBox.Text = "";
            priceBox.Text = "";
            searchBox.Text = "";
            picture_pr.Image = null;

            showTable1();
            showTable();

            comboBox1.Text = "ประเภทสินค้า";
            comboamount.Text = "1";
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM order ";
            MySqlDataReader row = cmd.ExecuteReader();

            while (row.Read())
            {
                MySqlConnection conn2 = databaseConnection();
                conn2.Open();
                MySqlCommand cmd2;
                cmd2 = conn2.CreateCommand();
                cmd2.CommandText = $"SELECT * FROM stockproduct WHERE id = \"{row.GetString(0)}\"";
                MySqlDataReader row2 = cmd2.ExecuteReader();
                while (row2.Read())
                {
                    amountnew = $"{int.Parse(row.GetString(3)) + int.Parse(row2.GetString(3))}"; //จำนวนสินค้าในตะกร้า+จำนวนสินค้าในสต๊อก
                }
                conn2.Close();

                conn2.Open();
                string sql3 = "UPDATE stockproduct SET amount = '" + amountnew + "' WHERE id = '" + row.GetString(0) + "'";
                MySqlCommand command = new MySqlCommand(sql3, conn2);
                command.ExecuteReader();
                conn2.Close();
            }
            conn.Close();

            MySqlConnection conn1 = databaseConnection();
            string sql = "DELETE FROM order";
            MySqlCommand cmd1 = new MySqlCommand(sql, conn1);

            conn1.Open();
            int rows = cmd1.ExecuteNonQuery();
            conn1.Close();
            Application.Exit();
        }

        private void comboamount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int amountold_s, amountold_o;
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Class_history history1 = new Class_history();
            Class_order order = new Class_order();
            int id = Convert.ToInt32(idBox.Text);
            
            //string name = nameBox.Text;
            if (MessageBox.Show("Are You Sure Want TI Delete This room", "Delete Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT *FROM stockproduct WHERE id='{idBox.Text}'";
                MySqlDataReader row = cmd.ExecuteReader();
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        amountold_s = int.Parse(row.GetString(4)); //จำนวนในตะกร้า
                    }
                    
                }
                conn.Close();
                
                conn.Open();
               
                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT *FROM `order` WHERE id='{idBox.Text}'";
                MySqlDataReader row1 = cmd.ExecuteReader();

                if (row1.HasRows)
                {
                    while (row1.Read())
                    {
                        amountold_o = int.Parse(row1.GetString(4)); //จำนวนในตะกร้า
                    }
                }
                

                amountnew = $"{amountold_s + amountold_o}";
                MySqlConnection conn1 = databaseConnection();
                conn1.Open();
                string sql = "UPDATE stockproduct SET amount = '" + amountnew + "' WHERE id = '" + id + "'";
                MySqlCommand command1 = new MySqlCommand(sql, conn1);
                command1.ExecuteReader();
                conn1.Close();

                if (order.deleterorder(id))
                {
                    MessageBox.Show("ลบสินค้าออกจากตะกร้าเรียบร้อย", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    

                    //Clear
                    idBox.Text = "";
                    typeBox.Text = "";
                    nameBox.Text = "";
                    characteristicBox.Text = "";
                    amountBox.Text = "";
                    priceBox.Text = "";
                    searchBox.Text = "";
                    
                    picture_pr.Image = null;
                    showprice();
                    showTable1();
                    showTable();
                    
                }

                if (history1.deletehistory(id))
                {

                    //Clear
                    idBox.Text = "";
                    typeBox.Text = "";
                    nameBox.Text = "";
                    characteristicBox.Text = "";
                    amountBox.Text = "";
                    priceBox.Text = "";
                    searchBox.Text = "";
                    picture_pr.Image = null;

                    showTable1();
                    showTable();

                    comboBox1.Text = "ประเภทสินค้า";
                    comboamount.Text = "1";

                }
            }

        }

        private void dataEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataEquipment1.CurrentRow.Selected = true;
            idBox.Text = dataEquipment1.CurrentRow.Cells[0].Value.ToString();
            typeBox.Text = dataEquipment1.CurrentRow.Cells[1].Value.ToString();
            nameBox.Text = dataEquipment1.Rows[e.RowIndex].Cells[2].Value.ToString();
            characteristicBox.Text = dataEquipment1.CurrentRow.Cells[3].Value.ToString();
            comboamount.Text = dataEquipment1.Rows[e.RowIndex].Cells[4].Value.ToString();
            priceBox.Text = dataEquipment1.CurrentRow.Cells[5].Value.ToString();

            byte[] pic;
            pic = (byte[])dataEquipment1.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(pic);
            picture_pr.Image = Image.FromStream(ms);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 m = new Form5();
            m.userBox.Text = userBox.Text;
            m.Show();
        }
    }

}

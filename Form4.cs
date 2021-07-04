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

namespace project001
{
    public partial class Form4 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource = 127.0.0.1; port=3306;username=root;password=;database=project01;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public Form4()
        {
            InitializeComponent();
        }

        public void showTable()
        {
            Class_history history1 = new Class_history();

            dataEquipment.ReadOnly = true;

            dataEquipment.DataSource = history1.gethistory();
            dataEquipment.RowTemplate.Height = 25;
            DataGridViewImageColumn ImageColumn = new DataGridViewImageColumn();
            ImageColumn = (DataGridViewImageColumn)dataEquipment.Columns[7];

            dataEquipment.AllowUserToAddRows = false;
        }

        public void showTable1()
        {
            Class_pay pay = new Class_pay();
            dataEquipment1.ReadOnly = true;
            dataEquipment1.DataSource = pay.getpay();
            dataEquipment1.RowTemplate.Height = 25;
            DataGridViewImageColumn ImageColumn = new DataGridViewImageColumn();
            ImageColumn = (DataGridViewImageColumn)dataEquipment1.Columns[7];
            ImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataEquipment1.AllowUserToAddRows = false;
        }

        
        int sum = 0;
        private void showprice() // เเสดงราคารวม
        {
            sum = 0;
            MySqlConnection conn = databaseConnection();
            string sql = "SELECT * FROM `history`";
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

        private void Form4_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = System.DateTime.Now;
            dateTimePicker2.Value = System.DateTime.Now;

            showTable();
            showTable1();
            showprice();
        }

        

        private void searchBut1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();

            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM pay WHERE username like \"%{searchBox1.Text}%\"";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataEquipment1.DataSource = ds.Tables[0].DefaultView;
        }

        
        int date;
        private void button2_Click(object sender, EventArgs e) //ค้นหาด้วยวันที่
        {
            if (dateTimePicker1.Value.ToString("dd - MM - yyyy") == dateTimePicker2.Value.ToString("dd - MM - yyyy"))
            {
                MySqlConnection conn1 = databaseConnection();

                DataSet ds1 = new DataSet();

                conn1.Open();
                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM `history` WHERE `day` like '%" + dateTimePicker1.Value.ToString("dd - MM - yyyy") + "%' AND username like '%" + searchBox.Text + "%'", conn1);


                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);

                da1.Fill(ds1);
                conn1.Close();
                dataEquipment.DataSource = ds1.Tables[0].DefaultView;

                sum = 0; //ตัวแปรจำนวนเงิน

                conn1.Open();
                MySqlDataReader read = cmd1.ExecuteReader();
                while (read.Read())
                {
                    sum = sum + int.Parse(read.GetString(6));
                }
                textBoxSum.Text = $"{sum}";
                conn1.Close();
            }
            else if (searchBox.Text != "")
            {
                date = int.Parse(dateTimePicker2.Value.ToString("dd")) + 1;
                MySqlConnection conn = databaseConnection();

                DataSet ds = new DataSet();

                conn.Open();
                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM `history` WHERE `day` between @date1 and @date2 and username=@na";

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.SelectCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Value.ToString("dd - MM - yyyy"));
                da.SelectCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Value.ToString("" + date + "- MM - yyyy"));
                da.SelectCommand.Parameters.AddWithValue("@na", searchBox.Text);
                da.Fill(ds);
                conn.Close();
                dataEquipment.DataSource = ds.Tables[0].DefaultView;

                sum = 0; //ตัวแปรจำนวนสินค้า
                
                conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    sum = sum + int.Parse(read.GetString(6));
                }
                textBoxSum.Text = $"{sum}";
                
                conn.Close();
            }
            else
            {
                date = int.Parse(dateTimePicker2.Value.ToString("dd")) + 1;
                MySqlConnection conn = databaseConnection();

                DataSet ds = new DataSet();

                conn.Open();
                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM `history` WHERE `day` between @date1 and @date2";

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.SelectCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Value.ToString("dd - MM - yyyy"));
                da.SelectCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Value.ToString("" + date + "- MM - yyyy"));
                da.Fill(ds);
                conn.Close();
                dataEquipment.DataSource = ds.Tables[0].DefaultView;

                sum = 0; //ตัวแปรจำนวนสินค้า
               
                conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    sum = sum + int.Parse(read.GetString(6));
                }
                textBoxSum.Text = $"{sum}";
                conn.Close();

            }

        }



        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin m = new admin();
            m.Show();
        }

        private void dataEquipment1_CellClick(object sender, DataGridViewCellEventArgs e) //pay
        {
            
            dataEquipment1.CurrentRow.Selected = true;
            userBox.Text = dataEquipment1.Rows[e.RowIndex].Cells[1].Value.ToString();
            fnameBox.Text = dataEquipment1.Rows[e.RowIndex].Cells[2].Value.ToString();
            lnameBox.Text = dataEquipment1.Rows[e.RowIndex].Cells[3].Value.ToString();
            addressBox.Text = dataEquipment1.Rows[e.RowIndex].Cells[4].Value.ToString();
            phoneBox.Text = dataEquipment1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox1.Text = dataEquipment1.Rows[e.RowIndex].Cells[6].Value.ToString();
            dayBox.Text = dataEquipment1.Rows[e.RowIndex].Cells[8].Value.ToString();
            timeBox.Text = dataEquipment1.Rows[e.RowIndex].Cells[9].Value.ToString();

            byte[] pic;
            pic = (byte[])dataEquipment1.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(pic);
            pictureBox4.Image = Image.FromStream(ms);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userBox.Text = "";
            fnameBox.Text = "";
            lnameBox.Text = "";
            addressBox.Text = "";
            phoneBox.Text = "";
            textBox1.Text = "";
            dayBox.Text = "";
            timeBox.Text = "";
            searchBox.Text = "";
            searchBox1.Text = "";
            pictureBox4.Image = null;

            showTable();
            showTable1();
            showprice();
        }
    }
    
}

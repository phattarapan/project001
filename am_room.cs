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
    public partial class am_room : Form
    {
        
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project01;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        
        public am_room()
        {
            InitializeComponent();
        }

        private void am_room_Load(object sender, EventArgs e)
        {
            showTable();
            searchData("");
            comboBox1.Text = "ประเภทสินค้า";

        }
       
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo (*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                picture_pr.Image = Image.FromFile(opf.FileName);
            }
        }
        
        private void addBut_Click(object sender, EventArgs e)
        {
            Class_stockproduct stockproduct = new Class_stockproduct();
            string type = typeBox.Text;
            string name = nameBox.Text;
            string characteristics = characteristicBox.Text;
            string amount = amountBox.Text;
            string price = priceBox.Text;
            
            if (verify())
            {
                try
                { 
                    // รูปภาพ //
                    MemoryStream ms = new MemoryStream();
                    picture_pr.Image.Save(ms, picture_pr.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    if (stockproduct.insertstockproduct(type, name, characteristics, amount, price, img)) //type, name, characteristics, amount, price, img
                    {
                        MessageBox.Show("เพิ่มสินค้าในคลังเรียบร้อย", "เพิ่มสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "เพิ่มสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        public void showTable()
        {
            Class_stockproduct stockproduct = new Class_stockproduct();
            dataproduct.ReadOnly = true;
            dataproduct.DataSource = stockproduct.getstockproduct();
            dataproduct.RowTemplate.Height = 40;
            DataGridViewImageColumn ImageColumn = new DataGridViewImageColumn();
            ImageColumn = (DataGridViewImageColumn)dataproduct.Columns[6];
            ImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataproduct.AllowUserToAddRows = false;
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

        private void resrtBut_Click(object sender, EventArgs e)
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
            
            comboBox1.Text = "ประเภทสินค้า";
            showTable();
        }

        private void downloadBut_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = "stockproduct";

            if (picture_pr.Image == null)
            {
                MessageBox.Show("ไม่มีรูปภาพ","เเจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (svf.ShowDialog() == DialogResult.OK)
            {
                picture_pr.Image.Save(svf.FileName + ("." + ImageFormat.Png.ToString()));
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            
            Class_stockproduct stockproduct = new Class_stockproduct();
            string id = idBox.Text;
            string type = typeBox.Text;
            string name = nameBox.Text;
            string characteristics = characteristicBox.Text;
            string amount = amountBox.Text;
            string price = priceBox.Text;

            if (verify())
            {
                try
                {
                    // รูปภาพ //   
                    MemoryStream ms = new MemoryStream();
                    picture_pr.Image.Save(ms, picture_pr.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    if (stockproduct.updatestockproduct(id, type, name, characteristics, amount, price, img))
                    {
                        MessageBox.Show("แก้ไขสินค้าในคลังเรียบร้อย ", "เเก้ไขสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "แก้ไขสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Class_stockproduct stockproduct = new Class_stockproduct();
            int id = Convert.ToInt32(idBox.Text);

            if (MessageBox.Show("คุณแน่ใจหรือว่าต้องการลบสินค้านี้", "ลบสินค้า", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (stockproduct.deletestockproduct(id))
                {
                    MessageBox.Show("ลบสินค้าเรียบร้อย", "ลบสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clear
                    idBox.Text = "";
                    typeBox.Text = "";
                    nameBox.Text = "";
                    characteristicBox.Text = "";
                    amountBox.Text = "";
                    priceBox.Text = "";
                    searchBox.Text = "";

                    picture_pr.Image = null;
                    showTable();
                }
                //else
                //{
                //    MessageBox.Show("ไม่สามารถลบสินค้าได้", "ลบสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
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

            dataproduct.DataSource = ds.Tables[0].DefaultView;
        }

        public void searchData(string search)
        {
            
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin m = new admin();
            m.Show();
        }

        private void dataproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataproduct.CurrentRow.Selected = true;
            idBox.Text = dataproduct.CurrentRow.Cells[0].Value.ToString();
            typeBox.Text = dataproduct.CurrentRow.Cells[1].Value.ToString();
            nameBox.Text = dataproduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            characteristicBox.Text = dataproduct.CurrentRow.Cells[3].Value.ToString();
            amountBox.Text = dataproduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            priceBox.Text = dataproduct.CurrentRow.Cells[5].Value.ToString();

            byte[] pic;
            pic = (byte[])dataproduct.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(pic);
            picture_pr.Image = Image.FromStream(ms);
        }
        public void combotype() 
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
            dataproduct.DataSource = ds.Tables[0].DefaultView;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combotype();
        }

        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8 || (int)e.KeyChar == 13 || (int)e.KeyChar == 46)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกตัวเลขเท่านั้น", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void amountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8 || (int)e.KeyChar == 13 || (int)e.KeyChar == 46)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกตัวเลขเท่านั้น", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                combotype();
            }
        }
    }
}


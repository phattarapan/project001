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
    public partial class Form7 : Form
    {
        

        Class_stockproduct stockproduct = new Class_stockproduct();

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project01;";

            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void Showdataproduct()
        {
            dataproduct.ReadOnly = true;
            dataproduct.DataSource = stockproduct.getstockproduct();
            dataproduct.RowTemplate.Height = 40;
            DataGridViewImageColumn ImageColumn = new DataGridViewImageColumn();
            ImageColumn = (DataGridViewImageColumn)dataproduct.Columns[6];
            ImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataproduct.AllowUserToAddRows = false;
        }

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Showdataproduct();
            comboBox1.Text = "ประเภทสินค้า";
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin m = new admin();
            m.Show();
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
            allstock = true;
            combotype();
        }

        private void shoeallBut_Click(object sender, EventArgs e)
        {
            Showdataproduct();
            idBox.Text = "";
            typeBox.Text = "";
            nameBox.Text = "";
            amountBox.Text = "";
            searchBox.Text = "";
            comboBox1.Text = "ประเภทสินค้า";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SARAPHAT ", new Font("TH SarabunPSK", 30, FontStyle.Bold), Brushes.Black, new PointF(310, 60));
            e.Graphics.DrawString("KHONG  KUKKIK  SHOP", new Font("TH SarabunPSK", 30, FontStyle.Bold), Brushes.Black, new PointF(170, 110));
            e.Graphics.DrawString("123 หมู่ 16 ถนนมิตรภาพ ตำบลใน​เมือง ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(250, 170));
            e.Graphics.DrawString("อำเภอเมืองขอนแก่น จังหวัดขอนแก่น 40000 ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(230, 200));
            e.Graphics.DrawString("โทร  099-9097837 ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(330, 230));

            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 260));
            e.Graphics.DrawString("รายการสินค้า  ", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 290));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd / MM / yyyy   HH : mm : ss น."), new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 320));
            e.Graphics.DrawString("พิมพ์โดย Saraphat Khong kukkik Shop ", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(430, 320));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 340));

           
            e.Graphics.DrawString("ID", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 363));
            e.Graphics.DrawString("ประเภท", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 363));
            e.Graphics.DrawString("รายการสินค้า", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(350, 363));
            e.Graphics.DrawString("จำนวนคงเหลือ", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(620, 363));
            e.Graphics.DrawString("ราคา", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(745, 363));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 380));

            e.Graphics.DrawString("Thank You and Have a Great Day", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(280, 1050));

            int y = 415;
            allproduct.Clear();
            loaddata();
            foreach (var i in allproduct)
            {
                e.Graphics.DrawString(i.id, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(50, y));
                e.Graphics.DrawString(i.type, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(100, y));
                e.Graphics.DrawString(i.name, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(230, y));
                e.Graphics.DrawString(i.amount, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(700, y));
                e.Graphics.DrawString(i.price, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(750, y));
                y = y + 30;
            }
            
        }
        private List<ForPrint> allproduct = new List<ForPrint>();
        Boolean allstock;

        private void loaddata()
        {
            MySqlConnection conn = new MySqlConnection("datasource = 127.0.0.1; port=3306;username=root;password=;database=project01;");
            if (allstock == true)
            {
                conn.Open();
                
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM stockproduct WHERE type = '" + comboBox1.SelectedItem.ToString() + "' AND name like '%" + searchBox.Text + "%'", conn);
                MySqlDataReader adapter = cmd.ExecuteReader();

                while (adapter.Read())
                {
                    Program.id = adapter.GetString("id");
                    Program.type = adapter.GetString("type");
                    Program.name = adapter.GetString("name");
                    Program.amount = adapter.GetString("amount");
                    Program.price = adapter.GetString("price");

                    ForPrint m = new ForPrint() 
                    {
                        id = Program.id,
                        type = Program.type,
                        name = Program.name,
                        amount = Program.amount,
                        price = Program.price,
                    };
                    allproduct.Add(m);
                }
            }
            else
            {
                conn.Open();
                
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM stockproduct", conn);
                MySqlDataReader adapter = cmd.ExecuteReader();

                while (adapter.Read())
                {
                    Program.id = adapter.GetString("id");
                    Program.type = adapter.GetString("type");
                    Program.name = adapter.GetString("name");
                    Program.amount = adapter.GetString("amount");
                    Program.price = adapter.GetString("price");
                    ForPrint m = new ForPrint()
                    {
                        id = Program.id,
                        type = Program.type,
                        name = Program.name,
                        amount = Program.amount,
                        price = Program.price,
                    };
                    allproduct.Add(m);
                }
            }
        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();

            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stockproduct WHERE name like \"%{searchBox.Text}%\" AND type =\"{comboBox1.SelectedItem.ToString()}\"";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataproduct.DataSource = ds.Tables[0].DefaultView;
            
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                combotype();
                comboBox1.Text = "ประเภทสินค้า";
            }
        }

        private void printBut_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void dataproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataproduct.CurrentRow.Selected = true;
            idBox.Text = dataproduct.CurrentRow.Cells[0].Value.ToString();
            typeBox.Text = dataproduct.CurrentRow.Cells[1].Value.ToString();
            nameBox.Text = dataproduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            amountBox.Text = dataproduct.Rows[e.RowIndex].Cells[4].Value.ToString();
           
        }
    }
    
}

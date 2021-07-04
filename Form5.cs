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
    public partial class Form5 : Form
    {
        Class_pay pay = new Class_pay();

        public Form5()
        {
            InitializeComponent();
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

        private void QR_Click(object sender, EventArgs e)
        {
            Form6 QR = new Form6();
            QR.Show();
        }

        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            showTable();
            showprice();
        }

        public void showTable()
        {

            Class_order order = new Class_order();
            dataEquipment.ReadOnly = true;
            dataEquipment.DataSource = order.getorder();
            dataEquipment.RowTemplate.Height = 80;
            DataGridViewImageColumn ImageColumn = new DataGridViewImageColumn();
            ImageColumn = (DataGridViewImageColumn)dataEquipment.Columns[7];
            ImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataEquipment.AllowUserToAddRows = false;
        }

        int sum = 0;
        private void showprice() //ยอดรวม
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
       

        private void userBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void findBut_Click(object sender, EventArgs e)
        {
           
            Class_login login = new Class_login();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM user WHERE username = @un", login.getConnection);
            cmd.Parameters.Add("@un", MySqlDbType.VarChar).Value = userBox.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("No Data Found");
            }
            else
            {
                fnameBox.Text = table.Rows[0][1].ToString();
                lnameBox.Text = table.Rows[0][2].ToString();
                addressBox.Text = table.Rows[0][5].ToString();
                phoneBox.Text = table.Rows[0][6].ToString();
            }
        }
       


        private void button1_Click(object sender, EventArgs e)
        {
            string day = DateTime.Now.ToString("dd - MM - yyyy");
            string time = DateTime.Now.ToString("h:mm tt");
            string username = userBox.Text;
            string fname = fnameBox.Text;
            string lname = lnameBox.Text;
            string address = addressBox.Text;
            string phone = phoneBox.Text;
            string sum = textBoxSum.Text;

            if (verify())
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    picture_pr.Image.Save(ms, picture_pr.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    if (pay.insertpay(username, fname, lname, address, phone, day, sum, img, time))
                    {
                        MessageBox.Show("Data Uploaded Successfully.", "Upload Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        printPreviewDialog1.Document = printDocument1;
                        printPreviewDialog1.ShowDialog();
                        this.Hide();
                        login m = new login();
                        m.Show();

                        MySqlConnection conn = databaseConnection();
                        string sql = "DELETE FROM `order` ";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project01;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }

        bool verify()
        {
            if ((userBox.Text == "") || (fnameBox.Text == "") || (lnameBox.Text == "") || (addressBox.Text == "") || 
                (phoneBox.Text == "") || (picture_pr.Image == null) || (textBoxSum.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("SARAPHAT ", new Font("TH SarabunPSK", 30, FontStyle.Bold), Brushes.Black, new PointF(310, 90));
            e.Graphics.DrawString("KHONG  KUKKIK  SHOP", new Font("TH SarabunPSK", 30, FontStyle.Bold), Brushes.Black, new PointF(170, 140));
            e.Graphics.DrawString("123 หมู่ 16 ถนนมิตรภาพ ตำบลใน​เมือง ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(250, 200));
            e.Graphics.DrawString("อำเภอเมืองขอนแก่น จังหวัดขอนแก่น 40000 ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(230, 230));
            e.Graphics.DrawString("โทร  099-9097837 ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(330, 260));

            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 290));
            e.Graphics.DrawString("รายการจำหน่ายสินค้า  K."+ userBox.Text, new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 320));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd / MM / yyyy   HH : mm : ss น."), new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 350));
            e.Graphics.DrawString("พิมพ์โดย Saraphat Khong kukkik Shop ", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(430, 350));

            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 380));
            e.Graphics.DrawString("ID", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 415));
            e.Graphics.DrawString("ประเภท", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 415));
            e.Graphics.DrawString("รายการสินค้า", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(350, 415));
            e.Graphics.DrawString("จำนวนคงเหลือ", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(620, 415));
            e.Graphics.DrawString("ราคา", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(745, 415));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 440));

            e.Graphics.DrawString("Thank You and Have a Great Day", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(280, 1020));

            int y = 490; 
            loaddata();
            foreach (var i in allbook)
            {
                e.Graphics.DrawString(i.id, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(50, y));
                e.Graphics.DrawString(i.type, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(100, y));
                e.Graphics.DrawString(i.name, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(230, y));
                e.Graphics.DrawString(i.amount, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(700, y));
                e.Graphics.DrawString(i.price, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(750, y));
                y = y + 30;
            }
            e.Graphics.DrawString("ราคารวม", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(490, y+10));
            e.Graphics.DrawString(textBoxSum.Text + "  บาท", new Font("TH SarabunPSK", 14, FontStyle.Bold), Brushes.Black, new PointF(600, y+10));
        }

        private List<ForPrint> allbook = new List<ForPrint>();
        private void loaddata()
        {
            MySqlConnection conn = new MySqlConnection("datasource = 127.0.0.1; port=3306;username=root;password=;database=project01;");

            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `order`", conn);
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
                allbook.Add(m);
            }
        }

    }
}

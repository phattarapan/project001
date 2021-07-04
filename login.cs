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


namespace project001
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            Class_login login = new Class_login();
                       
            MySqlDataAdapter adater = new MySqlDataAdapter();

            DataTable table = new DataTable();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `user` WHERE `username` =@un AND `pass` =@pass", login.getConnection);

            cmd.Parameters.Add("@un", MySqlDbType.VarChar).Value = userBox.Text;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passBox.Text;

            adater.SelectCommand = cmd;

            adater.Fill(table);

            


            if (verifFields("login"))
            {
                if (table.Rows.Count > 0)
                {  
                    this.Hide();
                    Form3 m = new Form3();
                    m.userBox.Text = userBox.Text;
                    m.Show();

                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Loin Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empyy Username Or Password", "Loin Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool verifFields(string opertion)
        {
            bool check = false;

            
            
            if (opertion == "login")
            {
                if (userBox.Text.Trim().Equals("") || passBox.Text.Trim().Equals(""))
                {
                    check = false;
                }
                else
                {
                    check = true;
                }
            }
            return check;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 m = new Form2();
            m.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passBox.UseSystemPasswordChar = true;
            }
            else
            {
                passBox.UseSystemPasswordChar = false;
            }
        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminBut_Click(object sender, EventArgs e)
        {
            Class_login login = new Class_login();

            MySqlDataAdapter adater = new MySqlDataAdapter();

            DataTable table = new DataTable();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `login` WHERE `username`=@us AND`password`=@pass", login.getConnection);

            cmd.Parameters.Add("@us", MySqlDbType.VarChar).Value = userBox.Text;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passBox.Text;

            adater.SelectCommand = cmd;

            adater.Fill(table);

            if (verifFields("login"))
            {
                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    admin m = new admin();
                    m.Show();
                }
                else
                {
                    MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void userBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 65 && (int)e.KeyChar <= 122) || ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8 || (int)e.KeyChar == 13)
            {
                e.Handled = false; 
            }
            else
            {
                e.Handled = true;  
                MessageBox.Show("กรุณาใช้ตัวอักษรภาษาอังกฤษ", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void passBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 65 && (int)e.KeyChar <= 122) || ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8 || (int)e.KeyChar == 13)
            {
                e.Handled = false; 
            }
            else
            {
                e.Handled = true;  
                MessageBox.Show("กรุณาใช้ตัวอักษรภาษาอังกฤษ", "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

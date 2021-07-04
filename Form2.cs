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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        
        private void registerBut_Click(object sender, EventArgs e)
        {
            string fname = fnameBox.Text;
            string lname = lnameBox.Text;
            string username = userBox.Text;
            string password = passBox2.Text;
            string address = addressBox.Text;
            string phone = phoneBox.Text;

            USER user = new USER();


            if (verify("register"))
            {
                if (!user.usernameExists(username))
                {
                    if (phoneBox.TextLength < 10)
                    {
                        MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์ให้ครบ 10 ตัว", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (phoneBox.TextLength > 10)
                    {
                        MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์ไม่เกิน 10 ตัว", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (passBox2.TextLength < 6 )
                    {
                        MessageBox.Show("กรุณากรอกรหัสผ่านอย่างน้อย 6 ตัว", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if(user.inseruser(fname, lname, username, password, address, phone))
                    {
                        MessageBox.Show("การลงทะเบียนเสร็จสมบูรณ์", "ลงทะเบียน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        login m = new login();
                        m.Show();
                    }
                    else
                    {
                        MessageBox.Show("เกิดข้อผิดพลาด", "ลงทะเบียน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("มีชื่อผู้ใช้นี้แล้ว กรุณาลองใช้ชื่ออื่น", "ชื่อผู้ใช้ที่ไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("* กรุณากรอกข้อมูลให้ครบถ้วน", "ลงทะเบียน", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool verify(string opertion)
        {
            bool check = false;

            if (opertion == "register")
            {
                if(fnameBox.Text.Trim().Equals("") || lnameBox.Text.Trim().Equals("") || addressBox.Text.Trim().Equals("") || phoneBox.Text.Trim().Equals("") || userBox.Text.Trim().Equals("") || passBox2.Text.Trim().Equals(""))
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passBox2.UseSystemPasswordChar = true;
            }
            else
            {
                passBox2.UseSystemPasswordChar = false;
            }
        }

        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login m = new login();
            m.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
                MessageBox.Show("กรุณาใช้ตัวอักษรภาษาอังกฤษ", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("กรุณาใช้ตัวอักษรภาษาอังกฤษ", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void nam(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("ไม่สามารถพิมพ์เป็นตัวเลขได้", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lnameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("ไม่สามารถพิมพ์เป็นตัวเลขได้", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

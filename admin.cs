using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project001
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void productBut_Click(object sender, EventArgs e) //เเก้ไขรายกาสินค้า
        {
            this.Hide();
            am_room m = new am_room();
            m.Show();
        }

        private void orderBut_Click(object sender, EventArgs e) //ออร์เดอร์/การชำระเงิน
        {
            this.Hide();
            Form4 m = new Form4();
            m.Show();
        }

        private void label1_Click(object sender, EventArgs e) //กลับไปหน้า login
        {
            this.Hide();
            login m = new login();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e) //เช็คจำนวนสินค้า
        {
            this.Hide();
            Form7 m = new Form7();
            m.Show();
        }
    }
}

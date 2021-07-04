
namespace project001
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerBut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fnameBox
            // 
            this.fnameBox.BackColor = System.Drawing.Color.Gainsboro;
            this.fnameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameBox.Font = new System.Drawing.Font("FC Home", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.fnameBox.Location = new System.Drawing.Point(499, 42);
            this.fnameBox.Multiline = true;
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(404, 50);
            this.fnameBox.TabIndex = 64;
            this.fnameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nam);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(499, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 31);
            this.label2.TabIndex = 63;
            this.label2.Text = "ชื่อ";
            // 
            // passBox2
            // 
            this.passBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.passBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox2.Font = new System.Drawing.Font("FC Home", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.passBox2.Location = new System.Drawing.Point(499, 545);
            this.passBox2.Multiline = true;
            this.passBox2.Name = "passBox2";
            this.passBox2.PasswordChar = '*';
            this.passBox2.Size = new System.Drawing.Size(404, 50);
            this.passBox2.TabIndex = 62;
            this.passBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passBox_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("FC Home", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(773, 601);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 26);
            this.checkBox1.TabIndex = 60;
            this.checkBox1.Text = "เเสดงรหัสผ่าน";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("FC Palette", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-5, 722);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 30);
            this.label3.TabIndex = 59;
            this.label3.Text = "@NOOKNICK03_SHOP";
            // 
            // registerBut
            // 
            this.registerBut.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.registerBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerBut.Font = new System.Drawing.Font("FC Home", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBut.ForeColor = System.Drawing.Color.Cornsilk;
            this.registerBut.Location = new System.Drawing.Point(587, 644);
            this.registerBut.Name = "registerBut";
            this.registerBut.Size = new System.Drawing.Size(247, 52);
            this.registerBut.TabIndex = 57;
            this.registerBut.Text = "สมัครสมาชิก";
            this.registerBut.UseVisualStyleBackColor = false;
            this.registerBut.Click += new System.EventHandler(this.registerBut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 752);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // lnameBox
            // 
            this.lnameBox.BackColor = System.Drawing.Color.Gainsboro;
            this.lnameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameBox.Font = new System.Drawing.Font("FC Home", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lnameBox.Location = new System.Drawing.Point(500, 130);
            this.lnameBox.Multiline = true;
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(404, 50);
            this.lnameBox.TabIndex = 66;
            this.lnameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lnameBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(500, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 65;
            this.label1.Text = "นามสกุล";
            // 
            // userBox
            // 
            this.userBox.BackColor = System.Drawing.Color.Gainsboro;
            this.userBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userBox.Font = new System.Drawing.Font("FC Home", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.userBox.Location = new System.Drawing.Point(499, 447);
            this.userBox.Multiline = true;
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(404, 50);
            this.userBox.TabIndex = 68;
            this.userBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Sienna;
            this.label4.Location = new System.Drawing.Point(501, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 31);
            this.label4.TabIndex = 67;
            this.label4.Text = "ชื่อบัญชีผู้ใช้";
            // 
            // addressBox
            // 
            this.addressBox.BackColor = System.Drawing.Color.Gainsboro;
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressBox.Font = new System.Drawing.Font("FC Home", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.addressBox.Location = new System.Drawing.Point(499, 216);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(404, 103);
            this.addressBox.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(499, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 31);
            this.label6.TabIndex = 69;
            this.label6.Text = "ที่อยู่";
            // 
            // phoneBox
            // 
            this.phoneBox.BackColor = System.Drawing.Color.Gainsboro;
            this.phoneBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneBox.Font = new System.Drawing.Font("FC Home", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.phoneBox.Location = new System.Drawing.Point(499, 353);
            this.phoneBox.Multiline = true;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(404, 50);
            this.phoneBox.TabIndex = 72;
            this.phoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(499, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 31);
            this.label7.TabIndex = 71;
            this.label7.Text = "เบอร์โทรศัพท์";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel1.Font = new System.Drawing.Font("FC Home", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.SaddleBrown;
            this.linkLabel1.Location = new System.Drawing.Point(651, 708);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 26);
            this.linkLabel1.TabIndex = 73;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "กลับสู่หน้าหลัก";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Sienna;
            this.label8.Location = new System.Drawing.Point(499, 511);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 31);
            this.label8.TabIndex = 75;
            this.label8.Text = "ยืนยันรหัสผ่าน";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 748);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerBut);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerBut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
    }
}
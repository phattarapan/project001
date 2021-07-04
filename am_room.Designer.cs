
namespace project001
{
    partial class am_room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(am_room));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBut = new System.Windows.Forms.Button();
            this.resrtBut = new System.Windows.Forms.Button();
            this.searchBut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.downloadBut = new System.Windows.Forms.Button();
            this.picture_pr = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataproduct = new System.Windows.Forms.DataGridView();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.characteristicBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pr)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editBtn.Font = new System.Drawing.Font("FC Home", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.editBtn.Location = new System.Drawing.Point(962, 394);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(116, 45);
            this.editBtn.TabIndex = 180;
            this.editBtn.Text = "เเก้ไขรายการสินค้า";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Firebrick;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("FC Home", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.deleteBtn.Location = new System.Drawing.Point(823, 394);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(115, 45);
            this.deleteBtn.TabIndex = 179;
            this.deleteBtn.Text = "ลบ";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBut
            // 
            this.addBut.BackColor = System.Drawing.Color.BlueViolet;
            this.addBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBut.Font = new System.Drawing.Font("FC Home", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBut.ForeColor = System.Drawing.Color.Cornsilk;
            this.addBut.Location = new System.Drawing.Point(680, 394);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(115, 45);
            this.addBut.TabIndex = 177;
            this.addBut.Text = "เพิ่มรายการ";
            this.addBut.UseVisualStyleBackColor = false;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // resrtBut
            // 
            this.resrtBut.BackColor = System.Drawing.Color.Goldenrod;
            this.resrtBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resrtBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resrtBut.Font = new System.Drawing.Font("FC Home", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resrtBut.ForeColor = System.Drawing.Color.Cornsilk;
            this.resrtBut.Location = new System.Drawing.Point(1101, 392);
            this.resrtBut.Name = "resrtBut";
            this.resrtBut.Size = new System.Drawing.Size(116, 45);
            this.resrtBut.TabIndex = 184;
            this.resrtBut.Text = "รีเซต";
            this.resrtBut.UseVisualStyleBackColor = false;
            this.resrtBut.Click += new System.EventHandler(this.resrtBut_Click);
            // 
            // searchBut
            // 
            this.searchBut.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.searchBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBut.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBut.ForeColor = System.Drawing.Color.Cornsilk;
            this.searchBut.Location = new System.Drawing.Point(1117, 11);
            this.searchBut.Name = "searchBut";
            this.searchBut.Size = new System.Drawing.Size(100, 45);
            this.searchBut.TabIndex = 192;
            this.searchBut.Text = "ค้นหา";
            this.searchBut.UseVisualStyleBackColor = false;
            this.searchBut.Click += new System.EventHandler(this.searchBut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 217;
            this.pictureBox1.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchBox.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.Sienna;
            this.searchBox.Location = new System.Drawing.Point(678, 336);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(430, 44);
            this.searchBox.TabIndex = 191;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("FC Home", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(1173, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 66);
            this.label1.TabIndex = 228;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.uploadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uploadBtn.Font = new System.Drawing.Font("FC Home", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.uploadBtn.Location = new System.Drawing.Point(20, 394);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(202, 45);
            this.uploadBtn.TabIndex = 178;
            this.uploadBtn.Text = "อัพโหลดรูปภาพ";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // downloadBut
            // 
            this.downloadBut.BackColor = System.Drawing.SystemColors.GrayText;
            this.downloadBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downloadBut.Font = new System.Drawing.Font("FC Home", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadBut.ForeColor = System.Drawing.Color.Cornsilk;
            this.downloadBut.Location = new System.Drawing.Point(228, 394);
            this.downloadBut.Name = "downloadBut";
            this.downloadBut.Size = new System.Drawing.Size(147, 45);
            this.downloadBut.TabIndex = 185;
            this.downloadBut.Text = "ดาวน์โหลด";
            this.downloadBut.UseVisualStyleBackColor = false;
            this.downloadBut.Click += new System.EventHandler(this.downloadBut_Click);
            // 
            // picture_pr
            // 
            this.picture_pr.BackColor = System.Drawing.Color.White;
            this.picture_pr.Location = new System.Drawing.Point(20, 75);
            this.picture_pr.Name = "picture_pr";
            this.picture_pr.Size = new System.Drawing.Size(360, 314);
            this.picture_pr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_pr.TabIndex = 176;
            this.picture_pr.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dataproduct);
            this.panel1.Controls.Add(this.typeBox);
            this.panel1.Controls.Add(this.picture_pr);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.downloadBut);
            this.panel1.Controls.Add(this.amountBox);
            this.panel1.Controls.Add(this.uploadBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.searchBut);
            this.panel1.Controls.Add(this.resrtBut);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.idBox);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.priceBox);
            this.panel1.Controls.Add(this.addBut);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.characteristicBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-2, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 447);
            this.panel1.TabIndex = 220;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("FC Home", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Sienna;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "สติกเกอร์",
            "กระดาษโน๊ต",
            "ปากกา",
            "สมุด"});
            this.comboBox1.Location = new System.Drawing.Point(20, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 40);
            this.comboBox1.TabIndex = 273;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataproduct
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataproduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataproduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataproduct.BackgroundColor = System.Drawing.Color.White;
            this.dataproduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataproduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataproduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataproduct.ColumnHeadersHeight = 24;
            this.dataproduct.Location = new System.Drawing.Point(680, 62);
            this.dataproduct.Name = "dataproduct";
            this.dataproduct.RowHeadersWidth = 51;
            this.dataproduct.RowTemplate.Height = 24;
            this.dataproduct.Size = new System.Drawing.Size(537, 324);
            this.dataproduct.TabIndex = 253;
            this.dataproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataproduct_CellClick);
            // 
            // typeBox
            // 
            this.typeBox.BackColor = System.Drawing.Color.White;
            this.typeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.typeBox.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBox.ForeColor = System.Drawing.Color.Sienna;
            this.typeBox.Location = new System.Drawing.Point(476, 28);
            this.typeBox.Multiline = true;
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(190, 36);
            this.typeBox.TabIndex = 272;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.BurlyWood;
            this.label7.Font = new System.Drawing.Font("FC Home", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(476, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 26);
            this.label7.TabIndex = 271;
            this.label7.Text = "ประเภทสินค้า";
            // 
            // amountBox
            // 
            this.amountBox.BackColor = System.Drawing.Color.White;
            this.amountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.amountBox.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountBox.ForeColor = System.Drawing.Color.Sienna;
            this.amountBox.Location = new System.Drawing.Point(400, 399);
            this.amountBox.Multiline = true;
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(266, 36);
            this.amountBox.TabIndex = 270;
            this.amountBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Font = new System.Drawing.Font("FC Home", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(401, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 26);
            this.label3.TabIndex = 269;
            this.label3.Text = "จำนวนสินค้า";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.White;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameBox.Font = new System.Drawing.Font("FC Home", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.Sienna;
            this.nameBox.Location = new System.Drawing.Point(400, 95);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(266, 55);
            this.nameBox.TabIndex = 266;
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.AliceBlue;
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.idBox.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.ForeColor = System.Drawing.Color.Sienna;
            this.idBox.Location = new System.Drawing.Point(400, 28);
            this.idBox.Multiline = true;
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(70, 36);
            this.idBox.TabIndex = 267;
            // 
            // priceBox
            // 
            this.priceBox.BackColor = System.Drawing.Color.White;
            this.priceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.priceBox.Font = new System.Drawing.Font("FC Home", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.ForeColor = System.Drawing.Color.Sienna;
            this.priceBox.Location = new System.Drawing.Point(401, 335);
            this.priceBox.Multiline = true;
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(265, 36);
            this.priceBox.TabIndex = 265;
            this.priceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.BurlyWood;
            this.label6.Font = new System.Drawing.Font("FC Home", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(395, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 26);
            this.label6.TabIndex = 263;
            this.label6.Text = " ราคา";
            // 
            // characteristicBox
            // 
            this.characteristicBox.BackColor = System.Drawing.Color.White;
            this.characteristicBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.characteristicBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.characteristicBox.Font = new System.Drawing.Font("FC Home", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characteristicBox.ForeColor = System.Drawing.Color.Sienna;
            this.characteristicBox.Location = new System.Drawing.Point(400, 182);
            this.characteristicBox.Multiline = true;
            this.characteristicBox.Name = "characteristicBox";
            this.characteristicBox.Size = new System.Drawing.Size(266, 126);
            this.characteristicBox.TabIndex = 264;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BurlyWood;
            this.label5.Font = new System.Drawing.Font("FC Home", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(395, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 26);
            this.label5.TabIndex = 262;
            this.label5.Text = "รายละเอียดสินค้า";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Font = new System.Drawing.Font("FC Home", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(395, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 26);
            this.label4.TabIndex = 261;
            this.label4.Text = "ชื่อสินค้า";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.BurlyWood;
            this.label8.Font = new System.Drawing.Font("FC Home", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(396, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 26);
            this.label8.TabIndex = 274;
            this.label8.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Font = new System.Drawing.Font("FC Home", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 26);
            this.label2.TabIndex = 268;
            this.label2.Text = "ประเภทรายการสินค้า ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(420, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(392, 306);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 218;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(826, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(392, 306);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 219;
            this.pictureBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("FC Home", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Sienna;
            this.label9.Location = new System.Drawing.Point(3, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(345, 41);
            this.label9.TabIndex = 265;
            this.label9.Text = "แก้ไขรายการสินค้าในคลัง";
            // 
            // am_room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1229, 770);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "am_room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "amroom";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.am_room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pr)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Button resrtBut;
        private System.Windows.Forms.Button searchBut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Button downloadBut;
        private System.Windows.Forms.PictureBox picture_pr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        internal System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox characteristicBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataproduct;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
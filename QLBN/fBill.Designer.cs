namespace QLBN
{
    partial class fBill
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
            panel2 = new Panel();
            txbMHD = new TextBox();
            label11 = new Label();
            dtRV = new DateTimePicker();
            label10 = new Label();
            dtNV = new DateTimePicker();
            txbkhoa = new TextBox();
            txbTB = new TextBox();
            txbhoten = new TextBox();
            txbid = new TextBox();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            txbThanhTien = new TextBox();
            label9 = new Label();
            txbDonGia = new TextBox();
            label6 = new Label();
            SoLuong = new NumericUpDown();
            btnThem = new Button();
            label7 = new Label();
            label5 = new Label();
            cbThuoc = new ComboBox();
            panel4 = new Panel();
            txbTong = new TextBox();
            button1 = new Button();
            txbTongTien = new TextBox();
            txbGB = new TextBox();
            button4 = new Button();
            GiamGia = new NumericUpDown();
            button3 = new Button();
            button2 = new Button();
            dtgvBill = new DataGridView();
            button5 = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SoLuong).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GiamGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txbMHD);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(dtRV);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(dtNV);
            panel2.Controls.Add(txbkhoa);
            panel2.Controls.Add(txbTB);
            panel2.Controls.Add(txbhoten);
            panel2.Controls.Add(txbid);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(14, 14);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1261, 200);
            panel2.TabIndex = 2;
            // 
            // txbMHD
            // 
            txbMHD.Location = new Point(1063, 127);
            txbMHD.Name = "txbMHD";
            txbMHD.Size = new Size(175, 39);
            txbMHD.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(905, 127);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(144, 32);
            label11.TabIndex = 17;
            label11.Text = "Mã hoá đơn";
            // 
            // dtRV
            // 
            dtRV.Format = DateTimePickerFormat.Short;
            dtRV.Location = new Point(652, 127);
            dtRV.Name = "dtRV";
            dtRV.Size = new Size(224, 39);
            dtRV.TabIndex = 16;
            dtRV.ValueChanged += dtRV_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(483, 132);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(154, 32);
            label10.TabIndex = 15;
            label10.Text = "Ngày ra viện:";
            label10.Click += label10_Click;
            // 
            // dtNV
            // 
            dtNV.Format = DateTimePickerFormat.Short;
            dtNV.Location = new Point(236, 132);
            dtNV.Name = "dtNV";
            dtNV.Size = new Size(193, 39);
            dtNV.TabIndex = 14;
            dtNV.ValueChanged += dtNS_ValueChanged;
            // 
            // txbkhoa
            // 
            txbkhoa.Location = new Point(822, 18);
            txbkhoa.Name = "txbkhoa";
            txbkhoa.Size = new Size(416, 39);
            txbkhoa.TabIndex = 13;
            // 
            // txbTB
            // 
            txbTB.Location = new Point(822, 70);
            txbTB.Name = "txbTB";
            txbTB.Size = new Size(416, 39);
            txbTB.TabIndex = 12;
            // 
            // txbhoten
            // 
            txbhoten.Location = new Point(236, 73);
            txbhoten.Name = "txbhoten";
            txbhoten.Size = new Size(416, 39);
            txbhoten.TabIndex = 11;
            // 
            // txbid
            // 
            txbid.Location = new Point(236, 18);
            txbid.Name = "txbid";
            txbid.Size = new Size(416, 39);
            txbid.TabIndex = 10;
            txbid.TextChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(684, 21);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(103, 32);
            label8.TabIndex = 8;
            label8.Text = "ID Khoa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 132);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(188, 32);
            label4.TabIndex = 3;
            label4.Text = "Ngày nhập viện:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 21);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(169, 32);
            label3.TabIndex = 2;
            label3.Text = "ID Bệnh Nhân:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(684, 77);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 32);
            label2.TabIndex = 1;
            label2.Text = "Bệnh:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 77);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbThanhTien);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txbDonGia);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(SoLuong);
            panel3.Controls.Add(btnThem);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(cbThuoc);
            panel3.Location = new Point(14, 224);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1261, 123);
            panel3.TabIndex = 6;
            // 
            // txbThanhTien
            // 
            txbThanhTien.Location = new Point(724, 62);
            txbThanhTien.Name = "txbThanhTien";
            txbThanhTien.Size = new Size(240, 39);
            txbThanhTien.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(556, 69);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(165, 32);
            label9.TabIndex = 9;
            label9.Text = "Thành tiền:";
            // 
            // txbDonGia
            // 
            txbDonGia.Location = new Point(724, 13);
            txbDonGia.Name = "txbDonGia";
            txbDonGia.Size = new Size(240, 39);
            txbDonGia.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(556, 17);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(128, 32);
            label6.TabIndex = 7;
            label6.Text = "Đơn giá:";
            // 
            // SoLuong
            // 
            SoLuong.Location = new Point(202, 62);
            SoLuong.Margin = new Padding(5);
            SoLuong.Name = "SoLuong";
            SoLuong.Size = new Size(270, 39);
            SoLuong.TabIndex = 6;
            SoLuong.TextAlign = HorizontalAlignment.Center;
            SoLuong.ValueChanged += numericUpDown1_ValueChanged_1;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(1055, 21);
            btnThem.Margin = new Padding(5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(153, 80);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 69);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(157, 32);
            label7.TabIndex = 4;
            label7.Text = "Số Lượng:";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 17);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(124, 32);
            label5.TabIndex = 2;
            label5.Text = "Dịch vụ:";
            // 
            // cbThuoc
            // 
            cbThuoc.FormattingEnabled = true;
            cbThuoc.Location = new Point(202, 14);
            cbThuoc.Margin = new Padding(5);
            cbThuoc.Name = "cbThuoc";
            cbThuoc.Size = new Size(270, 40);
            cbThuoc.TabIndex = 0;
            cbThuoc.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // panel4
            // 
            panel4.Controls.Add(button5);
            panel4.Controls.Add(txbTong);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(txbTongTien);
            panel4.Controls.Add(txbGB);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(GiamGia);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Location = new Point(14, 726);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1261, 175);
            panel4.TabIndex = 7;
            // 
            // txbTong
            // 
            txbTong.Location = new Point(236, 106);
            txbTong.Name = "txbTong";
            txbTong.Size = new Size(216, 39);
            txbTong.TabIndex = 13;
            txbTong.TextChanged += txbTong_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(236, 23);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(216, 58);
            button1.TabIndex = 12;
            button1.Text = "Tổng tiền";
            button1.UseVisualStyleBackColor = true;
            // 
            // txbTongTien
            // 
            txbTongTien.Location = new Point(956, 21);
            txbTongTien.Name = "txbTongTien";
            txbTongTien.Size = new Size(282, 39);
            txbTongTien.TabIndex = 11;
            txbTongTien.TextChanged += txbTongTien_TextChanged;
            // 
            // txbGB
            // 
            txbGB.Location = new Point(23, 106);
            txbGB.Name = "txbGB";
            txbGB.Size = new Size(197, 39);
            txbGB.TabIndex = 10;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(23, 21);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Size = new Size(197, 58);
            button4.TabIndex = 9;
            button4.Text = "Giường bệnh";
            button4.UseVisualStyleBackColor = true;
            // 
            // GiamGia
            // 
            GiamGia.Location = new Point(483, 106);
            GiamGia.Margin = new Padding(5);
            GiamGia.Name = "GiamGia";
            GiamGia.Size = new Size(223, 39);
            GiamGia.TabIndex = 8;
            GiamGia.TextAlign = HorizontalAlignment.Center;
            GiamGia.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(483, 23);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(223, 58);
            button3.TabIndex = 7;
            button3.Text = "Miễn Giảm";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(949, 81);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(289, 67);
            button2.TabIndex = 6;
            button2.Text = "Thanh toán";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dtgvBill
            // 
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(14, 345);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowHeadersWidth = 82;
            dtgvBill.RowTemplate.Height = 41;
            dtgvBill.Size = new Size(1258, 373);
            dtgvBill.TabIndex = 8;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(747, 23);
            button5.Margin = new Padding(5);
            button5.Name = "button5";
            button5.Size = new Size(153, 122);
            button5.TabIndex = 11;
            button5.Text = "Lưu";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // fBill
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 915);
            Controls.Add(dtgvBill);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "fBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hoá Đơn";
            Load += fBill_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SoLuong).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GiamGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txbkhoa;
        private TextBox txbTB;
        private TextBox txbhoten;
        private Panel panel3;
        private NumericUpDown SoLuong;
        private Button btnThem;
        private Label label7;
        private Label label5;
        private ComboBox cbThuoc;
        private Panel panel4;
        private TextBox txbTongTien;
        private Button button4;
        private NumericUpDown GiamGia;
        private Button button3;
        private Button button2;
        public TextBox txbid;
        private DateTimePicker dtNV;
        public TextBox txbGB;
        private TextBox txbThanhTien;
        private Label label9;
        private TextBox txbDonGia;
        private Label label6;
        private DataGridView dtgvBill;
        private DateTimePicker dtRV;
        private Label label10;
        private TextBox txbMHD;
        private Label label11;
        public TextBox txbTong;
        private Button button1;
        private Button button5;
    }
}
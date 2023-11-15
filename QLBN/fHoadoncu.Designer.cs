namespace QLBN
{
    partial class fHoadoncu
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
            dtgvHD = new DataGridView();
            panel2 = new Panel();
            txbThanhTien = new TextBox();
            label8 = new Label();
            txbTT = new TextBox();
            label7 = new Label();
            txbGG = new TextBox();
            label6 = new Label();
            txbMHD = new TextBox();
            label11 = new Label();
            dtRV = new DateTimePicker();
            label10 = new Label();
            dtNV = new DateTimePicker();
            txbTB = new TextBox();
            txbhoten = new TextBox();
            txbid = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvHD).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvHD
            // 
            dtgvHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvHD.Location = new Point(12, 272);
            dtgvHD.Name = "dtgvHD";
            dtgvHD.RowHeadersWidth = 82;
            dtgvHD.RowTemplate.Height = 41;
            dtgvHD.Size = new Size(1288, 373);
            dtgvHD.TabIndex = 9;
            dtgvHD.CellContentClick += dtgvBill_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(txbThanhTien);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txbTT);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txbGG);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txbMHD);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(dtRV);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(dtNV);
            panel2.Controls.Add(txbTB);
            panel2.Controls.Add(txbhoten);
            panel2.Controls.Add(txbid);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(14, 14);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1261, 250);
            panel2.TabIndex = 10;
            // 
            // txbThanhTien
            // 
            txbThanhTien.Location = new Point(1045, 190);
            txbThanhTien.Name = "txbThanhTien";
            txbThanhTien.Size = new Size(193, 39);
            txbThanhTien.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(879, 193);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(134, 32);
            label8.TabIndex = 25;
            label8.Text = "Thành tiền:";
            // 
            // txbTT
            // 
            txbTT.Location = new Point(236, 190);
            txbTT.Name = "txbTT";
            txbTT.Size = new Size(175, 39);
            txbTT.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 193);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(122, 32);
            label7.TabIndex = 23;
            label7.Text = "Tổng tiền:";
            // 
            // txbGG
            // 
            txbGG.Location = new Point(617, 193);
            txbGG.Name = "txbGG";
            txbGG.Size = new Size(224, 39);
            txbGG.TabIndex = 22;
            txbGG.TextChanged += txbGG_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(455, 193);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 32);
            label6.TabIndex = 21;
            label6.Text = "Giảm giá:";
            // 
            // txbMHD
            // 
            txbMHD.Location = new Point(836, 18);
            txbMHD.Name = "txbMHD";
            txbMHD.Size = new Size(402, 39);
            txbMHD.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(684, 18);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(144, 32);
            label11.TabIndex = 17;
            label11.Text = "Mã hoá đơn";
            // 
            // dtRV
            // 
            dtRV.Format = DateTimePickerFormat.Short;
            dtRV.Location = new Point(864, 129);
            dtRV.Name = "dtRV";
            dtRV.Size = new Size(224, 39);
            dtRV.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(684, 132);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(154, 32);
            label10.TabIndex = 15;
            label10.Text = "Ngày ra viện:";
            // 
            // dtNV
            // 
            dtNV.Format = DateTimePickerFormat.Short;
            dtNV.Location = new Point(236, 132);
            dtNV.Name = "dtNV";
            dtNV.Size = new Size(229, 39);
            dtNV.TabIndex = 14;
            // 
            // txbTB
            // 
            txbTB.Location = new Point(836, 70);
            txbTB.Name = "txbTB";
            txbTB.Size = new Size(402, 39);
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
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 138);
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
            // fHoadoncu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 664);
            Controls.Add(panel2);
            Controls.Add(dtgvHD);
            Name = "fHoadoncu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fHoadoncu";
            ((System.ComponentModel.ISupportInitialize)dtgvHD).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvHD;
        private Panel panel2;
        private TextBox txbMHD;
        private Label label11;
        private DateTimePicker dtRV;
        private Label label10;
        private DateTimePicker dtNV;
        private TextBox txbTB;
        private TextBox txbhoten;
        public TextBox txbid;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txbTT;
        private Label label7;
        private TextBox txbGG;
        private Label label6;
        private TextBox txbThanhTien;
        private Label label8;
    }
}
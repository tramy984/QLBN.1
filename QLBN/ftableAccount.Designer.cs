namespace QLBN
{
    partial class ftableAccount
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
            panel4 = new Panel();
            txbMK = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            txbTHT = new TextBox();
            label2 = new Label();
            txbTDN = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            txbMKM = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            txbNHMKM = new TextBox();
            label5 = new Label();
            btnLogin = new Button();
            button1 = new Button();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(txbMK);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(18, 200);
            panel4.Name = "panel4";
            panel4.Size = new Size(730, 88);
            panel4.TabIndex = 4;
            // 
            // txbMK
            // 
            txbMK.Location = new Point(276, 27);
            txbMK.Name = "txbMK";
            txbMK.Size = new Size(424, 39);
            txbMK.TabIndex = 1;
            txbMK.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 27);
            label4.Name = "label4";
            label4.Size = new Size(152, 34);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 27);
            label3.Name = "label3";
            label3.Size = new Size(233, 34);
            label3.TabIndex = 0;
            label3.Text = "Tên đăng nhập:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txbTHT);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(18, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 88);
            panel1.TabIndex = 2;
            // 
            // txbTHT
            // 
            txbTHT.Location = new Point(276, 27);
            txbTHT.Name = "txbTHT";
            txbTHT.Size = new Size(424, 39);
            txbTHT.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 27);
            label2.Name = "label2";
            label2.Size = new Size(189, 34);
            label2.TabIndex = 0;
            label2.Text = "Tên hiển thị:";
            // 
            // txbTDN
            // 
            txbTDN.Location = new Point(276, 27);
            txbTDN.Name = "txbTDN";
            txbTDN.Size = new Size(424, 39);
            txbTDN.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbTDN);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(18, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(730, 88);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(txbMKM);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(18, 294);
            panel2.Name = "panel2";
            panel2.Size = new Size(730, 88);
            panel2.TabIndex = 5;
            // 
            // txbMKM
            // 
            txbMKM.Location = new Point(276, 27);
            txbMKM.Name = "txbMKM";
            txbMKM.Size = new Size(424, 39);
            txbMKM.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(215, 34);
            label1.TabIndex = 0;
            label1.Text = "Mật khẩu mới:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbNHMKM);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(18, 388);
            panel5.Name = "panel5";
            panel5.Size = new Size(730, 88);
            panel5.TabIndex = 6;
            // 
            // txbNHMKM
            // 
            txbNHMKM.Location = new Point(276, 27);
            txbNHMKM.Name = "txbNHMKM";
            txbNHMKM.Size = new Size(424, 39);
            txbNHMKM.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 27);
            label5.Name = "label5";
            label5.Size = new Size(138, 34);
            label5.TabIndex = 0;
            label5.Text = "Nhập lại:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(356, 502);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 46);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Cập nhật";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // button1
            // 
            button1.Location = new Point(568, 502);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 8;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            // 
            // ftableAccount
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 564);
            Controls.Add(button1);
            Controls.Add(btnLogin);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "ftableAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông Tin Tài Khoản";
            Load += ftableAccount_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private TextBox txbMK;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private TextBox txbTHT;
        private Label label2;
        private Panel panel3;
        private Panel panel2;
        private TextBox txbMKM;
        private Label label1;
        private Panel panel5;
        private TextBox txbNHMKM;
        private Label label5;
        private Button btnLogin;
        private Button button1;
        public TextBox txbTDN;
    }
}
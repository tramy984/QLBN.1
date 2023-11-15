namespace QLBN
{
    partial class fLogin
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
            panel1 = new Panel();
            btnExit = new Button();
            btnLogin = new Button();
            panel3 = new Panel();
            txbPassword = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txbUsername = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 283);
            panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(593, 220);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 3;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(427, 220);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 46);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassword);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(23, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(757, 94);
            panel3.TabIndex = 1;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(312, 32);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(380, 39);
            txbPassword.TabIndex = 1;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 31);
            label2.Name = "label2";
            label2.Size = new Size(166, 37);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUsername);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(20, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(757, 94);
            panel2.TabIndex = 0;
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(312, 32);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(380, 39);
            txbUsername.TabIndex = 1;
            txbUsername.TextChanged += txbUsername_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 31);
            label1.Name = "label1";
            label1.Size = new Size(253, 37);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // fLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 312);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += fLogin_FormClosing;
            Load += fLogin_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnLogin;
        private Panel panel3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        public TextBox txbPassword;
        public TextBox txbUsername;
    }
}
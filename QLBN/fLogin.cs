using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Identity;
using Microsoft.Data.SqlClient;

namespace QLBN
{
    public partial class fLogin : Form
    {
        public string username;
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;
            // Cần mã hóa mật khẩu trước khi lưu vào cơ sở dữ liệu và so sánh sau khi giải mã.
            string connectionString = "Data Source=.;Initial Catalog=QLYBENHNHAN;Integrated Security=True;Encrypt=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM [dbo].Account WHERE TenDangNhap= @Username AND MatKhau = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {

                    ftableKhoa f = new ftableKhoa(username);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();


                }
                else
                    MessageBox.Show("Vui lòng nhập lại thông tin", "THÔNG BÁO");

            }

        }


        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

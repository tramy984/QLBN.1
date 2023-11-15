using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QLBN
{


    public partial class ftableAccount : Form
    {
        private string id;

        public ftableAccount(string username)
        {
            InitializeComponent();
            txbTDN.Text = username;
            LoadAC();

        }

        private void ftableAccount_Load(object sender, EventArgs e)
        {


        }
        //string username=fLogin.getusername();

        void LoadAC()
        {
            //MessageBox.Show(txbTDN.Text);
            string connectionString = "Data Source=.;Initial Catalog=QLYBENHNHAN;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM [dbo].Account WHERE TenDangNhap=@TenDangNhap";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@TenDangNhap", txbTDN.Text);


            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                id = reader["id"].ToString();
                // Đọc dữ liệu từ cơ sở dữ liệu và gán vào các TextBox
                txbTDN.Text = reader["TenDangNhap"].ToString();
                txbTHT.Text = reader["TenHienThi"].ToString();
                txbMK.Text = reader["MatKhau"].ToString();
            }
            else
            {
                //Nếu không tìm thấy thông tin cho Tên Đăng Nhập cụ thể
                MessageBox.Show("Không tìm thấy Tên Đăng Nhập này trong cơ sở dữ liệu.");
            }

            reader.Close();
            connection.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {


                using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=QLYBENHNHAN;Integrated Security=True;Encrypt=False"))
                {
                    connection.Open();
                    string query = "UPDATE dbo.Account SET TenDangNhap=@TDN, TenHienThi=@THT, MatKhau=@MKM where id=@id";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@TDN", txbTDN.Text);
                        cmd.Parameters.AddWithValue("@THT", txbTHT.Text);
                        cmd.Parameters.AddWithValue("@MKM", txbMKM.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Sửa thông tin cá nhân thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi cho người dùng hoặc ghi vào file log
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

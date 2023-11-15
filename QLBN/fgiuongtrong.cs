using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QLBN
{
    public partial class fgiuongtrong : Form
    {
        public fgiuongtrong()
        {
            InitializeComponent();
           // HienThiThongTinGiuong();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpgiuongtrong_Paint(object sender, PaintEventArgs e)
        {
              
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=QLYBENHNHAN;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM dbo.Giuongbenh";
            SqlCommand command = new SqlCommand(query, connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string maGiuong = reader["MaGB"].ToString();
                  
                    string tenGiuong = reader["nameGB"].ToString();



                    string columnName = reader["nameGB"].ToString();
                    int status = Convert.ToInt32(reader["status"]);

                    Button button = new Button();
                    button.Text = columnName;

                    if (status == 0)
                    {
                        button.BackColor = Color.Green; // Trạng thái "Trống"

                    }
                    else
                    {
                        button.BackColor = Color.Yellow; // Trạng thái "Đã có người ở"
                    }

                    button.Size = new Size(180, 120);
                    flpgiuongtrong.Controls.Add(button);
                    button.Click += new EventHandler(button_Click);
                }
            }
            connection.Close();
        }

        public string tenGiuong;

        private void HienThiThongTinGiuong(string tenGiuong)
        {
            string connectionString = "Data Source=.;Initial Catalog=QLYBENHNHAN;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT G.MaGB, G.status, G.nameGB, B.Name, BS.nameBS, YT.nameYT " +
                   "FROM dbo.Giuongbenh AS G " +
                   "JOIN dbo.Benhnhan AS B ON G.MaGB = B.MaGiuong " +
               "LEFT JOIN dbo.BacSi AS BS ON B.MaBacSi = BS.MaBacSi " +
               "LEFT JOIN dbo.YTa AS YT ON B.MaYTa = YT.MaYTa " +
               "WHERE G.nameGB = @TenGiuong";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TenGiuong", tenGiuong);

            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    int status = Convert.ToInt32(reader["status"]);
                    if (status == 1)
                    {
                        txbTenGiuong.Text = reader["nameGB"].ToString();
                        txbMaGiuong.Text = reader["MaGB"].ToString();

                        txbTenBenhNhan.Text = reader["Name"].ToString();
                        txbTenBacSi.Text = reader["nameBS"].ToString();
                        txbTenYTa.Text = reader["nameYT"].ToString();
                    }
                    else 
                    {
                        txbTenGiuong.Text = reader["nameGB"].ToString();
                        txbMaGiuong.Text = reader["MaGB"].ToString();
                    }
                }
            }
            connection.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            tenGiuong = clickedButton.Text; // Lưu tên giường vào biến toàn cục

            HienThiThongTinGiuong(tenGiuong);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBN.DAO;

namespace QLBN
{
    public partial class fBenhNhanCu : Form
    {
        private ListBenhNhan ListBenhNhan;
        public fBenhNhanCu()
        {
            InitializeComponent();
            LoadBenhNhanDaRaVien();
            this.ListBenhNhan = new ListBenhNhan();
        }
        void LoadBenhNhanDaRaVien()
        {
            string query = "SELECT * FROM dbo.Benhnhancu";
            DataProvider provider = new DataProvider();
            dtgvbenhnhancu.DataSource = provider.ExecuteQuery(query);
        }

        private void dtgvbenhnhancu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ListBenhNhan.LoadDataFromSelectedRow(dtgvbenhnhancu, txbid, txbhoten, cbGT, DtNgaySinh, txbCCCD, txbBHYT, txbSDT, NgayNhapVien, NgayRaVien, txbkhoa, txbBacsi, txbYta, txbBenh, txbGB);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            ListBenhNhan.TimKiemBN(dtgvbenhnhancu, txbTK, "10");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fHoadoncu f = new fHoadoncu(txbid.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}

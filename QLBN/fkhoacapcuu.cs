using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBN.DAO;

namespace QLBN
{
    public partial class fkhoacapcuu : Form
    {
        private ListBenhNhan ListBenhNhan;
        public fkhoacapcuu()
        {
            InitializeComponent();
            LoadBenhNhanKhoaCapCuu();
            this.ListBenhNhan = new ListBenhNhan();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public class Dataobject
        {
            public string Name { get; set; }
        }
        private void dtgvkhoacapcuu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ListBenhNhan.LoadDataFromSelectedRow(dtgvkhoacapcuu, txbid, txbhoten, cbGT, DtNgaySinh, txbCCCD, txbBHYT, txbSDT, NgayNhapVien, NgayRaVien, txbkhoa, txbBacsi, txbYta, txbBenh, txbGB);
        }
        void LoadBenhNhanKhoaCapCuu()
        {
            string query = "SELECT * FROM dbo.Benhnhan Where MaKhoa=10";
            DataProvider provider = new DataProvider();
            dtgvkhoacapcuu.DataSource = provider.ExecuteQuery(query);
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*ftableAccount f = new ftableAccount();
            this.Hide();
            f.ShowDialog();
            this.Show();*/
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kiểmTraGiườngTrốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fgiuongtrong f = new fgiuongtrong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void txbBHYT_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fBill f = new fBill(txbid.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadBenhNhanKhoaCapCuu();
        }

        private void txbTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {


            ListBenhNhan.ThemBenhNhan(txbid, txbhoten, cbGT, DtNgaySinh, txbCCCD, txbBHYT, txbSDT, NgayNhapVien, NgayRaVien, txbkhoa, txbBacsi, txbYta, txbBenh, txbGB);
            LoadBenhNhanKhoaCapCuu();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ListBenhNhan.XoaBenhNhan(txbid);
            LoadBenhNhanKhoaCapCuu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ListBenhNhan.SuaBenhNhan(txbid, txbhoten, cbGT, DtNgaySinh, txbCCCD, txbBHYT, txbSDT, NgayNhapVien, NgayRaVien, txbkhoa, txbBacsi, txbYta, txbBenh, txbGB);
            LoadBenhNhanKhoaCapCuu();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            
            ListBenhNhan.TimKiemBN(dtgvkhoacapcuu, txbTK,"10");
        }
    }
}

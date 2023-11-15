using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBN
{
    public partial class ftableKhoa : Form
    {
        private fLogin fLogin = new fLogin();
        private string username;
        public ftableKhoa(string username)
        {
            InitializeComponent();
            this.username = username;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnkhoacapcuu_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thồnTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ftableAccount f = new ftableAccount(username);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnkhoacapcuu_Click_1(object sender, EventArgs e)
        {
            fkhoacapcuu f = new fkhoacapcuu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void kiểmTraGiườngTrốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fgiuongtrong f = new fgiuongtrong();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRHM_Click(object sender, EventArgs e)
        {
            /*fkhoaRHM f = new fkhoaRHM();
            this.Hide();
            f.ShowDialog();
            this.Show();*/
        }

        private void btnungbuou_Click(object sender, EventArgs e)
        {
            // fkhoaungbuou f = new fkhoaungbuou();
            //this.Hide();
            //f.ShowDialog();
            //this.Show();
        }

        private void btntieuhoa_Click(object sender, EventArgs e)
        {
            /*fkhoatieuhoa f = new fkhoatieuhoa();
            this.Hide();
            f.ShowDialog();
            this.Show();*/
        }

        private void btnCTCH_Click(object sender, EventArgs e)
        {
            /*fCTCH f = new fCTCH();
            this.Hide();
            f.ShowDialog();
            this.Show();*/
        }

        private void btnthankinh_Click(object sender, EventArgs e)
        {
            /*   fthankinh f = new fthankinh();
               this.Hide();
               f.ShowDialog();
               this.Show();*/
        }

        private void btnkhoatimmach_Click(object sender, EventArgs e)
        {
            /*   ftimmach f = new ftimmach();
               this.Hide();
               f.ShowDialog();
               this.Show();*/
        }

        private void btnTMH_Click(object sender, EventArgs e)
        {
            /*   fTMH f = new fTMH();
               this.Hide(); f.ShowDialog();
               this.Show();*/
        }

        private void btnkhoamat_Click(object sender, EventArgs e)
        {
            /*fmat f = new fmat();
            this.Hide(); f.ShowDialog();
            this.Show();*/
        }

        private void btnkhoadalieu_Click(object sender, EventArgs e)
        {
            /* fdalieu f = new fdalieu();
             this.Hide(); f.ShowDialog();
             this.Show();*/
        }

        private void btntruyennhiem_Click(object sender, EventArgs e)
        {
            /*ftruyennhiem f = new ftruyennhiem();
            this.Hide(); f.ShowDialog();
            this.Show();*/
        }

        private void btnkhoanhi_Click(object sender, EventArgs e)
        {
            /* fnhi f=new fnhi();
             this.Hide(); f.ShowDialog();
             this.Show();*/
        }

        private void danhSáchBệnhNhânCũToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBenhNhanCu f = new fBenhNhanCu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}

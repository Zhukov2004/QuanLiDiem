using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDiemDaiHoc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private string VaiTro;

        public frmMain(string vaitro)
        {
            InitializeComponent();
            VaiTro = vaitro;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (VaiTro == "User")
            {
                mnuGiangVien.Visible = false;
                mnuTaiKhoan.Visible = false;
                mnuThongKe.Visible = false;
            }
            label1.Text = $"Xin chào: {VaiTro}";
        }

        private void điểmSốVàHọcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void điểmSốHọcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Hide();
                new Form1().Show();
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuSinhVien_Click(object sender, EventArgs e)
        {
            frmSinhVien sinhvien = new frmSinhVien();
            sinhvien.Show();
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            frmLop lop = new frmLop();
            lop.Show();
        }

        private void mnuNganh_Click(object sender, EventArgs e)
        {
            frmNganh nganh = new frmNganh();
            nganh.Show();
        }

        private void mnuKhoa_Click(object sender, EventArgs e)
        {
            frmKhoa khoa = new frmKhoa();
            khoa.Show();
        }

        private void mnuGiangVien_Click(object sender, EventArgs e)
        {
            frmGiangVien giangvien = new frmGiangVien();
            giangvien.Show();
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan tk = new frmTaiKhoan();
            tk.Show();
        }
    }
}

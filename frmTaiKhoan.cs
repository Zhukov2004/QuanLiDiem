using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiDiemDaiHoc.Controllers;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc
{
    public partial class frmTaiKhoan : Form
    {
        TaiKhoanController controller = new TaiKhoanController();
        public frmTaiKhoan()
        {
            InitializeComponent();
        }
        private float gradientAngle = 0f;
        private System.Windows.Forms.Timer timerGradient;


        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            cboVaiTro.SelectedIndex = -1;
            dgvTaiKhoan.DataSource = controller.LayDanhSach();
            timerGradient = new System.Windows.Forms.Timer();
            timerGradient.Interval = 20; // càng nhỏ càng mượt
            timerGradient.Tick += (s, e) =>
            {
                gradientAngle += 1.5f;
                if (gradientAngle >= 360f) gradientAngle = 0;
                this.Invalidate(); // Vẽ lại form
            };
            timerGradient.Start();

        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvTaiKhoan.Rows[e.RowIndex];
                txtTenDN.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                cboVaiTro.Text = row.Cells["VaiTro"].Value.ToString();
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            var tk = new TaiKhoan
            {
                TenDangNhap = txtTenDN.Text.Trim(),
                MatKhau = txtMatKhau.Text.Trim(),
                VaiTro = cboVaiTro.Text
            };

            if (controller.Them(tk))
                MessageBox.Show("Đã thêm tài khoản!");
            else
                MessageBox.Show("Thêm thất bại!");

            dgvTaiKhoan.DataSource = controller.LayDanhSach();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            var tk = new TaiKhoan
            {
                TenDangNhap = txtTenDN.Text.Trim(),
                MatKhau = txtMatKhau.Text.Trim(),
                VaiTro = cboVaiTro.Text
            };

            if (controller.Sua(tk))
                MessageBox.Show("Đã cập nhật!");
            else
                MessageBox.Show("Cập nhật thất bại!");

            dgvTaiKhoan.DataSource = controller.LayDanhSach();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDN.Text.Trim();
            if (string.IsNullOrEmpty(tenDN))
            {
                MessageBox.Show("Chọn tài khoản cần xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                if (controller.Xoa(tenDN))
                    MessageBox.Show("Đã xóa!");
                else
                    MessageBox.Show("Xóa thất bại!");
                dgvTaiKhoan.DataSource = controller.LayDanhSach();
            }
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(kw))
                dgvTaiKhoan.DataSource = controller.LayDanhSach();
            else
                dgvTaiKhoan.DataSource = controller.TimKiem(kw);
        }

        private void frmTaiKhoan_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu click vào vùng trống (không phải control con)
            Control ctl = this.GetChildAtPoint(this.PointToClient(Cursor.Position));
            if (ctl == null)
            {
                // Xóa tất cả các ô nhập liệu thủ công
                txtTenDN.Clear();
                txtMatKhau.Clear();
                txtTimKiem.Clear();
                cboVaiTro.SelectedIndex = -1;
            }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(70, 130, 255), // màu 1
                Color.FromArgb(255, 90, 90),  // màu 2
                gradientAngle))               // góc xoay động
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }


    }
}

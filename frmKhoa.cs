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
    public partial class frmKhoa : Form
    {
        KhoaController controller = new KhoaController();
        public frmKhoa()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.Timer timerGradient;
        private float gradientAngle = 0;
        private void them_Click(object sender, EventArgs e)
        {
            var k = new Khoa { MaKhoa = txtMaKhoa.Text.Trim(), TenKhoa = txtTenKhoa.Text.Trim() };
            if (controller.Them(k))
                MessageBox.Show("Thêm khoa thành công!");
            else
                MessageBox.Show("Không thể thêm khoa!");

            dgvKhoa.DataSource = controller.LayDanhSach();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            var k = new Khoa { MaKhoa = txtMaKhoa.Text.Trim(), TenKhoa = txtTenKhoa.Text.Trim() };
            if (controller.Sua(k))
                MessageBox.Show("Sửa thành công!");
            else
                MessageBox.Show("Không thể sửa!");

            dgvKhoa.DataSource = controller.LayDanhSach();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (controller.Xoa(txtMaKhoa.Text.Trim()))
                MessageBox.Show("Đã xóa!");
            else
                MessageBox.Show("Xóa thất bại!");

            dgvKhoa.DataSource = controller.LayDanhSach();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = controller.TimKiem(txtTimKiem.Text.Trim());
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = controller.LayDanhSach();
            timerGradient = new System.Windows.Forms.Timer();
            timerGradient.Interval = 20; // Càng nhỏ càng mượt (ms)
            timerGradient.Tick += (s, ev) =>
            {
                gradientAngle += 1.5f;
                if (gradientAngle >= 360f) gradientAngle = 0f;
                this.Invalidate(); // Gọi lại OnPaintBackground
            };
            timerGradient.Start();
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhoa.Rows[e.RowIndex];
                txtMaKhoa.Text = row.Cells["MaKhoa"].Value.ToString();
                txtTenKhoa.Text = row.Cells["TenKhoa"].Value.ToString();
            }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(250, 100, 0),  
                Color.FromArgb(110, 220, 255), 

                gradientAngle))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}

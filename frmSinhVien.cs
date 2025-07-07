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
    public partial class frmSinhVien : Form
    {
        SinhVienController controller = new SinhVienController();
        public frmSinhVien()
        {
            InitializeComponent();
        }
        private float gradientAngle = 1.5f;
        private System.Windows.Forms.Timer timerGradient;
        private Color[] gradientColors = {
        Color.MediumSlateBlue,
        Color.DeepPink,
        Color.Orange,
        Color.SpringGreen,
        Color.Cyan,
        Color.MediumPurple
};

        private void them_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien
            {
                MaSV = txtMaSV.Text,
                HoTen = txtHoTen.Text,
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cboGioiTinh.Text,
                QueQuan = txtQueQuan.Text,
                CheDoUuTien = txtCheDoUuTien.Text
            };

            if (controller.Them(sv))
                MessageBox.Show("Đã thêm!");
            else
                MessageBox.Show("Thêm thất bại!");

            dgvSinhVien.DataSource = controller.LayDanhSach();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            

            dgvSinhVien.DataSource = controller.LayDanhSach();
            cboGioiTinh.Items.AddRange(new string[] { "F", "M" });
            cboGioiTinh.SelectedIndex = 0;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            timerGradient = new System.Windows.Forms.Timer();
            timerGradient.Interval = 10; // tốc độ làm mới (ms)
            timerGradient.Tick += (s, ev) =>
            {
                gradientAngle += 2f;
                if (gradientAngle >= 360f) gradientAngle = 0f;
                this.Invalidate(); // yêu cầu vẽ lại
            };
            timerGradient.Start();

        }

        private void sua_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien
            {
                MaSV = txtMaSV.Text,
                HoTen = txtHoTen.Text,
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cboGioiTinh.Text,
                QueQuan = txtQueQuan.Text,
                CheDoUuTien = txtCheDoUuTien.Text
            };

            if (controller.Sua(sv))
                MessageBox.Show("Đã sửa!");
            else
                MessageBox.Show("Sửa thất bại!");

            dgvSinhVien.DataSource = controller.LayDanhSach();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text;

            if (controller.Xoa(ma))
                MessageBox.Show("Đã xóa!");
            else
                MessageBox.Show("Xóa thất bại!");

            dgvSinhVien.DataSource = controller.LayDanhSach();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim();
            dgvSinhVien.DataSource = controller.TimKiem(tuKhoa);
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                txtMaSV.Text = row.Cells["MaSV"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                cboGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtQueQuan.Text = row.Cells["QueQuan"].Value.ToString();
                txtCheDoUuTien.Text = row.Cells["CheDoUuTien"].Value.ToString();

            }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            Rectangle rect = this.ClientRectangle;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(255, 90, 90),
                Color.FromArgb(255, 160, 0),

                gradientAngle))                  // Góc động
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillRectangle(brush, rect);
            }
        }


    }
}

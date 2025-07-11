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
    public partial class frmLopHocPhan : Form
    {
        LopHocPhanController controller = new LopHocPhanController();
        public frmLopHocPhan()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.Timer timerGradient;
        private float gradientAngle = 0;
        private void dgvLopHocPhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvLopHocPhan.Rows[e.RowIndex];
                txtMaLHP.Text = row.Cells["MaLHP"].Value.ToString();
                txtTenLHP.Text = row.Cells["TenLHP"].Value.ToString();
                cboMaHP.SelectedValue = row.Cells["MaHP"].Value.ToString();
                cboMaGV.SelectedValue = row.Cells["MaGV"].Value.ToString();
            }
        }

        private void frmLopHocPhan_Load(object sender, EventArgs e)
        {
            // Load combo học phần
            HocPhanController hocPhanController = new HocPhanController();
            cboMaHP.DataSource = hocPhanController.LayDanhSach();
            cboMaHP.DisplayMember = "MaHP";
            cboMaHP.ValueMember = "MaHP";
            cboMaHP.SelectedIndex = -1;

            // Load combo giảng viên
            GiangVienController gvController = new GiangVienController();
            cboMaGV.DataSource = gvController.LayDanhSach();
            cboMaGV.DisplayMember = "MaGV";
            cboMaGV.ValueMember = "MaGV";
            cboMaGV.SelectedIndex = -1;

            // Load danh sách lớp học phần
            dgvLopHocPhan.DataSource = controller.LayDanhSach();
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
        private LopHocPhan TaoLHP()
        {
            return new LopHocPhan
            {
                MaLHP = txtMaLHP.Text.Trim(),
                TenLHP = txtTenLHP.Text.Trim(),
                MaHP = cboMaHP.SelectedValue?.ToString(),
                MaGV = cboMaGV.SelectedValue?.ToString()
            };
        }

        private void them_Click(object sender, EventArgs e)
        {
            LopHocPhan lhp = TaoLHP();

            if (controller.Them(lhp))
                MessageBox.Show("Đã thêm lớp học phần!");
            else
                MessageBox.Show("Thêm thất bại!");

            dgvLopHocPhan.DataSource = controller.LayDanhSach();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            LopHocPhan lhp = TaoLHP();

            if (controller.Sua(lhp))
                MessageBox.Show("Đã cập nhật lớp học phần!");
            else
                MessageBox.Show("Cập nhật thất bại!");

            dgvLopHocPhan.DataSource = controller.LayDanhSach();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaLHP.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Vui lòng chọn lớp cần xóa!");
                return;
            }

            if (controller.Xoa(ma))
                MessageBox.Show("Đã xóa lớp học phần!");
            else
                MessageBox.Show("Xóa thất bại!");

            dgvLopHocPhan.DataSource = controller.LayDanhSach();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            dgvLopHocPhan.DataSource = string.IsNullOrEmpty(tuKhoa)
                ? controller.LayDanhSach()
                : controller.TimKiem(tuKhoa);
        }

        private void frmLopHocPhan_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có click trúng control nào không
            var clickedControl = this.GetChildAtPoint(this.PointToClient(Cursor.Position));
            if (clickedControl == null)
            {
                // Nếu click nền trắng → xóa ô nhập liệu
                txtMaLHP.Clear();
                txtTenLHP.Clear();
                txtTimKiem.Clear();
                if (cboMaHP.Items.Count > 0) cboMaHP.SelectedIndex = -1;
                if (cboMaGV.Items.Count > 0) cboMaGV.SelectedIndex = -1;
            }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(70, 130, 255),
                Color.FromArgb(255, 90, 90),
                gradientAngle))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}

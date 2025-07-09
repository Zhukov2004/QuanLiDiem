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
    public partial class frmHocLai : Form
    {
        HocLaiController controller = new HocLaiController();
        private HocLai TaoHocLai()
        {
            int lan = int.TryParse(txtLanHoc.Text, out int val) ? val : 1;

            return new HocLai
            {
                MaSV = cboMaSV.SelectedValue.ToString(),
                MaLHP = cboMaLHP.SelectedValue.ToString(),
                LyDo = txtLyDo.Text.Trim(),
                LanHoc = lan,
                NgayDangKy = dtpNgayDK.Value
            };
        }
        private System.Windows.Forms.Timer timerGradient;
        private float gradientAngle = 0;
        public frmHocLai()
        {
            InitializeComponent();
        }

        private void dgvHocLai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
    {
                var row = dgvHocLai.Rows[e.RowIndex];
                cboMaSV.SelectedValue = row.Cells["MaSV"].Value.ToString();
                cboMaLHP.SelectedValue = row.Cells["MaLHP"].Value.ToString();
                txtLyDo.Text = row.Cells["LyDo"].Value.ToString();
                txtLanHoc.Text = row.Cells["LanHoc"].Value.ToString();
                dtpNgayDK.Value = Convert.ToDateTime(row.Cells["NgayDangKy"].Value);
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            var hl = TaoHocLai();
            if (controller.Them(hl))
                MessageBox.Show("Đã thêm học lại!");
            else
                MessageBox.Show("Thêm thất bại!");
            dgvHocLai.DataSource = controller.LayDanhSach();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            var hl = TaoHocLai();
            if (controller.Sua(hl))
                MessageBox.Show("Đã cập nhật!");
            else
                MessageBox.Show("Cập nhật thất bại!");
            dgvHocLai.DataSource = controller.LayDanhSach();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (controller.Xoa(cboMaSV.SelectedValue.ToString(), cboMaLHP.SelectedValue.ToString()))
                MessageBox.Show("Đã xóa!");
            else
                MessageBox.Show("Xóa thất bại!");
            dgvHocLai.DataSource = controller.LayDanhSach();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text.Trim();
            dgvHocLai.DataSource = string.IsNullOrWhiteSpace(kw)
                ? controller.LayDanhSach()
                : controller.TimKiem(kw);
        }

        private void frmHocLai_Load(object sender, EventArgs e)
        {
            cboMaSV.DataSource = new SinhVienController().LayDanhSach();
            cboMaSV.DisplayMember = "MaSV";
            cboMaSV.ValueMember = "MaSV";

            cboMaLHP.DataSource = new LopHocPhanController().LayDanhSach();
            cboMaLHP.DisplayMember = "MaLHP";
            cboMaLHP.ValueMember = "MaLHP";
            cboMaSV.SelectedIndex = -1;
            cboMaLHP.SelectedIndex = -1;
            dgvHocLai.DataSource = controller.LayDanhSach();
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

        private void frmHocLai_Click(object sender, EventArgs e)
        {
            Control clicked = this.GetChildAtPoint(this.PointToClient(Cursor.Position));
            if (clicked == null)
            {
                if (cboMaSV.Items.Count > 0) cboMaSV.SelectedIndex = -1;
                if (cboMaLHP.Items.Count > 0) cboMaLHP.SelectedIndex = -1;
                txtLyDo.Clear();
                txtLanHoc.Clear();
                dtpNgayDK.Value = DateTime.Now;
                txtTimKiem.Clear();
            }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(255, 0, 150), // Neon Magenta
                Color.FromArgb(0, 255, 255),  // Laser Cyan
                gradientAngle))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}

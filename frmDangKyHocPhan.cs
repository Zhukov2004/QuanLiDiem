using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiDiemDaiHoc.Controllers;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc
{
    public partial class frmDangKyHocPhan : Form
    {
        DangKyHocPhanController controller = new DangKyHocPhanController();
        private DangKyHocPhan TaoDangKy()
        {
            return new DangKyHocPhan
            {
                MaSV = cboMaSV.SelectedValue?.ToString(),
                MaLHP = cboMaLHP.SelectedValue?.ToString(),
                HocKy = txtHocKy.Text.Trim(),
                NamHoc = txtNamHoc.Text.Trim()
            };
        }

        public frmDangKyHocPhan()
        {
            InitializeComponent();
        }

        private void frmDangKyHocPhan_Load(object sender, EventArgs e)
        {
            // Load sinh viên
            SinhVienController svCtrl = new SinhVienController();
            cboMaSV.DataSource = svCtrl.LayDanhSach();
            cboMaSV.DisplayMember = "MaSV";
            cboMaSV.ValueMember = "MaSV";
            cboMaSV.SelectedIndex = -1;

            // Load lớp học phần
            LopHocPhanController lhpCtrl = new LopHocPhanController();
            cboMaLHP.DataSource = lhpCtrl.LayDanhSach();
            cboMaLHP.DisplayMember = "MaLHP";
            cboMaLHP.ValueMember = "MaLHP";
            cboMaLHP.SelectedIndex = -1;

            // Load danh sách đăng ký
            dgvDangKy.DataSource = controller.LayDanhSach();
        }

        private void frmDangKyHocPhan_Click(object sender, EventArgs e)
        {
            Control clicked = this.GetChildAtPoint(this.PointToClient(Cursor.Position));
            if (clicked == null)
            {
                txtHocKy.Clear();
                txtNamHoc.Clear();
                if (cboMaSV.Items.Count > 0) cboMaSV.SelectedIndex = 0;
                if (cboMaLHP.Items.Count > 0) cboMaLHP.SelectedIndex = 0;
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            var dk = TaoDangKy();

            if (string.IsNullOrWhiteSpace(dk.MaSV) ||
                string.IsNullOrWhiteSpace(dk.MaLHP) ||
                string.IsNullOrWhiteSpace(dk.HocKy) ||
                string.IsNullOrWhiteSpace(dk.NamHoc))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (controller.DangKy(dk))
                MessageBox.Show("Đăng ký thành công!");
            else
                MessageBox.Show("Đăng ký thất bại (có thể đã tồn tại)!");

            dgvDangKy.DataSource = controller.LayDanhSach();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            var dk = TaoDangKy();

            if (controller.Huy(dk.MaSV, dk.MaLHP))
            {
                if (controller.DangKy(dk))
                    MessageBox.Show("Đã cập nhật đăng ký!");
                else
                    MessageBox.Show("Cập nhật thất bại khi thêm lại!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy đăng ký để sửa!");
            }

            dgvDangKy.DataSource = controller.LayDanhSach();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string maSV = cboMaSV.SelectedValue?.ToString();
            string maLHP = cboMaLHP.SelectedValue?.ToString();

            if (controller.Huy(maSV, maLHP))
                MessageBox.Show("Đã hủy đăng ký!");
            else
                MessageBox.Show("Hủy thất bại!");

            dgvDangKy.DataSource = controller.LayDanhSach();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string maSV = cboMaSV.SelectedValue?.ToString();
            dgvDangKy.DataSource = controller.TimTheoSinhVien(maSV);
        }

        private void dgvDangKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDangKy.Rows[e.RowIndex];
                cboMaSV.SelectedValue = row.Cells["MaSV"].Value.ToString();
                cboMaLHP.SelectedValue = row.Cells["MaLHP"].Value.ToString();
                txtHocKy.Text = row.Cells["HocKy"].Value.ToString();
                txtNamHoc.Text = row.Cells["NamHoc"].Value.ToString();
            }
        }
    }
}

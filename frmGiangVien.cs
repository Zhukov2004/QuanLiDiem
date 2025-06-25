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
    public partial class frmGiangVien : Form
    {
        GiangVienController controller = new GiangVienController();
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void them_Click(object sender, EventArgs e)
        {
            var gv = new GiangVien
            {
                MaGV = txtMaGV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cboGioiTinh.Text,
                BoMon = txtBoMon.Text.Trim(),
                TrinhDo = txtTrinhDo.Text.Trim()
            };

            if (controller.Them(gv))
                MessageBox.Show("Đã thêm giảng viên!");
            else
                MessageBox.Show("Thêm thất bại!");

            dgvGiangVien.DataSource = controller.LayDanhSach();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            var gv = new GiangVien
            {
                MaGV = txtMaGV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cboGioiTinh.Text,
                BoMon = txtBoMon.Text.Trim(),
                TrinhDo = txtTrinhDo.Text.Trim()
            };

            if (controller.Sua(gv))
                MessageBox.Show("Đã cập nhật!");
            else
                MessageBox.Show("Cập nhật thất bại!");

            dgvGiangVien.DataSource = controller.LayDanhSach();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string maGV = txtMaGV.Text.Trim();
            if (string.IsNullOrEmpty(maGV))
            {
                MessageBox.Show("Vui lòng chọn giảng viên để xóa!");
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                if (controller.Xoa(maGV))
                    MessageBox.Show("Đã xóa!");
                else
                    MessageBox.Show("Xóa thất bại!");

                dgvGiangVien.DataSource = controller.LayDanhSach();
            }
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(tuKhoa))
                dgvGiangVien.DataSource = controller.TimKiem(tuKhoa);
            else
                dgvGiangVien.DataSource = controller.LayDanhSach();
        }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvGiangVien.Rows[e.RowIndex];
                txtMaGV.Text = row.Cells["MaGV"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                cboGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtBoMon.Text = row.Cells["BoMon"].Value.ToString();
                txtTrinhDo.Text = row.Cells["TrinhDo"].Value.ToString();
            }
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            cboGioiTinh.SelectedIndex = 0;
            dgvGiangVien.DataSource = controller.LayDanhSach();
        }
    }
}

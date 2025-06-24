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
    public partial class frmSinhVien : Form
    {
        SinhVienController controller = new SinhVienController();
        public frmSinhVien()
        {
            InitializeComponent();
        }

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
    }
}

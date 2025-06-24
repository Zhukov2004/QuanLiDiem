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
    public partial class frmLop : Form
    {
        LopController controller = new LopController();
        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            dgvLop.DataSource = controller.LayDanhSach();
        }

        private void them_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop
            {
                MaLop = txtMaLop.Text,
                TenLop = txtTenLop.Text,
                CoVanHocTap = txtCoVan.Text
            };

            if (controller.Them(lop))
                MessageBox.Show("Đã thêm lớp!");
            else
                MessageBox.Show("Không thể thêm lớp!");

            dgvLop.DataSource = controller.LayDanhSach();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop
            {
                MaLop = txtMaLop.Text,
                TenLop = txtTenLop.Text,
                CoVanHocTap = txtCoVan.Text
            };

            if (controller.Sua(lop))
                MessageBox.Show("Đã cập nhật!");
            else
                MessageBox.Show("Không thể cập nhật!");

            dgvLop.DataSource = controller.LayDanhSach();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (controller.Xoa(txtMaLop.Text))
                MessageBox.Show("Đã xóa lớp!");
            else
                MessageBox.Show("Không thể xóa lớp!");

            dgvLop.DataSource = controller.LayDanhSach();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(tuKhoa))
                dgvLop.DataSource = controller.TimKiem(tuKhoa);
            else
                dgvLop.DataSource = controller.LayDanhSach();
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvLop.Rows[e.RowIndex];
                txtMaLop.Text = row.Cells["MaLop"].Value.ToString();
                txtTenLop.Text = row.Cells["TenLop"].Value.ToString();
                txtCoVan.Text = row.Cells["CoVanHocTap"].Value.ToString();
            }
        }
    }
}

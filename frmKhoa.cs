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
    public partial class frmKhoa : Form
    {
        KhoaController controller = new KhoaController();
        public frmKhoa()
        {
            InitializeComponent();
        }

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
    }
}

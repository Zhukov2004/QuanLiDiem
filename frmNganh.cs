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
    public partial class frmNganh : Form
    {
        NganhController controller = new NganhController();
        public frmNganh()
        {
            InitializeComponent();
        }

        private void them_Click(object sender, EventArgs e)
        {
            var ng = new Nganh
            {
                MaNganh = txtMaNganh.Text.Trim(),
                TenNganh = txtTenNganh.Text.Trim()
            };

            if (controller.Them(ng))
                MessageBox.Show("Thêm ngành thành công!");
            else
                MessageBox.Show("Thêm thất bại!");

            dgvNganh.DataSource = controller.LayDanhSach();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            var ng = new Nganh
            {
                MaNganh = txtMaNganh.Text.Trim(),
                TenNganh = txtTenNganh.Text.Trim()
            };

            if (controller.Sua(ng))
                MessageBox.Show("Đã cập nhật!");
            else
                MessageBox.Show("Không thể sửa!");

            dgvNganh.DataSource = controller.LayDanhSach();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (controller.Xoa(txtMaNganh.Text.Trim()))
                MessageBox.Show("Đã xóa ngành!");
            else
                MessageBox.Show("Không thể xóa!");

            dgvNganh.DataSource = controller.LayDanhSach();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            dgvNganh.DataSource = controller.TimKiem(txtTimKiem.Text.Trim());
        }

        private void frmNganh_Load(object sender, EventArgs e)
        {
            dgvNganh.DataSource = controller.LayDanhSach();
        }

        private void dgvNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvNganh.Rows[e.RowIndex];
                txtMaNganh.Text = row.Cells["MaNganh"].Value.ToString();
                txtTenNganh.Text = row.Cells["TenNganh"].Value.ToString();
            }
        }
    }
}

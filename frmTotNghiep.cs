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
    public partial class frmTotNghiep : Form
    {
        private TotNghiepController controller = new TotNghiepController();

        public frmTotNghiep()
        {
            InitializeComponent();
        }
        private TotNghiep TaoTotNghiep()
        {
            return new TotNghiep
            {
                MaSV = cboMaSV.SelectedValue.ToString(),
                NgayTotNghiep = dtpNgayTN.Value,
                XepLoai = txtXepLoai.Text.Trim()
            };
        }

        private void frmTotNghiep_Load(object sender, EventArgs e)
        {
            cboMaSV.DataSource = new SinhVienController().LayDanhSach();
            cboMaSV.DisplayMember = "MaSV";
            cboMaSV.ValueMember = "MaSV";
            dgvTotNghiep.DataSource = controller.LayDanhSach();
            cboMaSV.SelectedIndex = -1;
            txtHoTen.Clear();
            txtXepLoai.Clear();
            txtTimKiem.Clear();
            dtpNgayTN.Value = DateTime.Now;
        }

        private void frmTotNghiep_Click(object sender, EventArgs e)
        {
            cboMaSV.SelectedIndex = -1;
            txtHoTen.Clear();
            txtXepLoai.Clear();
            txtTimKiem.Clear();
            dtpNgayTN.Value = DateTime.Now;

            dgvTotNghiep.ClearSelection(); // bỏ chọn bảng nếu có
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (controller.Them(TaoTotNghiep()))
                MessageBox.Show("Đã thêm!");
            dgvTotNghiep.DataSource = controller.LayDanhSach();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (controller.Sua(TaoTotNghiep()))
                MessageBox.Show("Đã cập nhật!");
            dgvTotNghiep.DataSource = controller.LayDanhSach();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string ma = cboMaSV.SelectedValue.ToString();
            if (controller.Xoa(ma))
                MessageBox.Show("Đã xóa!");
            dgvTotNghiep.DataSource = controller.LayDanhSach();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text.Trim();
            dgvTotNghiep.DataSource = string.IsNullOrWhiteSpace(kw)
                ? controller.LayDanhSach()
                : controller.TimKiem(kw);
        }

        private void dgvTotNghiep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvTotNghiep.Rows[e.RowIndex];
                cboMaSV.SelectedValue = row.Cells["MaSV"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                dtpNgayTN.Value = Convert.ToDateTime(row.Cells["NgayTotNghiep"].Value);
                txtXepLoai.Text = row.Cells["XepLoai"].Value.ToString();
            }
        }

        private void cboMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSV = cboMaSV.SelectedValue?.ToString();
            var sv = new SinhVienController().TimKiem(maSV).FirstOrDefault();
            txtHoTen.Text = sv != null ? sv.HoTen : "";
        }
    }
}

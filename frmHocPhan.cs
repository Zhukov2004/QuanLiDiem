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
    public partial class frmHocPhan : Form
    {
        HocPhanController controller = new HocPhanController();
        public frmHocPhan()
        {
            InitializeComponent();
        }
        private HocPhan TaoHocPhanTuForm()
        {
            return new HocPhan
            {
                MaHP = txtMaHP.Text.Trim(),
                TenHP = txtTenHP.Text.Trim(),
                SoTinChi = int.Parse(txtSoTinChi.Text),
                HocKy = int.Parse(txtHocKy.Text),
                MaNganh = cboMaNganh.SelectedValue?.ToString()
            };
        }

        private void frmHocPhan_Load(object sender, EventArgs e)
        {
            NganhController controllerNganh = new NganhController();
            cboMaNganh.DataSource = controllerNganh.LayDanhSach();
            cboMaNganh.DisplayMember = "TenNganh";
            cboMaNganh.ValueMember = "MaNganh";
            dgvHocPhan.DataSource = controller.LayDanhSach();
        }

        private void dgvHocPhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvHocPhan.Rows[e.RowIndex];
                txtMaHP.Text = row.Cells["MaHP"].Value.ToString();
                txtTenHP.Text = row.Cells["TenHP"].Value.ToString();
                txtSoTinChi.Text = row.Cells["SoTinChi"].Value.ToString();
                txtHocKy.Text = row.Cells["HocKy"].Value.ToString();
                cboMaNganh.SelectedValue = row.Cells["MaNganh"].Value.ToString();
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            HocPhan hp = TaoHocPhanTuForm();

            if (controller.Them(hp))
                MessageBox.Show("Đã thêm học phần!");
            else
                MessageBox.Show("Thêm thất bại!");

            dgvHocPhan.DataSource = controller.LayDanhSach();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            HocPhan hp = TaoHocPhanTuForm();

            if (controller.Sua(hp))
                MessageBox.Show("Đã cập nhật học phần!");
            else
                MessageBox.Show("Cập nhật thất bại!");

            dgvHocPhan.DataSource = controller.LayDanhSach();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaHP.Text.Trim();

            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Vui lòng chọn học phần để xóa!");
                return;
            }

            if (controller.Xoa(ma))
                MessageBox.Show("Đã xóa!");
            else
                MessageBox.Show("Xóa thất bại!");

            dgvHocPhan.DataSource = controller.LayDanhSach();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text.Trim();
            dgvHocPhan.DataSource = string.IsNullOrEmpty(kw)
                ? controller.LayDanhSach()
                : controller.TimKiem(kw);
        }

        private void frmHocPhan_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu click vào vùng nền trắng (không phải control nào)
            Control ctl = this.GetChildAtPoint(this.PointToClient(Cursor.Position));
            if (ctl == null)
            {
                txtMaHP.Clear();
                txtTenHP.Clear();
                txtSoTinChi.Clear();
                txtHocKy.Clear();
                txtTimKiem.Clear();

                if (cboMaNganh.Items.Count > 0)
                    cboMaNganh.SelectedIndex = -1;
            }
        }
    }
}

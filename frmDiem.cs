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
    public partial class frmDiem : Form
    {
        DiemController controller = new DiemController();

        public frmDiem()
        {
            InitializeComponent();
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            cboMaSV.DataSource = new SinhVienController().LayDanhSach();
            cboMaSV.DisplayMember = "MaSV";
            cboMaSV.ValueMember = "MaSV";

            cboMaLHP.DataSource = new LopHocPhanController().LayDanhSach();
            cboMaLHP.DisplayMember = "MaLHP";
            cboMaLHP.ValueMember = "MaLHP";

            dgvDiem.DataSource = controller.LayDanhSach();
        }
        private string TinhXepLoai(decimal tb)
        {
            if (tb >= 3.6m) return "Xuất sắc";
            else if (tb >= 3.2m) return "Giỏi";
            else if (tb >= 2.5m) return "Khá";
            else if (tb >= 2.0m) return "Trung bình";
            return "Yếu";
        }

        private void frmDiem_Click(object sender, EventArgs e)
        {
            Control clicked = this.GetChildAtPoint(this.PointToClient(Cursor.Position));
            if (clicked == null)
            {
                cboMaSV.SelectedIndex = -1;
                cboMaLHP.SelectedIndex = -1;
                txtDiemThi.Clear();
                txtDiemTBHK.Clear();
                txtXepLoai.Clear();
                chkHocBong.Checked = false;
                txtTimKiem.Clear();
            }
        }

        private void dgvDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var r = dgvDiem.Rows[e.RowIndex];
                cboMaSV.SelectedValue = r.Cells["MaSV"].Value.ToString();
                cboMaLHP.SelectedValue = r.Cells["MaLHP"].Value.ToString();
                txtDiemThi.Text = r.Cells["DiemThi"].Value.ToString();
                txtDiemTBHK.Text = r.Cells["DiemTBHK"].Value.ToString();
                txtXepLoai.Text = r.Cells["XepLoai"].Value.ToString();
                chkHocBong.Checked = Convert.ToBoolean(r.Cells["DuocXetHocBong"].Value);
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDiemTBHK.Text, out decimal tb)) tb = 0;
            txtXepLoai.Text = TinhXepLoai(tb);

            var d = new Diem
            {
                MaSV = cboMaSV.SelectedValue.ToString(),
                MaLHP = cboMaLHP.SelectedValue.ToString(),
                DiemThi = decimal.Parse(txtDiemThi.Text),
                DiemTBHK = tb,
                XepLoai = txtXepLoai.Text,
                DuocXetHocBong = chkHocBong.Checked
            };

            if (controller.Them(d))
                MessageBox.Show("Đã thêm điểm!");
            else
                MessageBox.Show("Thêm thất bại!");

            dgvDiem.DataSource = controller.LayDanhSach();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            txtXepLoai.Text = TinhXepLoai(decimal.Parse(txtDiemTBHK.Text));

            var d = new Diem
            {
                MaSV = cboMaSV.SelectedValue.ToString(),
                MaLHP = cboMaLHP.SelectedValue.ToString(),
                DiemThi = decimal.Parse(txtDiemThi.Text),
                DiemTBHK = decimal.Parse(txtDiemTBHK.Text),
                XepLoai = txtXepLoai.Text,
                DuocXetHocBong = chkHocBong.Checked
            };

            if (controller.Sua(d))
                MessageBox.Show("Đã cập nhật!");
            else
                MessageBox.Show("Cập nhật thất bại!");

            dgvDiem.DataSource = controller.LayDanhSach();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string maSV = cboMaSV.SelectedValue.ToString();
            string maLHP = cboMaLHP.SelectedValue.ToString();

            if (controller.Xoa(maSV, maLHP))
                MessageBox.Show("Đã xóa!");
            else
                MessageBox.Show("Xóa thất bại!");

            dgvDiem.DataSource = controller.LayDanhSach();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text.Trim();
            dgvDiem.DataSource = string.IsNullOrWhiteSpace(kw)
                ? controller.LayDanhSach()
                : controller.TimKiem(kw);
        }
    }
}

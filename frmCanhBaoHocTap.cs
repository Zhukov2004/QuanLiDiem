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
    public partial class frmCanhBaoHocTap : Form
    {
        private CanhBaoHocTapController controller = new CanhBaoHocTapController();
        public frmCanhBaoHocTap()
        {
            InitializeComponent();
        }

        private void frmCanhBaoHocTap_Load(object sender, EventArgs e)
        {
            List<SinhVien> ds = new SinhVienController().LayDanhSach();
            cboMaSV.DataSource = ds;
            cboMaSV.DisplayMember = "MaSV";
            cboMaSV.ValueMember = "MaSV";
            cboMaSV.SelectedIndex = -1;
            dgvCanhBao.DataSource = controller.LayDanhSach();
        }
        private CanhBaoHocTap TaoCanhBao()
        {
            return new CanhBaoHocTap
            {
                MaSV = cboMaSV.SelectedValue.ToString(),
                NamHoc = txtNamHoc.Text.Trim(),
                HocKy = txtHocKy.Text.Trim(),
                LyDo = txtLyDo.Text.Trim(),
                NgayCanhBao = dtpNgayCB.Value
            };
        }


        private void frmCanhBaoHocTap_Click(object sender, EventArgs e)
        {
            if (cboMaSV.Items.Count > 0) cboMaSV.SelectedIndex = -1;
            txtHoTen.Clear();
            txtNamHoc.Clear();
            txtHocKy.Clear();
            txtLyDo.Clear();
            txtTimKiem.Clear();
            dtpNgayCB.Value = DateTime.Now;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCanhBao.Rows[e.RowIndex];

                cboMaSV.SelectedValue = row.Cells["MaSV"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtNamHoc.Text = row.Cells["NamHoc"].Value.ToString();
                txtHocKy.Text = row.Cells["HocKy"].Value.ToString();
                txtLyDo.Text = row.Cells["LyDo"].Value.ToString();
                dtpNgayCB.Value = Convert.ToDateTime(row.Cells["NgayCanhBao"].Value);
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (controller.Them(TaoCanhBao()))
                MessageBox.Show("Đã thêm cảnh báo!");
            else
                MessageBox.Show("Thêm thất bại!");
            dgvCanhBao.DataSource = controller.LayDanhSach();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (controller.Sua(TaoCanhBao()))
                MessageBox.Show("Đã cập nhật!");
            else
                MessageBox.Show("Cập nhật thất bại!");
            dgvCanhBao.DataSource = controller.LayDanhSach();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string maSV = cboMaSV.SelectedValue.ToString();
            string namHoc = txtNamHoc.Text.Trim();
            string hocKy = txtHocKy.Text.Trim();

            var result = MessageBox.Show(
                $"Bạn có chắc muốn xóa cảnh báo học tập của sinh viên {maSV} - học kỳ {hocKy}, năm học {namHoc}?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool thanhCong = controller.Xoa(maSV, namHoc, hocKy);
                if (thanhCong)
                {
                    MessageBox.Show("Đã xóa thành công!");
                    dgvCanhBao.DataSource = controller.LayDanhSach();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text.Trim();
            dgvCanhBao.DataSource = string.IsNullOrWhiteSpace(kw)
                ? controller.LayDanhSach()
                : controller.TimKiem(kw);
        }

        private void cboMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSV = cboMaSV.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(maSV))
            {
                // Gọi TimKiem với từ khóa chính là MaSV
                List<SinhVien> kq = new SinhVienController().TimKiem(maSV);
                if (kq.Count > 0)
                {
                    txtHoTen.Text = kq[0].HoTen;
                }
                else
                {
                    txtHoTen.Text = "(Không tìm thấy)";
                }
            }
        }
    }
}

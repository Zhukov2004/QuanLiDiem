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
using ClosedXML.Excel;


namespace QuanLiDiemDaiHoc
{
    public partial class frmXuatDuLieu : Form
    {
        public frmXuatDuLieu()
        {
            InitializeComponent();
        }

        private void dgvDuLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboLoaiDuLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loai = cboLoaiDuLieu.SelectedItem?.ToString();

            switch (loai)
            {
                case "Sinh viên":
                    dgvDuLieu.DataSource = new SinhVienController().LayDanhSach();
                    break;
                case "Học phần":
                    dgvDuLieu.DataSource = new HocPhanController().LayDanhSach();
                    break;
                case "Cảnh báo học tập":
                    dgvDuLieu.DataSource = new CanhBaoHocTapController().LayDanhSach();
                    break;
                case "Tốt nghiệp":
                    dgvDuLieu.DataSource = new TotNghiepController().LayDanhSach();
                    break;
                case "Đăng ký học phần":
                    dgvDuLieu.DataSource = new DangKyController().LayThongTinSinhVienHocPhan();
                    break;
            }
        }

        private void excel_Click(object sender, EventArgs e)
        {
            if (dgvDuLieu.DataSource == null)
            {
                MessageBox.Show("Chưa có dữ liệu.");
                return;
            }

            var dialog = new SaveFileDialog
            {
                Filter = "Excel file (*.xlsx)|*.xlsx",
                FileName = "XuatDuLieu_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Tạo DataTable thủ công từ DataGridView
                var dt = new DataTable();

                foreach (DataGridViewColumn column in dgvDuLieu.Columns)
                {
                    dt.Columns.Add(column.HeaderText);
                }

                foreach (DataGridViewRow row in dgvDuLieu.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var values = new object[dgvDuLieu.Columns.Count];
                        for (int i = 0; i < dgvDuLieu.Columns.Count; i++)
                        {
                            values[i] = row.Cells[i].Value;
                        }
                        dt.Rows.Add(values);
                    }
                }

                var wb = new ClosedXML.Excel.XLWorkbook();
                wb.Worksheets.Add(dt, "DuLieu");
                wb.SaveAs(dialog.FileName);
                MessageBox.Show("Đã xuất ra Excel thành công!");
            }
        }

        private void pdf_Click(object sender, EventArgs e)
        {

        }
    }
}

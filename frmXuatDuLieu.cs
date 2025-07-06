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
using System.IO;
using System.Drawing.Drawing2D;
namespace QuanLiDiemDaiHoc
{
    public partial class frmXuatDuLieu : Form
    {

        public frmXuatDuLieu()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.Timer timerGradient;
        private float gradientAngle = 0;

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
            if (dgvDuLieu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.");
                return;
            }

            var dialog = new SaveFileDialog
            {
                Filter = "Excel file (*.xlsx)|*.xlsx",
                FileName = "BaoCao_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var wb = new XLWorkbook();
                    var ws = wb.Worksheets.Add("Báo cáo");

                    // Font chung
                    ws.Style.Font.FontName = "Times New Roman";
                    ws.Style.Font.FontSize = 12;

                    int colCount = dgvDuLieu.Columns.Count;

                    // === 1. Tiêu ngữ hai bên (tên trường bên trái, khoa bên phải) ===
                    ws.Cell(1, 1).Value = "TRƯỜNG ĐẠI HỌC KINH TẾ KĨ THUẬT CÔNG NGHIỆP";
                    ws.Cell(1, colCount).Value = "KHOA CÔNG NGHỆ THÔNG TIN";

                    ws.Cell(1, 1).Style
                        .Font.SetBold()
                        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);

                    ws.Cell(1, colCount).Style
                        .Font.SetBold()
                        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Right);

                    // === 2. Dòng CỘNG HÒA XHCN VIỆT NAM căn giữa ===
                    ws.Cell(2, 1).Value = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
                    ws.Range(2, 1, 2, colCount).Merge().Style
                        .Font.SetBold()
                        .Font.SetFontSize(13)
                        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                    ws.Cell(3, 1).Value = "Độc lập – Tự do – Hạnh phúc";
                    ws.Range(3, 1, 3, colCount).Merge().Style
                        .Font.SetItalic()
                        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                    // === 3. Tiêu đề chính ===
                    ws.Cell(5, 1).Value = "DANH SÁCH DỮ LIỆU BÁO CÁO";
                    ws.Range(5, 1, 5, colCount).Merge().Style
                        .Font.SetBold()
                        .Font.SetFontSize(14)
                        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                        .Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                    // === 4. Ghi tên cột ===
                    for (int i = 0; i < colCount; i++)
                    {
                        ws.Cell(7, i + 1).Value = dgvDuLieu.Columns[i].HeaderText;
                        ws.Cell(7, i + 1).Style
                            .Font.SetBold()
                            .Fill.SetBackgroundColor(XLColor.LightGray)
                            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                            .Border.OutsideBorder = XLBorderStyleValues.Thin;
                    }

                    // === 5. Ghi từng dòng dữ liệu ===
                    for (int r = 0; r < dgvDuLieu.Rows.Count; r++)
                    {
                        for (int c = 0; c < colCount; c++)
                        {
                            var value = dgvDuLieu.Rows[r].Cells[c].Value?.ToString() ?? "";
                            ws.Cell(r + 8, c + 1).Value = value;
                            ws.Cell(r + 8, c + 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        }
                    }

                    // === 6. Dòng ngày lập và người ký ===
                    int footerRow = dgvDuLieu.Rows.Count + 9;
                    ws.Cell(footerRow, colCount - 1).Value = "Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy");
                    ws.Cell(footerRow + 1, colCount - 1).Value = "Người lập biểu";
                    ws.Cell(footerRow + 1, colCount - 1).Style.Font.Italic = true;

                    ws.Columns().AdjustToContents();
                    wb.SaveAs(dialog.FileName);
                    MessageBox.Show("Xuất Excel thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message);
                }
            }
        }

        private void pdf_Click(object sender, EventArgs e)
        {

        }

        private void pdf_Click_1(object sender, EventArgs e)
        {

        }

        private void frmXuatDuLieu_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            timerGradient = new System.Windows.Forms.Timer();
            timerGradient.Interval = 10; // tốc độ làm mới (ms)
            timerGradient.Tick += (s, ev) =>
            {
                gradientAngle += 2f;
                if (gradientAngle >= 360f) gradientAngle = 0f;
                this.Invalidate(); // yêu cầu vẽ lại
            };
            timerGradient.Start();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            Rectangle rect = this.ClientRectangle;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(255, 90, 90), 
                Color.FromArgb(255, 160, 0),  

                gradientAngle))                  // Góc động
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillRectangle(brush, rect);
            }
        }

    }
}

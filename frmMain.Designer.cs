namespace QuanLiDiemDaiHoc
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuMain = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuSinhVien = new ToolStripMenuItem();
            mnuLop = new ToolStripMenuItem();
            mnuNganh = new ToolStripMenuItem();
            mnuKhoa = new ToolStripMenuItem();
            mnuGiangVien = new ToolStripMenuItem();
            mnuTaiKhoan = new ToolStripMenuItem();
            mnuHocTap = new ToolStripMenuItem();
            mnuHocPhan = new ToolStripMenuItem();
            mnuLopHocPhan = new ToolStripMenuItem();
            mnuDangKyHocPhan = new ToolStripMenuItem();
            mnuDiem = new ToolStripMenuItem();
            mnuNhapDiem = new ToolStripMenuItem();
            mnuHocLai = new ToolStripMenuItem();
            mnuCanhBao = new ToolStripMenuItem();
            mnuTotNghiep = new ToolStripMenuItem();
            mnuThongKe = new ToolStripMenuItem();
            mnuThongKeTotNghiep = new ToolStripMenuItem();
            mnuXuatBaoCao = new ToolStripMenuItem();
            label1 = new Label();
            menuMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuHocTap, mnuDiem, mnuThongKe });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(800, 24);
            menuMain.TabIndex = 0;
            menuMain.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangXuat, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(69, 20);
            mnuHeThong.Text = "Hệ thông";
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(128, 22);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(128, 22);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuSinhVien, mnuLop, mnuNganh, mnuKhoa, mnuGiangVien, mnuTaiKhoan });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(109, 20);
            mnuQuanLy.Text = "Quản lí thông tin";
            // 
            // mnuSinhVien
            // 
            mnuSinhVien.Name = "mnuSinhVien";
            mnuSinhVien.Size = new Size(130, 22);
            mnuSinhVien.Text = "Sinh viên";
            mnuSinhVien.Click += mnuSinhVien_Click;
            // 
            // mnuLop
            // 
            mnuLop.Name = "mnuLop";
            mnuLop.Size = new Size(130, 22);
            mnuLop.Text = "Lớp";
            mnuLop.Click += mnuLop_Click;
            // 
            // mnuNganh
            // 
            mnuNganh.Name = "mnuNganh";
            mnuNganh.Size = new Size(130, 22);
            mnuNganh.Text = "Ngành";
            mnuNganh.Click += mnuNganh_Click;
            // 
            // mnuKhoa
            // 
            mnuKhoa.Name = "mnuKhoa";
            mnuKhoa.Size = new Size(130, 22);
            mnuKhoa.Text = "Khoa";
            mnuKhoa.Click += mnuKhoa_Click;
            // 
            // mnuGiangVien
            // 
            mnuGiangVien.Name = "mnuGiangVien";
            mnuGiangVien.Size = new Size(130, 22);
            mnuGiangVien.Text = "Giảng viên";
            mnuGiangVien.Click += mnuGiangVien_Click;
            // 
            // mnuTaiKhoan
            // 
            mnuTaiKhoan.Name = "mnuTaiKhoan";
            mnuTaiKhoan.Size = new Size(130, 22);
            mnuTaiKhoan.Text = "Tài khoản";
            mnuTaiKhoan.Click += mnuTaiKhoan_Click;
            // 
            // mnuHocTap
            // 
            mnuHocTap.DropDownItems.AddRange(new ToolStripItem[] { mnuHocPhan, mnuLopHocPhan, mnuDangKyHocPhan });
            mnuHocTap.Name = "mnuHocTap";
            mnuHocTap.Size = new Size(61, 20);
            mnuHocTap.Text = "Học tập";
            // 
            // mnuHocPhan
            // 
            mnuHocPhan.Name = "mnuHocPhan";
            mnuHocPhan.Size = new Size(167, 22);
            mnuHocPhan.Text = "Học phần";
            mnuHocPhan.Click += mnuHocPhan_Click;
            // 
            // mnuLopHocPhan
            // 
            mnuLopHocPhan.Name = "mnuLopHocPhan";
            mnuLopHocPhan.Size = new Size(167, 22);
            mnuLopHocPhan.Text = "Lớp học phần";
            mnuLopHocPhan.Click += mnuLopHocPhan_Click;
            // 
            // mnuDangKyHocPhan
            // 
            mnuDangKyHocPhan.Name = "mnuDangKyHocPhan";
            mnuDangKyHocPhan.Size = new Size(167, 22);
            mnuDangKyHocPhan.Text = "Đăng kí học phần";
            mnuDangKyHocPhan.Click += mnuDangKyHocPhan_Click;
            // 
            // mnuDiem
            // 
            mnuDiem.DropDownItems.AddRange(new ToolStripItem[] { mnuNhapDiem, mnuHocLai, mnuCanhBao, mnuTotNghiep });
            mnuDiem.Name = "mnuDiem";
            mnuDiem.Size = new Size(116, 20);
            mnuDiem.Text = "Điểm số và học vụ";
            // 
            // mnuNhapDiem
            // 
            mnuNhapDiem.Name = "mnuNhapDiem";
            mnuNhapDiem.Size = new Size(180, 22);
            mnuNhapDiem.Text = "Nhập điểm";
            mnuNhapDiem.Click += mnuNhapDiem_Click;
            // 
            // mnuHocLai
            // 
            mnuHocLai.Name = "mnuHocLai";
            mnuHocLai.Size = new Size(180, 22);
            mnuHocLai.Text = "Học lại";
            mnuHocLai.Click += mnuHocLai_Click;
            // 
            // mnuCanhBao
            // 
            mnuCanhBao.Name = "mnuCanhBao";
            mnuCanhBao.Size = new Size(180, 22);
            mnuCanhBao.Text = "Cảnh báo học tập";
            // 
            // mnuTotNghiep
            // 
            mnuTotNghiep.Name = "mnuTotNghiep";
            mnuTotNghiep.Size = new Size(180, 22);
            mnuTotNghiep.Text = "Xét tốt nghiệp";
            // 
            // mnuThongKe
            // 
            mnuThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeTotNghiep, mnuXuatBaoCao });
            mnuThongKe.Name = "mnuThongKe";
            mnuThongKe.Size = new Size(128, 20);
            mnuThongKe.Text = "Thống kê và báo cáo";
            // 
            // mnuThongKeTotNghiep
            // 
            mnuThongKeTotNghiep.Name = "mnuThongKeTotNghiep";
            mnuThongKeTotNghiep.Size = new Size(172, 22);
            mnuThongKeTotNghiep.Text = "Kết quả tốt nghiệp";
            // 
            // mnuXuatBaoCao
            // 
            mnuXuatBaoCao.Name = "mnuXuatBaoCao";
            mnuXuatBaoCao.Size = new Size(172, 22);
            mnuXuatBaoCao.Text = "Xuất PDF/Excel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(638, 24);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuMain);
            MainMenuStrip = menuMain;
            Name = "frmMain";
            Text = "Menu";
            Load += frmMain_Load;
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuMain;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuHocTap;
        private ToolStripMenuItem mnuThongKe;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuSinhVien;
        private ToolStripMenuItem mnuLop;
        private ToolStripMenuItem mnuNganh;
        private ToolStripMenuItem mnuKhoa;
        private ToolStripMenuItem mnuGiangVien;
        private ToolStripMenuItem mnuTaiKhoan;
        private ToolStripMenuItem mnuHocPhan;
        private ToolStripMenuItem mnuLopHocPhan;
        private ToolStripMenuItem mnuDangKyHocPhan;
        private ToolStripMenuItem nhậpĐiểmToolStripMenuItem;
        private ToolStripMenuItem họcLạiToolStripMenuItem;
        private ToolStripMenuItem cảnhCáoHọcTậpToolStripMenuItem;
        private ToolStripMenuItem mnuThongKeTotNghiep;
        private ToolStripMenuItem mnuXuatBaoCao;
        private ToolStripMenuItem mnuDiem;
        private ToolStripMenuItem mnuNhapDiem;
        private ToolStripMenuItem mnuHocLai;
        private ToolStripMenuItem mnuCanhBao;
        private ToolStripMenuItem mnuTotNghiep;
        private Label label1;
    }
}
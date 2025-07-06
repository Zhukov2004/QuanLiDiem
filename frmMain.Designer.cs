using Guna.UI2.WinForms;

namespace QuanLiDiemDaiHoc
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        // Guna2 controls
        private Guna2Panel panelMenu;
        private Guna2ControlBox btnClose;

        // Context menu cho từng nhóm menu
        private ContextMenuStrip ctxHeThong;
        private ContextMenuStrip ctxQuanLy;
        private ContextMenuStrip ctxHocTap;
        private ContextMenuStrip ctxDiem;
        private ContextMenuStrip ctxThongKe;
        // Context menu items cần ẩn/hiện theo quyền
        private ToolStripMenuItem itemGiangVien;
        private ToolStripMenuItem itemTaiKhoan;
        private ToolStripMenuItem itemThongKeTotNghiep;
        private ToolStripMenuItem itemXuatBaoCao;

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
            SuspendLayout();
            // 
            // frmMain
            // 
            ClientSize = new Size(284, 261);
            Name = "frmMain";
            Load += frmMain_Load_1;
            ResumeLayout(false);

        }

        #endregion

        private void InitializeGunaUI()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(950, 600);
            this.BackColor = Color.FromArgb(240, 245, 255);

            new Guna2Elipse { BorderRadius = 20, TargetControl = this };
            new Guna2ShadowForm().SetShadowForm(this);

            // ==== Màu sắc đẹp ====
            Color menuBg = Color.White;
            Color menuHover = Color.FromArgb(230, 240, 255);
            Color menuText = Color.FromArgb(40, 60, 100);

            // ==== Menu hệ thống ====
            ctxHeThong = CreateMenu(menuText, menuBg, menuHover,
                new ToolStripMenuItem("Đăng xuất", null, mnuDangXuat_Click),
                new ToolStripMenuItem("Thoát", null, mnuThoat_Click));

            // ==== Menu quản lý ====
            itemGiangVien = new ToolStripMenuItem("Giảng viên", null, mnuGiangVien_Click);
            itemTaiKhoan = new ToolStripMenuItem("Tài khoản", null, mnuTaiKhoan_Click);
            ctxQuanLy = CreateMenu(menuText, menuBg, menuHover,
                new ToolStripMenuItem("Sinh viên", null, mnuSinhVien_Click),
                new ToolStripMenuItem("Lớp", null, mnuLop_Click),
                new ToolStripMenuItem("Ngành", null, mnuNganh_Click),
                new ToolStripMenuItem("Khoa", null, mnuKhoa_Click),
                itemGiangVien,
                itemTaiKhoan);

            // ==== Menu học tập ====
            ctxHocTap = CreateMenu(menuText, menuBg, menuHover,
                new ToolStripMenuItem("Học phần", null, mnuHocPhan_Click),
                new ToolStripMenuItem("Lớp học phần", null, mnuLopHocPhan_Click),
                new ToolStripMenuItem("Đăng ký học phần", null, mnuDangKyHocPhan_Click));

            // ==== Menu điểm ====
            ctxDiem = CreateMenu(menuText, menuBg, menuHover,
                new ToolStripMenuItem("Nhập điểm", null, mnuNhapDiem_Click),
                new ToolStripMenuItem("Học lại", null, mnuHocLai_Click),
                new ToolStripMenuItem("Cảnh báo học tập", null, mnuCanhBao_Click));

            // ==== Menu thống kê ====
            itemThongKeTotNghiep = new ToolStripMenuItem("Kết quả tốt nghiệp", null, mnuThongKeTotNghiep_Click);
            itemXuatBaoCao = new ToolStripMenuItem("Xuất PDF/Excel", null, mnuXuatBaoCao_Click);
            ctxThongKe = CreateMenu(menuText, menuBg, menuHover,
                itemThongKeTotNghiep,
                itemXuatBaoCao);

            // ==== Thanh menu ngang =====
            panelMenu = new Guna2Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                FillColor = Color.FromArgb(225, 235, 255)
            };
            this.Controls.Add(panelMenu);

            panelMenu.Controls.Add(CreateMenuButton("Hệ thống", 30, ctxHeThong));
            panelMenu.Controls.Add(CreateMenuButton("Quản lý", 150, ctxQuanLy));
            panelMenu.Controls.Add(CreateMenuButton("Học tập", 270, ctxHocTap));
            panelMenu.Controls.Add(CreateMenuButton("Điểm số", 390, ctxDiem));
            panelMenu.Controls.Add(CreateMenuButton("Thống kê", 510, ctxThongKe));

            // ==== Nút đóng form ====
            btnClose = new Guna2ControlBox
            {
                IconColor = Color.FromArgb(60, 80, 130),
                FillColor = Color.Transparent,
                BorderRadius = 6,
                HoverState = { FillColor = Color.FromArgb(255, 180, 180) },
                Location = new Point(this.ClientSize.Width - 45, 10),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            this.Controls.Add(btnClose);
            this.Resize += (s, e) =>
            {
                btnClose.Location = new Point(this.ClientSize.Width - 45, 10);
            };
        }



        private Guna2Button CreateMenuButton(string text, int x, ContextMenuStrip ctx)
        {
            var btn = new Guna2Button
            {
                Text = text,
                Location = new Point(x, 10),
                Size = new Size(110, 40),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                FillColor = Color.White,
                ForeColor = Color.SteelBlue,
                BorderRadius = 10,
                BorderColor = Color.FromArgb(180, 210, 250),
                BorderThickness = 1,
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand,
                HoverState = { FillColor = Color.FromArgb(210, 230, 255) }
            };

            btn.Click += (s, e) =>
            {
                ctx.Show(btn, new Point(0, btn.Height));
            };

            return btn;
        }
        private RoundedContextMenuStrip CreateMenu(Color textColor, Color bgColor, Color hoverColor, params ToolStripMenuItem[] items)
        {
            var ctx = new RoundedContextMenuStrip();
            ctx.ForeColor = textColor;
            ctx.BackColor = bgColor;
            ctx.Renderer = new LightMenuRenderer(hoverColor);
            ctx.ShowImageMargin = false;
            ctx.Items.AddRange(items);
            return ctx;
        }


    }
}

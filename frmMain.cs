﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDiemDaiHoc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private string VaiTro;

        public frmMain(string vaitro)
        {
            InitializeGunaUI();
            VaiTro = vaitro;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (VaiTro == "User")
            {
                itemGiangVien.Visible = false;
                itemTaiKhoan.Visible = false;

                itemThongKeTotNghiep.Visible = false;
                itemXuatBaoCao.Visible = false;
            }


        }

        private void điểmSốVàHọcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void điểmSốHọcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Hide();
                new Form1().Show();
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuSinhVien_Click(object sender, EventArgs e)
        {
            frmSinhVien sinhvien = new frmSinhVien();
            sinhvien.Show();
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            frmLop lop = new frmLop();
            lop.Show();
        }

        private void mnuNganh_Click(object sender, EventArgs e)
        {
            frmNganh nganh = new frmNganh();
            nganh.Show();
        }

        private void mnuKhoa_Click(object sender, EventArgs e)
        {
            frmKhoa khoa = new frmKhoa();
            khoa.Show();
        }

        private void mnuGiangVien_Click(object sender, EventArgs e)
        {
            frmGiangVien giangvien = new frmGiangVien();
            giangvien.Show();
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan tk = new frmTaiKhoan();
            tk.Show();
        }

        private void mnuHocPhan_Click(object sender, EventArgs e)
        {
            frmHocPhan hocphan = new frmHocPhan();
            hocphan.Show();
        }

        private void mnuLopHocPhan_Click(object sender, EventArgs e)
        {
            frmLopHocPhan lophocphan = new frmLopHocPhan();
            lophocphan.Show();
        }

        private void mnuDangKyHocPhan_Click(object sender, EventArgs e)
        {
            frmDangKyHocPhan dangkyhocphan = new frmDangKyHocPhan();
            dangkyhocphan.Show();
        }

        private void mnuThongKeHocBong_Click(object sender, EventArgs e)
        {

        }

        private void mnuNhapDiem_Click(object sender, EventArgs e)
        {
            frmDiem diem = new frmDiem();
            diem.Show();
        }

        private void mnuHocLai_Click(object sender, EventArgs e)
        {
            frmHocLai hoclai = new frmHocLai();
            hoclai.Show();
        }

        private void mnuCanhBao_Click(object sender, EventArgs e)
        {
            frmCanhBaoHocTap canhbao = new frmCanhBaoHocTap();
            canhbao.Show();
        }

        private void mnuTotNghiep_Click(object sender, EventArgs e)
        {

        }

        private void mnuThongKeTotNghiep_Click(object sender, EventArgs e)
        {
            frmTotNghiep totnghiep = new frmTotNghiep();
            totnghiep.Show();
        }

        private void mnuXuatBaoCao_Click(object sender, EventArgs e)
        {
            frmXuatDuLieu xuatdulieu = new frmXuatDuLieu();
            xuatdulieu.Show();
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {

        }
    }
    public class LightMenuRenderer : ToolStripProfessionalRenderer
    {
        private readonly Color hoverColor;
        public LightMenuRenderer(Color hover)
            : base(new LightColorTable(hover)) => hoverColor = hover;

        private class LightColorTable : ProfessionalColorTable
        {
            private readonly Color hover;
            public LightColorTable(Color hoverColor) => hover = hoverColor;

            public override Color MenuItemSelected => hover;
            public override Color ToolStripDropDownBackground => Color.White;
            public override Color MenuItemBorder => Color.LightGray;
            public override Color MenuBorder => Color.LightBlue;
            public override Color ImageMarginGradientBegin => Color.White;
            public override Color ImageMarginGradientMiddle => Color.White;
            public override Color ImageMarginGradientEnd => Color.White;
        }
    }

    public class RoundedContextMenuStrip : ContextMenuStrip
    {
        public int CornerRadius { get; set; } = 8;

        public RoundedContextMenuStrip()
        {
            this.Padding = Padding.Empty;
            this.DropShadowEnabled = false;
            this.Opening += (s, e) => ApplyRoundedCorners();
        }

        private void ApplyRoundedCorners()
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            int w = this.Width, h = this.Height, r = CornerRadius;

            path.AddArc(0, 0, r, r, 180, 90);
            path.AddArc(w - r, 0, r, r, 270, 90);
            path.AddArc(w - r, h - r, r, r, 0, 90);
            path.AddArc(0, h - r, r, r, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);
        }
    }


}

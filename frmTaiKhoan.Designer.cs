namespace QuanLiDiemDaiHoc
{
    partial class frmTaiKhoan
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTimKiem = new TextBox();
            txtMatKhau = new TextBox();
            txtTenDN = new TextBox();
            cboVaiTro = new ComboBox();
            dgvTaiKhoan = new DataGridView();
            them = new Button();
            timkiem = new Button();
            xoa = new Button();
            sua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 177);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập từ khóa càn tìm kiếm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Vai trò";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 72);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(169, 174);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(164, 23);
            txtTimKiem.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(169, 69);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(164, 23);
            txtMatKhau.TabIndex = 6;
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(169, 18);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(164, 23);
            txtTenDN.TabIndex = 7;
            // 
            // cboVaiTro
            // 
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Items.AddRange(new object[] { "Admin", "User" });
            cboVaiTro.Location = new Point(169, 116);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(164, 23);
            cboVaiTro.TabIndex = 8;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Location = new Point(376, 18);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.Size = new Size(527, 257);
            dgvTaiKhoan.TabIndex = 9;
            dgvTaiKhoan.CellContentClick += dgvTaiKhoan_CellContentClick;
            // 
            // them
            // 
            them.Location = new Point(51, 223);
            them.Name = "them";
            them.Size = new Size(75, 23);
            them.TabIndex = 10;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // timkiem
            // 
            timkiem.Location = new Point(222, 282);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(75, 23);
            timkiem.TabIndex = 11;
            timkiem.Text = "Tìm kiếm";
            timkiem.UseVisualStyleBackColor = true;
            timkiem.Click += timkiem_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(51, 282);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 23);
            xoa.TabIndex = 12;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // sua
            // 
            sua.Location = new Point(222, 223);
            sua.Name = "sua";
            sua.Size = new Size(75, 23);
            sua.TabIndex = 13;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // frmTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 334);
            Controls.Add(sua);
            Controls.Add(xoa);
            Controls.Add(timkiem);
            Controls.Add(them);
            Controls.Add(dgvTaiKhoan);
            Controls.Add(cboVaiTro);
            Controls.Add(txtTenDN);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTimKiem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTaiKhoan";
            Text = "Quản lí thông tin tài khoản đăng nhập";
            Load += frmTaiKhoan_Load;
            Click += frmTaiKhoan_Click;
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTimKiem;
        private TextBox txtMatKhau;
        private TextBox txtTenDN;
        private ComboBox cboVaiTro;
        private DataGridView dgvTaiKhoan;
        private Button them;
        private Button timkiem;
        private Button xoa;
        private Button sua;
    }
}
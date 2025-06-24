namespace QuanLiDiemDaiHoc
{
    partial class frmSinhVien
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
            label5 = new Label();
            label6 = new Label();
            txtMaSV = new TextBox();
            txtCheDoUuTien = new TextBox();
            txtQueQuan = new TextBox();
            txtHoTen = new TextBox();
            cboGioiTinh = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            dgvSinhVien = new DataGridView();
            label7 = new Label();
            txtTuKhoa = new TextBox();
            them = new Button();
            timkiem = new Button();
            xoa = new Button();
            sua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 280);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Chế độ ưu tiên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 228);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Quê quán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 177);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 124);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 74);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 5;
            label6.Text = "Họ tên";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(124, 24);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(327, 23);
            txtMaSV.TabIndex = 6;
            // 
            // txtCheDoUuTien
            // 
            txtCheDoUuTien.Location = new Point(124, 277);
            txtCheDoUuTien.Name = "txtCheDoUuTien";
            txtCheDoUuTien.Size = new Size(327, 23);
            txtCheDoUuTien.TabIndex = 8;
            // 
            // txtQueQuan
            // 
            txtQueQuan.Location = new Point(124, 225);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(327, 23);
            txtQueQuan.TabIndex = 9;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(124, 71);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(327, 23);
            txtHoTen.TabIndex = 10;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Location = new Point(124, 174);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(327, 23);
            cboGioiTinh.TabIndex = 11;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(124, 118);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(327, 23);
            dtpNgaySinh.TabIndex = 12;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(509, 24);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(514, 271);
            dgvSinhVien.TabIndex = 13;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 341);
            label7.Name = "label7";
            label7.Size = new Size(151, 15);
            label7.TabIndex = 14;
            label7.Text = "Nhập từ khóa cần tìm kiếm";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Location = new Point(184, 338);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(267, 23);
            txtTuKhoa.TabIndex = 15;
            // 
            // them
            // 
            them.Location = new Point(647, 315);
            them.Name = "them";
            them.Size = new Size(86, 28);
            them.TabIndex = 16;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // timkiem
            // 
            timkiem.Location = new Point(788, 374);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(86, 28);
            timkiem.TabIndex = 17;
            timkiem.Text = "Tìm kiếm";
            timkiem.UseVisualStyleBackColor = true;
            timkiem.Click += timkiem_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(647, 374);
            xoa.Name = "xoa";
            xoa.Size = new Size(86, 28);
            xoa.TabIndex = 18;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // sua
            // 
            sua.Location = new Point(788, 315);
            sua.Name = "sua";
            sua.Size = new Size(86, 28);
            sua.TabIndex = 19;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 443);
            Controls.Add(sua);
            Controls.Add(xoa);
            Controls.Add(timkiem);
            Controls.Add(them);
            Controls.Add(txtTuKhoa);
            Controls.Add(label7);
            Controls.Add(dgvSinhVien);
            Controls.Add(dtpNgaySinh);
            Controls.Add(cboGioiTinh);
            Controls.Add(txtHoTen);
            Controls.Add(txtQueQuan);
            Controls.Add(txtCheDoUuTien);
            Controls.Add(txtMaSV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSinhVien";
            Text = "Quản lí thông tin sinh viên";
            Load += frmSinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMaSV;
        private TextBox txtCheDoUuTien;
        private TextBox txtQueQuan;
        private TextBox txtHoTen;
        private ComboBox cboGioiTinh;
        private DateTimePicker dtpNgaySinh;
        private DataGridView dgvSinhVien;
        private Label label7;
        private TextBox txtTuKhoa;
        private Button them;
        private Button timkiem;
        private Button xoa;
        private Button sua;
    }
}
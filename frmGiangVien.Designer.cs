namespace QuanLiDiemDaiHoc
{
    partial class frmGiangVien
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
            txtMaGV = new TextBox();
            txtHoTen = new TextBox();
            txtBoMon = new TextBox();
            txtTrinhDo = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            cboGioiTinh = new ComboBox();
            dgvGiangVien = new DataGridView();
            label7 = new Label();
            txtTimKiem = new TextBox();
            them = new Button();
            timkiem = new Button();
            xoa = new Button();
            sua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGiangVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã giảng viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 287);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Trình độ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 233);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Bộ môn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 179);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 128);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 77);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 5;
            label6.Text = "Họ tên";
            // 
            // txtMaGV
            // 
            txtMaGV.Location = new Point(100, 24);
            txtMaGV.Name = "txtMaGV";
            txtMaGV.Size = new Size(255, 23);
            txtMaGV.TabIndex = 6;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(100, 74);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(255, 23);
            txtHoTen.TabIndex = 7;
            // 
            // txtBoMon
            // 
            txtBoMon.Location = new Point(100, 230);
            txtBoMon.Name = "txtBoMon";
            txtBoMon.Size = new Size(255, 23);
            txtBoMon.TabIndex = 8;
            // 
            // txtTrinhDo
            // 
            txtTrinhDo.Location = new Point(100, 284);
            txtTrinhDo.Name = "txtTrinhDo";
            txtTrinhDo.Size = new Size(255, 23);
            txtTrinhDo.TabIndex = 9;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(100, 122);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(255, 23);
            dtpNgaySinh.TabIndex = 10;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(100, 176);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(255, 23);
            cboGioiTinh.TabIndex = 11;
            // 
            // dgvGiangVien
            // 
            dgvGiangVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiangVien.Location = new Point(398, 24);
            dgvGiangVien.Name = "dgvGiangVien";
            dgvGiangVien.ReadOnly = true;
            dgvGiangVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGiangVien.Size = new Size(540, 224);
            dgvGiangVien.TabIndex = 12;
            dgvGiangVien.CellClick += dgvGiangVien_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 338);
            label7.Name = "label7";
            label7.Size = new Size(126, 15);
            label7.TabIndex = 13;
            label7.Text = "Tìm kiếm theo từ khóa";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(144, 335);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(211, 23);
            txtTimKiem.TabIndex = 14;
            // 
            // them
            // 
            them.Location = new Point(539, 279);
            them.Name = "them";
            them.Size = new Size(75, 23);
            them.TabIndex = 15;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // timkiem
            // 
            timkiem.Location = new Point(732, 330);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(75, 23);
            timkiem.TabIndex = 16;
            timkiem.Text = "Tìm kiếm";
            timkiem.UseVisualStyleBackColor = true;
            timkiem.Click += timkiem_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(539, 330);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 23);
            xoa.TabIndex = 17;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // sua
            // 
            sua.Location = new Point(732, 279);
            sua.Name = "sua";
            sua.Size = new Size(75, 23);
            sua.TabIndex = 18;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // frmGiangVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 397);
            Controls.Add(sua);
            Controls.Add(xoa);
            Controls.Add(timkiem);
            Controls.Add(them);
            Controls.Add(txtTimKiem);
            Controls.Add(label7);
            Controls.Add(dgvGiangVien);
            Controls.Add(cboGioiTinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtTrinhDo);
            Controls.Add(txtBoMon);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaGV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmGiangVien";
            Text = "frmGiangVien";
            Load += frmGiangVien_Load;
            Click += frmGiangVien_Click;
            ((System.ComponentModel.ISupportInitialize)dgvGiangVien).EndInit();
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
        private TextBox txtMaGV;
        private TextBox txtHoTen;
        private TextBox txtBoMon;
        private TextBox txtTrinhDo;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cboGioiTinh;
        private DataGridView dgvGiangVien;
        private Label label7;
        private TextBox txtTimKiem;
        private Button them;
        private Button timkiem;
        private Button xoa;
        private Button sua;
    }
}
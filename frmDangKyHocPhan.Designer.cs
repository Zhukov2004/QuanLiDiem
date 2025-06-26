namespace QuanLiDiemDaiHoc
{
    partial class frmDangKyHocPhan
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
            cboMaSV = new ComboBox();
            cboMaLHP = new ComboBox();
            txtHocKy = new TextBox();
            txtNamHoc = new TextBox();
            dgvDangKy = new DataGridView();
            label5 = new Label();
            txtTimKiem = new TextBox();
            them = new Button();
            timkiem = new Button();
            xoa = new Button();
            sua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDangKy).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Học kì";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 167);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Năm học";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 69);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 3;
            label4.Text = "Mã lớp học phần";
            // 
            // cboMaSV
            // 
            cboMaSV.FormattingEnabled = true;
            cboMaSV.Location = new Point(141, 19);
            cboMaSV.Name = "cboMaSV";
            cboMaSV.Size = new Size(223, 23);
            cboMaSV.TabIndex = 4;
            // 
            // cboMaLHP
            // 
            cboMaLHP.FormattingEnabled = true;
            cboMaLHP.Location = new Point(141, 66);
            cboMaLHP.Name = "cboMaLHP";
            cboMaLHP.Size = new Size(223, 23);
            cboMaLHP.TabIndex = 5;
            // 
            // txtHocKy
            // 
            txtHocKy.Location = new Point(141, 115);
            txtHocKy.Name = "txtHocKy";
            txtHocKy.Size = new Size(223, 23);
            txtHocKy.TabIndex = 6;
            // 
            // txtNamHoc
            // 
            txtNamHoc.Location = new Point(141, 164);
            txtNamHoc.Name = "txtNamHoc";
            txtNamHoc.Size = new Size(223, 23);
            txtNamHoc.TabIndex = 7;
            // 
            // dgvDangKy
            // 
            dgvDangKy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDangKy.Location = new Point(412, 19);
            dgvDangKy.Name = "dgvDangKy";
            dgvDangKy.ReadOnly = true;
            dgvDangKy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDangKy.Size = new Size(544, 244);
            dgvDangKy.TabIndex = 8;
            dgvDangKy.CellClick += dgvDangKy_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 219);
            label5.Name = "label5";
            label5.Size = new Size(151, 15);
            label5.TabIndex = 9;
            label5.Text = "Nhập từ khóa cần tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(169, 216);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(195, 23);
            txtTimKiem.TabIndex = 10;
            // 
            // them
            // 
            them.Location = new Point(103, 311);
            them.Name = "them";
            them.Size = new Size(75, 23);
            them.TabIndex = 11;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // timkiem
            // 
            timkiem.Location = new Point(786, 311);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(75, 23);
            timkiem.TabIndex = 12;
            timkiem.Text = "Tìm kiếm";
            timkiem.UseVisualStyleBackColor = true;
            timkiem.Click += timkiem_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(571, 311);
            xoa.Name = "xoa";
            xoa.Size = new Size(95, 23);
            xoa.TabIndex = 13;
            xoa.Text = "Hủy đăng kí";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // sua
            // 
            sua.Location = new Point(325, 311);
            sua.Name = "sua";
            sua.Size = new Size(75, 23);
            sua.TabIndex = 14;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // frmDangKyHocPhan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 401);
            Controls.Add(sua);
            Controls.Add(xoa);
            Controls.Add(timkiem);
            Controls.Add(them);
            Controls.Add(txtTimKiem);
            Controls.Add(label5);
            Controls.Add(dgvDangKy);
            Controls.Add(txtNamHoc);
            Controls.Add(txtHocKy);
            Controls.Add(cboMaLHP);
            Controls.Add(cboMaSV);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDangKyHocPhan";
            Text = "Quản lí đăng kí học phần";
            Load += frmDangKyHocPhan_Load;
            Click += frmDangKyHocPhan_Click;
            ((System.ComponentModel.ISupportInitialize)dgvDangKy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cboMaSV;
        private ComboBox cboMaLHP;
        private TextBox txtHocKy;
        private TextBox txtNamHoc;
        private DataGridView dgvDangKy;
        private Label label5;
        private TextBox txtTimKiem;
        private Button them;
        private Button timkiem;
        private Button xoa;
        private Button sua;
    }
}
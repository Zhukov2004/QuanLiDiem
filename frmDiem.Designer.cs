namespace QuanLiDiemDaiHoc
{
    partial class frmDiem
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
            label7 = new Label();
            dgvDiem = new DataGridView();
            txtTimKiem = new TextBox();
            cboMaSV = new ComboBox();
            cboMaLHP = new ComboBox();
            txtDiemThi = new TextBox();
            txtDiemTBHK = new TextBox();
            txtXepLoai = new TextBox();
            chkHocBong = new CheckBox();
            them = new Button();
            timkiem = new Button();
            xoa = new Button();
            sua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 155);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập từ khóa cần tìm kiếm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 109);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 2;
            label3.Text = "Được nhận học bổng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(470, 64);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Xếp loại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(470, 21);
            label5.Name = "label5";
            label5.Size = new Size(129, 15);
            label5.TabIndex = 4;
            label5.Text = "Điểm trung bình học kì";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 109);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 5;
            label6.Text = "Điểm thi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 64);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 6;
            label7.Text = "Mã lớp học phần";
            // 
            // dgvDiem
            // 
            dgvDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiem.Location = new Point(12, 206);
            dgvDiem.Name = "dgvDiem";
            dgvDiem.ReadOnly = true;
            dgvDiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiem.Size = new Size(845, 246);
            dgvDiem.TabIndex = 7;
            dgvDiem.CellContentClick += dgvDiem_CellContentClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(169, 152);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(200, 23);
            txtTimKiem.TabIndex = 8;
            // 
            // cboMaSV
            // 
            cboMaSV.FormattingEnabled = true;
            cboMaSV.Location = new Point(169, 18);
            cboMaSV.Name = "cboMaSV";
            cboMaSV.Size = new Size(200, 23);
            cboMaSV.TabIndex = 9;
            // 
            // cboMaLHP
            // 
            cboMaLHP.FormattingEnabled = true;
            cboMaLHP.Location = new Point(169, 61);
            cboMaLHP.Name = "cboMaLHP";
            cboMaLHP.Size = new Size(200, 23);
            cboMaLHP.TabIndex = 10;
            // 
            // txtDiemThi
            // 
            txtDiemThi.Location = new Point(169, 106);
            txtDiemThi.Name = "txtDiemThi";
            txtDiemThi.Size = new Size(200, 23);
            txtDiemThi.TabIndex = 11;
            // 
            // txtDiemTBHK
            // 
            txtDiemTBHK.Location = new Point(605, 18);
            txtDiemTBHK.Name = "txtDiemTBHK";
            txtDiemTBHK.Size = new Size(200, 23);
            txtDiemTBHK.TabIndex = 12;
            // 
            // txtXepLoai
            // 
            txtXepLoai.Location = new Point(605, 61);
            txtXepLoai.Name = "txtXepLoai";
            txtXepLoai.Size = new Size(200, 23);
            txtXepLoai.TabIndex = 13;
            // 
            // chkHocBong
            // 
            chkHocBong.AutoSize = true;
            chkHocBong.Location = new Point(605, 110);
            chkHocBong.Name = "chkHocBong";
            chkHocBong.Size = new Size(15, 14);
            chkHocBong.TabIndex = 14;
            chkHocBong.UseVisualStyleBackColor = true;
            // 
            // them
            // 
            them.Location = new Point(470, 152);
            them.Name = "them";
            them.Size = new Size(75, 23);
            them.TabIndex = 15;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // timkiem
            // 
            timkiem.Location = new Point(782, 152);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(75, 23);
            timkiem.TabIndex = 16;
            timkiem.Text = "Tìm kiếm";
            timkiem.UseVisualStyleBackColor = true;
            timkiem.Click += timkiem_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(681, 151);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 23);
            xoa.TabIndex = 17;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // sua
            // 
            sua.Location = new Point(576, 152);
            sua.Name = "sua";
            sua.Size = new Size(75, 23);
            sua.TabIndex = 18;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // frmDiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 484);
            Controls.Add(sua);
            Controls.Add(xoa);
            Controls.Add(timkiem);
            Controls.Add(them);
            Controls.Add(chkHocBong);
            Controls.Add(txtXepLoai);
            Controls.Add(txtDiemTBHK);
            Controls.Add(txtDiemThi);
            Controls.Add(cboMaLHP);
            Controls.Add(cboMaSV);
            Controls.Add(txtTimKiem);
            Controls.Add(dgvDiem);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDiem";
            Text = "Quản lí điểm sinh viên và học bổng";
            Load += frmDiem_Load;
            Click += frmDiem_Click;
            ((System.ComponentModel.ISupportInitialize)dgvDiem).EndInit();
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
        private Label label7;
        private DataGridView dgvDiem;
        private TextBox txtTimKiem;
        private ComboBox cboMaSV;
        private ComboBox cboMaLHP;
        private TextBox txtDiemThi;
        private TextBox txtDiemTBHK;
        private TextBox txtXepLoai;
        private CheckBox chkHocBong;
        private Button them;
        private Button timkiem;
        private Button xoa;
        private Button sua;
    }
}
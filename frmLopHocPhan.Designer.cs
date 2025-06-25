namespace QuanLiDiemDaiHoc
{
    partial class frmLopHocPhan
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
            txtTimKiem = new TextBox();
            txtTenLHP = new TextBox();
            txtMaLHP = new TextBox();
            cboMaHP = new ComboBox();
            cboMaGV = new ComboBox();
            dgvLopHocPhan = new DataGridView();
            them = new Button();
            timkiem = new Button();
            xoa = new Button();
            sua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLopHocPhan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã lớp học phần";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 211);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 1;
            label2.Text = "Tìm kiếm theo từ khóa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 162);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Mã giảng viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 3;
            label4.Text = "Mã học phần";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 66);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 4;
            label5.Text = "Tên lớp học phần";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(144, 208);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(207, 23);
            txtTimKiem.TabIndex = 5;
            // 
            // txtTenLHP
            // 
            txtTenLHP.Location = new Point(144, 63);
            txtTenLHP.Name = "txtTenLHP";
            txtTenLHP.Size = new Size(207, 23);
            txtTenLHP.TabIndex = 6;
            // 
            // txtMaLHP
            // 
            txtMaLHP.Location = new Point(144, 16);
            txtMaLHP.Name = "txtMaLHP";
            txtMaLHP.Size = new Size(207, 23);
            txtMaLHP.TabIndex = 7;
            // 
            // cboMaHP
            // 
            cboMaHP.FormattingEnabled = true;
            cboMaHP.Location = new Point(144, 111);
            cboMaHP.Name = "cboMaHP";
            cboMaHP.Size = new Size(207, 23);
            cboMaHP.TabIndex = 8;
            // 
            // cboMaGV
            // 
            cboMaGV.FormattingEnabled = true;
            cboMaGV.Location = new Point(144, 159);
            cboMaGV.Name = "cboMaGV";
            cboMaGV.Size = new Size(207, 23);
            cboMaGV.TabIndex = 9;
            // 
            // dgvLopHocPhan
            // 
            dgvLopHocPhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLopHocPhan.Location = new Point(388, 16);
            dgvLopHocPhan.Name = "dgvLopHocPhan";
            dgvLopHocPhan.ReadOnly = true;
            dgvLopHocPhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLopHocPhan.Size = new Size(484, 273);
            dgvLopHocPhan.TabIndex = 10;
            dgvLopHocPhan.CellContentClick += dgvLopHocPhan_CellContentClick;
            // 
            // them
            // 
            them.Location = new Point(54, 255);
            them.Name = "them";
            them.Size = new Size(75, 23);
            them.TabIndex = 11;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // timkiem
            // 
            timkiem.Location = new Point(237, 314);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(75, 23);
            timkiem.TabIndex = 12;
            timkiem.Text = "Tìm kiếm";
            timkiem.UseVisualStyleBackColor = true;
            timkiem.Click += timkiem_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(54, 314);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 23);
            xoa.TabIndex = 13;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // sua
            // 
            sua.Location = new Point(237, 255);
            sua.Name = "sua";
            sua.Size = new Size(75, 23);
            sua.TabIndex = 14;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // frmLopHocPhan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 362);
            Controls.Add(sua);
            Controls.Add(xoa);
            Controls.Add(timkiem);
            Controls.Add(them);
            Controls.Add(dgvLopHocPhan);
            Controls.Add(cboMaGV);
            Controls.Add(cboMaHP);
            Controls.Add(txtMaLHP);
            Controls.Add(txtTenLHP);
            Controls.Add(txtTimKiem);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLopHocPhan";
            Text = "Quản lí lớp học phần";
            Load += frmLopHocPhan_Load;
            Click += frmLopHocPhan_Click;
            ((System.ComponentModel.ISupportInitialize)dgvLopHocPhan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTimKiem;
        private TextBox txtTenLHP;
        private TextBox txtMaLHP;
        private ComboBox cboMaHP;
        private ComboBox cboMaGV;
        private DataGridView dgvLopHocPhan;
        private Button them;
        private Button timkiem;
        private Button xoa;
        private Button sua;
    }
}
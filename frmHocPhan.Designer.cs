namespace QuanLiDiemDaiHoc
{
    partial class frmHocPhan
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
            txtMaHP = new TextBox();
            txtHocKy = new TextBox();
            txtTenHP = new TextBox();
            txtSoTinChi = new TextBox();
            cboMaNganh = new ComboBox();
            dgvHocPhan = new DataGridView();
            label6 = new Label();
            txtTimKiem = new TextBox();
            them = new Button();
            timkiem = new Button();
            xoa = new Button();
            sua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHocPhan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã học phần";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 215);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã ngành";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 165);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Học kì";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 116);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Só tín chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 69);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 4;
            label5.Text = "Tên học phần";
            // 
            // txtMaHP
            // 
            txtMaHP.Location = new Point(95, 21);
            txtMaHP.Name = "txtMaHP";
            txtMaHP.Size = new Size(268, 23);
            txtMaHP.TabIndex = 5;
            // 
            // txtHocKy
            // 
            txtHocKy.Location = new Point(95, 162);
            txtHocKy.Name = "txtHocKy";
            txtHocKy.Size = new Size(268, 23);
            txtHocKy.TabIndex = 6;
            // 
            // txtTenHP
            // 
            txtTenHP.Location = new Point(95, 66);
            txtTenHP.Name = "txtTenHP";
            txtTenHP.Size = new Size(268, 23);
            txtTenHP.TabIndex = 7;
            // 
            // txtSoTinChi
            // 
            txtSoTinChi.Location = new Point(95, 113);
            txtSoTinChi.Name = "txtSoTinChi";
            txtSoTinChi.Size = new Size(268, 23);
            txtSoTinChi.TabIndex = 8;
            // 
            // cboMaNganh
            // 
            cboMaNganh.FormattingEnabled = true;
            cboMaNganh.Location = new Point(95, 212);
            cboMaNganh.Name = "cboMaNganh";
            cboMaNganh.Size = new Size(268, 23);
            cboMaNganh.TabIndex = 9;
            // 
            // dgvHocPhan
            // 
            dgvHocPhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocPhan.Location = new Point(406, 21);
            dgvHocPhan.Name = "dgvHocPhan";
            dgvHocPhan.ReadOnly = true;
            dgvHocPhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHocPhan.Size = new Size(462, 214);
            dgvHocPhan.TabIndex = 10;
            dgvHocPhan.CellContentClick += dgvHocPhan_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 266);
            label6.Name = "label6";
            label6.Size = new Size(151, 15);
            label6.TabIndex = 11;
            label6.Text = "Nhập từ khóa cần tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(169, 263);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(194, 23);
            txtTimKiem.TabIndex = 12;
            // 
            // them
            // 
            them.Location = new Point(520, 262);
            them.Name = "them";
            them.Size = new Size(75, 23);
            them.TabIndex = 13;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // timkiem
            // 
            timkiem.Location = new Point(685, 323);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(75, 23);
            timkiem.TabIndex = 14;
            timkiem.Text = "Tìm kiếm";
            timkiem.UseVisualStyleBackColor = true;
            timkiem.Click += timkiem_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(520, 323);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 23);
            xoa.TabIndex = 15;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // sua
            // 
            sua.Location = new Point(685, 262);
            sua.Name = "sua";
            sua.Size = new Size(75, 23);
            sua.TabIndex = 16;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // frmHocPhan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 396);
            Controls.Add(sua);
            Controls.Add(xoa);
            Controls.Add(timkiem);
            Controls.Add(them);
            Controls.Add(txtTimKiem);
            Controls.Add(label6);
            Controls.Add(dgvHocPhan);
            Controls.Add(cboMaNganh);
            Controls.Add(txtSoTinChi);
            Controls.Add(txtTenHP);
            Controls.Add(txtHocKy);
            Controls.Add(txtMaHP);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmHocPhan";
            Text = "Quản lí thông tin lớp học phần";
            Load += frmHocPhan_Load;
            Click += frmHocPhan_Click;
            ((System.ComponentModel.ISupportInitialize)dgvHocPhan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaHP;
        private TextBox txtHocKy;
        private TextBox txtTenHP;
        private TextBox txtSoTinChi;
        private ComboBox cboMaNganh;
        private DataGridView dgvHocPhan;
        private Label label6;
        private TextBox txtTimKiem;
        private Button them;
        private Button timkiem;
        private Button xoa;
        private Button sua;
    }
}
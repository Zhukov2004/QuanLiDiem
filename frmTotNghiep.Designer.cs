namespace QuanLiDiemDaiHoc
{
    partial class frmTotNghiep
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
            cboMaSV = new ComboBox();
            txtHoTen = new TextBox();
            txtTimKiem = new TextBox();
            txtXepLoai = new TextBox();
            dtpNgayTN = new DateTimePicker();
            dgvTotNghiep = new DataGridView();
            them = new Button();
            timkiem = new Button();
            xoa = new Button();
            sua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTotNghiep).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 208);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập từ khóa cần tìm kiếm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 162);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Xếp loại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 116);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 3;
            label4.Text = "Ngày tốt nghiệp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 67);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 4;
            label5.Text = "Tên sinh viên";
            // 
            // cboMaSV
            // 
            cboMaSV.FormattingEnabled = true;
            cboMaSV.Location = new Point(175, 17);
            cboMaSV.Name = "cboMaSV";
            cboMaSV.Size = new Size(188, 23);
            cboMaSV.TabIndex = 5;
            cboMaSV.SelectedIndexChanged += cboMaSV_SelectedIndexChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(175, 64);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(188, 23);
            txtHoTen.TabIndex = 6;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(175, 205);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(188, 23);
            txtTimKiem.TabIndex = 7;
            // 
            // txtXepLoai
            // 
            txtXepLoai.Location = new Point(175, 159);
            txtXepLoai.Name = "txtXepLoai";
            txtXepLoai.Size = new Size(188, 23);
            txtXepLoai.TabIndex = 8;
            // 
            // dtpNgayTN
            // 
            dtpNgayTN.Location = new Point(175, 110);
            dtpNgayTN.Name = "dtpNgayTN";
            dtpNgayTN.Size = new Size(188, 23);
            dtpNgayTN.TabIndex = 9;
            // 
            // dgvTotNghiep
            // 
            dgvTotNghiep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotNghiep.Location = new Point(424, 17);
            dgvTotNghiep.Name = "dgvTotNghiep";
            dgvTotNghiep.ReadOnly = true;
            dgvTotNghiep.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTotNghiep.Size = new Size(522, 206);
            dgvTotNghiep.TabIndex = 10;
            dgvTotNghiep.CellContentClick += dgvTotNghiep_CellContentClick;
            // 
            // them
            // 
            them.Location = new Point(549, 245);
            them.Name = "them";
            them.Size = new Size(75, 23);
            them.TabIndex = 11;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // timkiem
            // 
            timkiem.Location = new Point(739, 288);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(75, 23);
            timkiem.TabIndex = 12;
            timkiem.Text = "Tìm kiếm";
            timkiem.UseVisualStyleBackColor = true;
            timkiem.Click += timkiem_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(549, 288);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 23);
            xoa.TabIndex = 13;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // sua
            // 
            sua.Location = new Point(739, 245);
            sua.Name = "sua";
            sua.Size = new Size(75, 23);
            sua.TabIndex = 14;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // frmTotNghiep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 346);
            Controls.Add(sua);
            Controls.Add(xoa);
            Controls.Add(timkiem);
            Controls.Add(them);
            Controls.Add(dgvTotNghiep);
            Controls.Add(dtpNgayTN);
            Controls.Add(txtXepLoai);
            Controls.Add(txtTimKiem);
            Controls.Add(txtHoTen);
            Controls.Add(cboMaSV);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTotNghiep";
            Text = "Danh sách sinh viên tốt nghiệp";
            Load += frmTotNghiep_Load;
            Click += frmTotNghiep_Click;
            ((System.ComponentModel.ISupportInitialize)dgvTotNghiep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboMaSV;
        private TextBox txtHoTen;
        private TextBox txtTimKiem;
        private TextBox txtXepLoai;
        private DateTimePicker dtpNgayTN;
        private DataGridView dgvTotNghiep;
        private Button them;
        private Button timkiem;
        private Button xoa;
        private Button sua;
    }
}
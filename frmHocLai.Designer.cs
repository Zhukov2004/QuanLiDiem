namespace QuanLiDiemDaiHoc
{
    partial class frmHocLai
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
            cboMaSV = new ComboBox();
            cboMaLHP = new ComboBox();
            txtLyDo = new TextBox();
            txtLanHoc = new TextBox();
            txtTimKiem = new TextBox();
            dtpNgayDK = new DateTimePicker();
            dgvHocLai = new DataGridView();
            them = new Button();
            timkiem = new Button();
            xoa = new Button();
            sua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHocLai).BeginInit();
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
            label2.Location = new Point(404, 113);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập từ khóa cần tìm kiếm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 65);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Ngày đăng kí";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(404, 21);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Lần học";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 113);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 4;
            label5.Text = "Lí do";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 65);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 5;
            label6.Text = "Mã lớp học phần";
            // 
            // cboMaSV
            // 
            cboMaSV.FormattingEnabled = true;
            cboMaSV.Location = new Point(128, 18);
            cboMaSV.Name = "cboMaSV";
            cboMaSV.Size = new Size(212, 23);
            cboMaSV.TabIndex = 6;
            // 
            // cboMaLHP
            // 
            cboMaLHP.FormattingEnabled = true;
            cboMaLHP.Location = new Point(128, 62);
            cboMaLHP.Name = "cboMaLHP";
            cboMaLHP.Size = new Size(212, 23);
            cboMaLHP.TabIndex = 7;
            // 
            // txtLyDo
            // 
            txtLyDo.Location = new Point(128, 110);
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(212, 23);
            txtLyDo.TabIndex = 8;
            // 
            // txtLanHoc
            // 
            txtLanHoc.Location = new Point(569, 18);
            txtLanHoc.Name = "txtLanHoc";
            txtLanHoc.Size = new Size(212, 23);
            txtLanHoc.TabIndex = 9;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(569, 110);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(212, 23);
            txtTimKiem.TabIndex = 10;
            // 
            // dtpNgayDK
            // 
            dtpNgayDK.Location = new Point(569, 59);
            dtpNgayDK.Name = "dtpNgayDK";
            dtpNgayDK.Size = new Size(212, 23);
            dtpNgayDK.TabIndex = 11;
            // 
            // dgvHocLai
            // 
            dgvHocLai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocLai.Location = new Point(12, 165);
            dgvHocLai.Name = "dgvHocLai";
            dgvHocLai.ReadOnly = true;
            dgvHocLai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHocLai.Size = new Size(806, 194);
            dgvHocLai.TabIndex = 12;
            dgvHocLai.CellContentClick += dgvHocLai_CellContentClick;
            // 
            // them
            // 
            them.Location = new Point(188, 393);
            them.Name = "them";
            them.Size = new Size(75, 23);
            them.TabIndex = 13;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // timkiem
            // 
            timkiem.Location = new Point(569, 393);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(75, 23);
            timkiem.TabIndex = 14;
            timkiem.Text = "Tìm kiếm";
            timkiem.UseVisualStyleBackColor = true;
            timkiem.Click += timkiem_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(443, 393);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 23);
            xoa.TabIndex = 15;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // sua
            // 
            sua.Location = new Point(316, 393);
            sua.Name = "sua";
            sua.Size = new Size(75, 23);
            sua.TabIndex = 16;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // frmHocLai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 459);
            Controls.Add(sua);
            Controls.Add(xoa);
            Controls.Add(timkiem);
            Controls.Add(them);
            Controls.Add(dgvHocLai);
            Controls.Add(dtpNgayDK);
            Controls.Add(txtTimKiem);
            Controls.Add(txtLanHoc);
            Controls.Add(txtLyDo);
            Controls.Add(cboMaLHP);
            Controls.Add(cboMaSV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmHocLai";
            Text = "Quản lí thông tin sinh viên học lại";
            Load += frmHocLai_Load;
            Click += frmHocLai_Click;
            ((System.ComponentModel.ISupportInitialize)dgvHocLai).EndInit();
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
        private ComboBox cboMaSV;
        private ComboBox cboMaLHP;
        private TextBox txtLyDo;
        private TextBox txtLanHoc;
        private TextBox txtTimKiem;
        private DateTimePicker dtpNgayDK;
        private DataGridView dgvHocLai;
        private Button them;
        private Button timkiem;
        private Button xoa;
        private Button sua;
    }
}
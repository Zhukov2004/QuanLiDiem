namespace QuanLiDiemDaiHoc
{
    partial class frmCanhBaoHocTap
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
            label8 = new Label();
            cboMaSV = new ComboBox();
            txtHoTen = new TextBox();
            txtHocKy = new TextBox();
            txtNamHoc = new TextBox();
            txtLyDo = new TextBox();
            txtTimKiem = new TextBox();
            dtpNgayCB = new DateTimePicker();
            dgvCanhBao = new DataGridView();
            them = new Button();
            timkiem = new Button();
            xoa = new Button();
            sua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCanhBao).BeginInit();
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
            label2.Location = new Point(450, 137);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập từ khóa tìm kiếm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(450, 96);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 2;
            label3.Text = "Ngày cảnh báo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 57);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Lí do";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(450, 20);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 4;
            label5.Text = "Học kì";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 101);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 5;
            label6.Text = "Năm học";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 60);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 7;
            label8.Text = "Họ tên";
            // 
            // cboMaSV
            // 
            cboMaSV.FormattingEnabled = true;
            cboMaSV.Location = new Point(92, 17);
            cboMaSV.Name = "cboMaSV";
            cboMaSV.Size = new Size(281, 23);
            cboMaSV.TabIndex = 8;
            cboMaSV.SelectedIndexChanged += cboMaSV_SelectedIndexChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(92, 57);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(281, 23);
            txtHoTen.TabIndex = 9;
            // 
            // txtHocKy
            // 
            txtHocKy.Location = new Point(588, 17);
            txtHocKy.Name = "txtHocKy";
            txtHocKy.Size = new Size(332, 23);
            txtHocKy.TabIndex = 10;
            // 
            // txtNamHoc
            // 
            txtNamHoc.Location = new Point(92, 98);
            txtNamHoc.Name = "txtNamHoc";
            txtNamHoc.Size = new Size(281, 23);
            txtNamHoc.TabIndex = 11;
            // 
            // txtLyDo
            // 
            txtLyDo.Location = new Point(588, 54);
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(332, 23);
            txtLyDo.TabIndex = 13;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(588, 134);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(332, 23);
            txtTimKiem.TabIndex = 14;
            // 
            // dtpNgayCB
            // 
            dtpNgayCB.Location = new Point(588, 93);
            dtpNgayCB.Name = "dtpNgayCB";
            dtpNgayCB.Size = new Size(332, 23);
            dtpNgayCB.TabIndex = 15;
            // 
            // dgvCanhBao
            // 
            dgvCanhBao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCanhBao.Location = new Point(12, 185);
            dgvCanhBao.Name = "dgvCanhBao";
            dgvCanhBao.ReadOnly = true;
            dgvCanhBao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCanhBao.Size = new Size(908, 177);
            dgvCanhBao.TabIndex = 16;
            dgvCanhBao.CellClick += dataGridView1_CellClick;
            // 
            // them
            // 
            them.Location = new Point(244, 382);
            them.Name = "them";
            them.Size = new Size(75, 23);
            them.TabIndex = 17;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // timkiem
            // 
            timkiem.Location = new Point(635, 382);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(75, 23);
            timkiem.TabIndex = 18;
            timkiem.Text = "Tìm kiếm";
            timkiem.UseVisualStyleBackColor = true;
            timkiem.Click += timkiem_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(504, 382);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 23);
            xoa.TabIndex = 19;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // sua
            // 
            sua.Location = new Point(374, 382);
            sua.Name = "sua";
            sua.Size = new Size(75, 23);
            sua.TabIndex = 20;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // frmCanhBaoHocTap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 453);
            Controls.Add(sua);
            Controls.Add(xoa);
            Controls.Add(timkiem);
            Controls.Add(them);
            Controls.Add(dgvCanhBao);
            Controls.Add(dtpNgayCB);
            Controls.Add(txtTimKiem);
            Controls.Add(txtLyDo);
            Controls.Add(txtNamHoc);
            Controls.Add(txtHocKy);
            Controls.Add(txtHoTen);
            Controls.Add(cboMaSV);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCanhBaoHocTap";
            Text = "Cảnh báo học tập sinh viên";
            Load += frmCanhBaoHocTap_Load;
            Click += frmCanhBaoHocTap_Click;
            ((System.ComponentModel.ISupportInitialize)dgvCanhBao).EndInit();
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
        private Label label8;
        private ComboBox cboMaSV;
        private TextBox txtHoTen;
        private TextBox txtHocKy;
        private TextBox txtNamHoc;
        private TextBox txtLyDo;
        private TextBox txtTimKiem;
        private DateTimePicker dtpNgayCB;
        private DataGridView dgvCanhBao;
        private Button them;
        private Button timkiem;
        private Button xoa;
        private Button sua;
    }
}
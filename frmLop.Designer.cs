namespace QuanLiDiemDaiHoc
{
    partial class frmLop
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaLop = new TextBox();
            txtTimKiem = new TextBox();
            txtCoVan = new TextBox();
            txtTenLop = new TextBox();
            dgvLop = new DataGridView();
            them = new Button();
            sua = new Button();
            xoa = new Button();
            timkiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLop).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã lớp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 182);
            label3.Name = "label3";
            label3.Size = new Size(151, 15);
            label3.TabIndex = 2;
            label3.Text = "Nhập từ khóa cần tìm kiếm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 127);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 3;
            label4.Text = "Cố vấn học tập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 77);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 4;
            label5.Text = "Tên lớp";
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(105, 24);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(304, 23);
            txtMaLop.TabIndex = 5;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(169, 179);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(240, 23);
            txtTimKiem.TabIndex = 7;
            // 
            // txtCoVan
            // 
            txtCoVan.Location = new Point(105, 124);
            txtCoVan.Name = "txtCoVan";
            txtCoVan.Size = new Size(304, 23);
            txtCoVan.TabIndex = 8;
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(105, 74);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(304, 23);
            txtTenLop.TabIndex = 9;
            // 
            // dgvLop
            // 
            dgvLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLop.Location = new Point(466, 24);
            dgvLop.Name = "dgvLop";
            dgvLop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLop.Size = new Size(424, 231);
            dgvLop.TabIndex = 10;
            dgvLop.CellClick += dgvLop_CellClick;
            // 
            // them
            // 
            them.Location = new Point(551, 269);
            them.Name = "them";
            them.Size = new Size(75, 23);
            them.TabIndex = 11;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // sua
            // 
            sua.Location = new Point(723, 269);
            sua.Name = "sua";
            sua.Size = new Size(75, 23);
            sua.TabIndex = 12;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(551, 317);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 23);
            xoa.TabIndex = 13;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // timkiem
            // 
            timkiem.Location = new Point(723, 317);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(75, 23);
            timkiem.TabIndex = 14;
            timkiem.Text = "Tìm kiếm";
            timkiem.UseVisualStyleBackColor = true;
            timkiem.Click += timkiem_Click;
            // 
            // frmLop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 365);
            Controls.Add(timkiem);
            Controls.Add(xoa);
            Controls.Add(sua);
            Controls.Add(them);
            Controls.Add(dgvLop);
            Controls.Add(txtTenLop);
            Controls.Add(txtCoVan);
            Controls.Add(txtTimKiem);
            Controls.Add(txtMaLop);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmLop";
            Text = "Quản lí thông tin lớp";
            Load += frmLop_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaLop;
        private TextBox txtTimKiem;
        private TextBox txtCoVan;
        private TextBox txtTenLop;
        private DataGridView dgvLop;
        private Button them;
        private Button sua;
        private Button xoa;
        private Button timkiem;
    }
}
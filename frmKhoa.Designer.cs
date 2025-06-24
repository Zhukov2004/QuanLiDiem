namespace QuanLiDiemDaiHoc
{
    partial class frmKhoa
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
            txtMaKhoa = new TextBox();
            txtTimKiem = new TextBox();
            txtTenKhoa = new TextBox();
            dgvKhoa = new DataGridView();
            them = new Button();
            timkiem = new Button();
            xoa = new Button();
            sua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã khoa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 132);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập từ khóa tìm kiếm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên khoa";
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(163, 22);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(179, 23);
            txtMaKhoa.TabIndex = 3;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(163, 129);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(179, 23);
            txtTimKiem.TabIndex = 4;
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(163, 76);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(179, 23);
            txtTenKhoa.TabIndex = 5;
            // 
            // dgvKhoa
            // 
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.Location = new Point(387, 22);
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.Size = new Size(416, 213);
            dgvKhoa.TabIndex = 6;
            // 
            // them
            // 
            them.Location = new Point(66, 179);
            them.Name = "them";
            them.Size = new Size(75, 23);
            them.TabIndex = 7;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // timkiem
            // 
            timkiem.Location = new Point(219, 229);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(75, 23);
            timkiem.TabIndex = 8;
            timkiem.Text = "Tìm kiếm";
            timkiem.UseVisualStyleBackColor = true;
            timkiem.Click += timkiem_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(66, 229);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 23);
            xoa.TabIndex = 9;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // sua
            // 
            sua.Location = new Point(219, 179);
            sua.Name = "sua";
            sua.Size = new Size(75, 23);
            sua.TabIndex = 10;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // frmKhoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 281);
            Controls.Add(sua);
            Controls.Add(xoa);
            Controls.Add(timkiem);
            Controls.Add(them);
            Controls.Add(dgvKhoa);
            Controls.Add(txtTenKhoa);
            Controls.Add(txtTimKiem);
            Controls.Add(txtMaKhoa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmKhoa";
            Text = "Quản lí thông tin khoa";
            Load += frmKhoa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaKhoa;
        private TextBox txtTimKiem;
        private TextBox txtTenKhoa;
        private DataGridView dgvKhoa;
        private Button them;
        private Button timkiem;
        private Button xoa;
        private Button sua;
    }
}
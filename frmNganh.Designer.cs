namespace QuanLiDiemDaiHoc
{
    partial class frmNganh
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
            txtTimKiem = new TextBox();
            txtTenNganh = new TextBox();
            txtMaNganh = new TextBox();
            dgvNganh = new DataGridView();
            them = new Button();
            timkiem = new Button();
            xoa = new Button();
            sua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNganh).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã ngành";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 132);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập từ khóa cần tìm kiếm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên ngành";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(169, 129);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(216, 23);
            txtTimKiem.TabIndex = 3;
            // 
            // txtTenNganh
            // 
            txtTenNganh.Location = new Point(169, 78);
            txtTenNganh.Name = "txtTenNganh";
            txtTenNganh.Size = new Size(216, 23);
            txtTenNganh.TabIndex = 4;
            // 
            // txtMaNganh
            // 
            txtMaNganh.Location = new Point(169, 28);
            txtMaNganh.Name = "txtMaNganh";
            txtMaNganh.Size = new Size(216, 23);
            txtMaNganh.TabIndex = 5;
            // 
            // dgvNganh
            // 
            dgvNganh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNganh.Location = new Point(440, 28);
            dgvNganh.Name = "dgvNganh";
            dgvNganh.Size = new Size(452, 204);
            dgvNganh.TabIndex = 6;
            dgvNganh.CellClick += dgvNganh_CellClick;
            // 
            // them
            // 
            them.Location = new Point(83, 177);
            them.Name = "them";
            them.Size = new Size(75, 23);
            them.TabIndex = 7;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // timkiem
            // 
            timkiem.Location = new Point(251, 231);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(75, 23);
            timkiem.TabIndex = 8;
            timkiem.Text = "Tìm kiếm";
            timkiem.UseVisualStyleBackColor = true;
            timkiem.Click += timkiem_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(83, 231);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 23);
            xoa.TabIndex = 9;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // sua
            // 
            sua.Location = new Point(251, 177);
            sua.Name = "sua";
            sua.Size = new Size(75, 23);
            sua.TabIndex = 10;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // frmNganh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 308);
            Controls.Add(sua);
            Controls.Add(xoa);
            Controls.Add(timkiem);
            Controls.Add(them);
            Controls.Add(dgvNganh);
            Controls.Add(txtMaNganh);
            Controls.Add(txtTenNganh);
            Controls.Add(txtTimKiem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNganh";
            Text = "Quản lí thông tin ngành học";
            Load += frmNganh_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNganh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTimKiem;
        private TextBox txtTenNganh;
        private TextBox txtMaNganh;
        private DataGridView dgvNganh;
        private Button them;
        private Button timkiem;
        private Button xoa;
        private Button sua;
    }
}
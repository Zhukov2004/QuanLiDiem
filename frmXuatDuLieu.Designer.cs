namespace QuanLiDiemDaiHoc
{
    partial class frmXuatDuLieu
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
            cboLoaiDuLieu = new ComboBox();
            dgvDuLieu = new DataGridView();
            excel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDuLieu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 0;
            label1.Text = "Chọn danh sách cần xuất";
            // 
            // cboLoaiDuLieu
            // 
            cboLoaiDuLieu.FormattingEnabled = true;
            cboLoaiDuLieu.Items.AddRange(new object[] { "Sinh viên", "Học phần ", "Đăng kí học phần", "Cảnh báo học tập", "Tốt nghiệp" });
            cboLoaiDuLieu.Location = new Point(169, 19);
            cboLoaiDuLieu.Name = "cboLoaiDuLieu";
            cboLoaiDuLieu.Size = new Size(121, 23);
            cboLoaiDuLieu.TabIndex = 1;
            cboLoaiDuLieu.SelectedIndexChanged += cboLoaiDuLieu_SelectedIndexChanged;
            // 
            // dgvDuLieu
            // 
            dgvDuLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDuLieu.Location = new Point(12, 63);
            dgvDuLieu.Name = "dgvDuLieu";
            dgvDuLieu.ReadOnly = true;
            dgvDuLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDuLieu.Size = new Size(728, 238);
            dgvDuLieu.TabIndex = 2;
            dgvDuLieu.CellContentClick += dgvDuLieu_CellContentClick;
            // 
            // excel
            // 
            excel.Location = new Point(485, 19);
            excel.Name = "excel";
            excel.Size = new Size(75, 23);
            excel.TabIndex = 3;
            excel.Text = "Xuất Excel";
            excel.UseVisualStyleBackColor = true;
            excel.Click += excel_Click;
            // 
            // frmXuatDuLieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 340);
            Controls.Add(excel);
            Controls.Add(dgvDuLieu);
            Controls.Add(cboLoaiDuLieu);
            Controls.Add(label1);
            Name = "frmXuatDuLieu";
            Text = "Xuất danh sách";
            ((System.ComponentModel.ISupportInitialize)dgvDuLieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboLoaiDuLieu;
        private DataGridView dgvDuLieu;
        private Button excel;
    }
}
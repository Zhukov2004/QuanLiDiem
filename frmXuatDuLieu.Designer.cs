using Guna.UI2.WinForms;

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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna2Elipse(components);
            labelTitle = new Guna2HtmlLabel();
            cboLoaiDuLieu = new Guna2ComboBox();
            dgvDuLieu = new Guna2DataGridView();
            btnExcel = new Guna2Button();
            btnClose = new Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)dgvDuLieu).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = this;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Teal;
            labelTitle.Location = new Point(20, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(157, 19);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Chọn danh sách cần xuất";
            // 
            // cboLoaiDuLieu
            // 
            cboLoaiDuLieu.BackColor = Color.Transparent;
            cboLoaiDuLieu.BorderRadius = 8;
            cboLoaiDuLieu.CustomizableEdges = customizableEdges1;
            cboLoaiDuLieu.DrawMode = DrawMode.OwnerDrawFixed;
            cboLoaiDuLieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiDuLieu.FocusedColor = Color.Empty;
            cboLoaiDuLieu.Font = new Font("Segoe UI", 10F);
            cboLoaiDuLieu.ForeColor = Color.Black;
            cboLoaiDuLieu.HoverState.BorderColor = Color.Teal;
            cboLoaiDuLieu.ItemHeight = 30;
            cboLoaiDuLieu.Items.AddRange(new object[] { "Sinh viên", "Học phần", "Đăng ký học phần", "Cảnh báo học tập", "Tốt nghiệp" });
            cboLoaiDuLieu.Location = new Point(201, 20);
            cboLoaiDuLieu.Name = "cboLoaiDuLieu";
            cboLoaiDuLieu.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cboLoaiDuLieu.Size = new Size(180, 36);
            cboLoaiDuLieu.TabIndex = 1;
            cboLoaiDuLieu.SelectedIndexChanged += cboLoaiDuLieu_SelectedIndexChanged;
            // 
            // dgvDuLieu
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvDuLieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDuLieu.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDuLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDuLieu.ColumnHeadersHeight = 4;
            dgvDuLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 230, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDuLieu.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDuLieu.GridColor = Color.LightGray;
            dgvDuLieu.Location = new Point(20, 75);
            dgvDuLieu.Name = "dgvDuLieu";
            dgvDuLieu.ReadOnly = true;
            dgvDuLieu.RowHeadersVisible = false;
            dgvDuLieu.Size = new Size(710, 230);
            dgvDuLieu.TabIndex = 2;
            dgvDuLieu.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvDuLieu.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvDuLieu.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvDuLieu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvDuLieu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvDuLieu.ThemeStyle.BackColor = Color.White;
            dgvDuLieu.ThemeStyle.GridColor = Color.LightGray;
            dgvDuLieu.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvDuLieu.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDuLieu.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvDuLieu.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDuLieu.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvDuLieu.ThemeStyle.HeaderStyle.Height = 4;
            dgvDuLieu.ThemeStyle.ReadOnly = true;
            dgvDuLieu.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvDuLieu.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDuLieu.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvDuLieu.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvDuLieu.ThemeStyle.RowsStyle.Height = 25;
            dgvDuLieu.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(210, 230, 255);
            dgvDuLieu.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            dgvDuLieu.CellContentClick += dgvDuLieu_CellContentClick;
            // 
            // btnExcel
            // 
            btnExcel.BorderRadius = 10;
            btnExcel.BorderThickness = 0;
            btnExcel.BackColor = Color.Transparent;
            btnExcel.FillColor = Color.Teal;
            btnExcel.ForeColor = Color.White;
            btnExcel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExcel.Location = new Point(475, 20);
            btnExcel.Size = new Size(120, 36);
            btnExcel.Parent = this; // hoặc panel gốc nền gradient
            btnExcel.ShadowDecoration.Enabled = false;
            btnExcel.HoverState.FillColor = Color.FromArgb(0, 180, 180);
            btnExcel.Text = "Xuất Excel";
            btnExcel.Click += excel_Click;

            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BorderRadius = 6;
            btnClose.CustomizableEdges = customizableEdges5;
            btnClose.FillColor = Color.Transparent;
            btnClose.BackColor = Color.Transparent;
            btnClose.IconColor = Color.Crimson;
            btnClose.Parent = this;
            btnClose.Location = new Point(710, 12);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 99;
            // 
            // frmXuatDuLieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 340);
            Controls.Add(labelTitle);
            Controls.Add(cboLoaiDuLieu);
            Controls.Add(dgvDuLieu);
            Controls.Add(btnExcel);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmXuatDuLieu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xuất danh sách";
            Load += frmXuatDuLieu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDuLieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
            Guna2DragControl drag = new Guna2DragControl();
            drag.TargetControl = this;

        }

        #endregion

        private Guna2Elipse guna2Elipse1;
        private Guna2HtmlLabel labelTitle;
        private Guna2ComboBox cboLoaiDuLieu;
        private Guna2DataGridView dgvDuLieu;
        private Guna2Button btnExcel;
        private Guna2ControlBox btnClose;

    }
}
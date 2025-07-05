using Guna.UI2.WinForms;

namespace QuanLiDiemDaiHoc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse = new Guna2Elipse(components);
            txttk = new Guna2TextBox();
            txtmk = new Guna2TextBox();
            dangnhap = new Guna2Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnClose = new Guna2ControlBox();
            SuspendLayout();
            // 
            // guna2Elipse
            // 
            guna2Elipse.BorderRadius = 20;
            guna2Elipse.TargetControl = this;
            // 
            // txttk
            // 
            txttk.BorderRadius = 8;
            txttk.CustomizableEdges = customizableEdges1;
            txttk.DefaultText = "";
            txttk.Font = new Font("Segoe UI", 10F);
            txttk.Location = new Point(40, 90);
            txttk.Name = "txttk";
            txttk.PlaceholderText = "Nhập tài khoản";
            txtmk.FillColor = Color.White;
            txtmk.BorderColor = Color.Teal;
            txtmk.ForeColor = Color.Black;
            txtmk.PlaceholderForeColor = Color.Gray;

            txttk.BackColor = Color.Transparent;
            txttk.SelectedText = "";
            txttk.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txttk.Size = new Size(320, 40);
            txttk.TabIndex = 3;
            // 
            // txtmk
            // 
            txtmk.BorderRadius = 8;
            txtmk.CustomizableEdges = customizableEdges3;
            txtmk.DefaultText = "";
            txtmk.Font = new Font("Segoe UI", 10F);
            txtmk.Location = new Point(40, 150);
            txtmk.Name = "txtmk";
            txtmk.PlaceholderText = "Nhập mật khẩu";
            txttk.FillColor = Color.White;
            txttk.BorderColor = Color.Teal; 
            txttk.ForeColor = Color.Black;
            txttk.PlaceholderForeColor = Color.Gray;

            txtmk.BackColor = Color.Transparent;
            txtmk.SelectedText = "";
            txtmk.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtmk.Size = new Size(320, 40);
            txtmk.TabIndex = 4;
            txtmk.UseSystemPasswordChar = true;
            // 
            // dangnhap
            // 
            dangnhap.Animated = true;
            dangnhap.BorderRadius = 10;
            dangnhap.Cursor = Cursors.Hand;
            dangnhap.CustomizableEdges = customizableEdges5;
            dangnhap.BackColor = Color.Transparent;

            dangnhap.FillColor = Color.Teal;                     // Nền xanh
            dangnhap.ForeColor = Color.White;                    // Chữ trắng rõ
            dangnhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            dangnhap.BorderColor = Color.Transparent;            // Không viền
            dangnhap.BorderThickness = 0;

            dangnhap.HoverState.FillColor = Color.DarkCyan;      // Hover chuyển xanh đậm
            dangnhap.HoverState.ForeColor = Color.White;

            dangnhap.Location = new Point(120, 210);
            dangnhap.Name = "dangnhap";
            dangnhap.Size = new Size(160, 45);
            dangnhap.TabIndex = 5;
            dangnhap.Text = "ĐĂNG NHẬP";
            dangnhap.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dangnhap.Click += dangnhap_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(88, 17);
            label1.Name = "label1";
            label1.Size = new Size(232, 25);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            label1.BackColor = Color.Transparent;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(40, 70);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Tài khoản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(40, 130);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            label1.BackColor = Color.Transparent;

            label2.BackColor = Color.Transparent;

            label3.BackColor = Color.Transparent;
            label1.ForeColor = Color.Crimson;     // Tiêu đề
            label2.ForeColor = Color.IndianRed;   // Tài khoản
            label3.ForeColor = Color.IndianRed;   // Mật khẩu



            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BorderRadius = 6;
            btnClose.CustomizableEdges = customizableEdges7;
            btnClose.FillColor = Color.Transparent;
            btnClose.HoverState.FillColor = Color.FromArgb(50, Color.White); // nhẹ thôi
            btnClose.IconColor = Color.White;
            btnClose.BackColor = Color.Transparent;
            btnClose.Location = new Point(378, 12);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(420, 282);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txttk);
            Controls.Add(txtmk);
            Controls.Add(dangnhap);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
            this.Paint += Form1_Paint;

        }

        #endregion

        private Guna2Elipse guna2Elipse;
        private Guna2TextBox txttk;
        private Guna2TextBox txtmk;
        private Guna2Button dangnhap;
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna2ControlBox btnClose;
    }
}

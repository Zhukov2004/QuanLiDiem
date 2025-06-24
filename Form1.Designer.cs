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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txttk = new TextBox();
            txtmk = new TextBox();
            dangnhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 28);
            label1.Name = "label1";
            label1.Size = new Size(181, 37);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(24, 92);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(24, 140);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // txttk
            // 
            txttk.Location = new Point(121, 89);
            txttk.Name = "txttk";
            txttk.Size = new Size(566, 23);
            txttk.TabIndex = 3;
            // 
            // txtmk
            // 
            txtmk.Location = new Point(121, 137);
            txtmk.Name = "txtmk";
            txtmk.PasswordChar = '*';
            txtmk.Size = new Size(566, 23);
            txtmk.TabIndex = 4;
            // 
            // dangnhap
            // 
            dangnhap.ForeColor = Color.Black;
            dangnhap.Location = new Point(321, 204);
            dangnhap.Name = "dangnhap";
            dangnhap.Size = new Size(75, 23);
            dangnhap.TabIndex = 5;
            dangnhap.Text = "Đăng nhập";
            dangnhap.UseVisualStyleBackColor = true;
            dangnhap.Click += dangnhap_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 272);
            Controls.Add(dangnhap);
            Controls.Add(txtmk);
            Controls.Add(txttk);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Red;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txttk;
        private TextBox txtmk;
        private Button dangnhap;
    }
}

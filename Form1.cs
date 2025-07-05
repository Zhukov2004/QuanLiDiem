using System.Drawing.Drawing2D;
using QuanLiDiemDaiHoc.DAL;
namespace QuanLiDiemDaiHoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // ⬅ Bật chống nháy
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        private float gradientAngle = 0f;
        private float gradientSpeed = 2f; // tốc độ quay
        private System.Windows.Forms.Timer gradientTimer;




        private async void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0; // Ẩn ban đầu
            for (double i = 0; i <= 1; i += 0.05)
            {
                this.Opacity = i;
                await System.Threading.Tasks.Task.Delay(10); // Delay nhỏ cho mượt
            }
            gradientTimer = new System.Windows.Forms.Timer();
            gradientTimer.Interval = 20; // tốc độ mượt
            gradientTimer.Tick += (s, e) =>
            {
                gradientAngle += gradientSpeed;
                if (gradientAngle >= 360f) gradientAngle = 0f;

                this.Invalidate(); // bắt redraw form
            };
            gradientTimer.Start();



        }

        private void dangnhap_Click_1(object sender, EventArgs e)
        {
            TaiKhoanDAL dal = new TaiKhoanDAL();
            string vaiTro = dal.LayVaiTro(txttk.Text.Trim(), txtmk.Text.Trim());

            if (vaiTro == "Admin" || vaiTro == "User")
            {
                this.Hide();
                frmMain main = new frmMain(vaiTro); // truyền vai trò sang form chính
                main.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(255, 128, 255),   // màu đầu
                Color.DeepSkyBlue,              // màu cuối
                gradientAngle))                 // góc động xoay
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }




    }
}

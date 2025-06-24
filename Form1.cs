using QuanLiDiemDaiHoc.DAL;

namespace QuanLiDiemDaiHoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dangnhap_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

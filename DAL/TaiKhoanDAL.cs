using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuanLiDiemDaiHoc.DAL
{
    public class TaiKhoanDAL
    {
        private readonly string connectionString = "server=localhost;port=3306;database=qldiemsinhvien;uid=root;pwd=;";

        public string LayVaiTro(string username, string password)
        {
            string role = null;
            string query = "SELECT VaiTro FROM TaiKhoan WHERE TenDangNhap = @user AND MatKhau = @pass";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                    role = result.ToString();
            }

            return role;
        }

    }
}

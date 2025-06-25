using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.DAL
{
    public class TaiKhoanDAL
    {
        private readonly string connStr = "server=localhost;port=3306;database=qldiemsinhvien;uid=root;pwd=;";

        public string LayVaiTro(string username, string password)
        {
            string role = null;
            string query = "SELECT VaiTro FROM TaiKhoan WHERE TenDangNhap = @user AND MatKhau = @pass";

            using (MySqlConnection conn = new MySqlConnection(connStr))
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
        public List<TaiKhoan> LayTatCa()
        {
            var ds = new List<TaiKhoan>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM TaiKhoan";
                var cmd = new MySqlCommand(sql, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new TaiKhoan
                    {
                        TenDangNhap = reader["TenDangNhap"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        VaiTro = reader["VaiTro"].ToString()
                    });
                }
            }
            return ds;
        }

        public bool Them(TaiKhoan tk)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "INSERT INTO TaiKhoan VALUES (@TenDN, @MatKhau, @VaiTro)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenDN", tk.TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", tk.MatKhau);
                cmd.Parameters.AddWithValue("@VaiTro", tk.VaiTro);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Sua(TaiKhoan tk)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "UPDATE TaiKhoan SET MatKhau=@MatKhau, VaiTro=@VaiTro WHERE TenDangNhap=@TenDN";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenDN", tk.TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", tk.MatKhau);
                cmd.Parameters.AddWithValue("@VaiTro", tk.VaiTro);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string tenDN)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "DELETE FROM TaiKhoan WHERE TenDangNhap=@TenDN";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenDN", tenDN);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<TaiKhoan> TimKiem(string tuKhoa)
        {
            var ds = new List<TaiKhoan>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM TaiKhoan WHERE TenDangNhap LIKE @kw";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + tuKhoa + "%");
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new TaiKhoan
                    {
                        TenDangNhap = reader["TenDangNhap"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        VaiTro = reader["VaiTro"].ToString()
                    });
                }
            }
            return ds;
        }

    }
}

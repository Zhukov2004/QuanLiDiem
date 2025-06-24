using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.DAL
{
    public class KhoaDAL
    {
        private string connStr = "server=localhost;port=3306;database=QLDiemSinhVien;uid=root;pwd=;";

        public List<Khoa> LayTatCa()
        {
            List<Khoa> list = new List<Khoa>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Khoa";
                var cmd = new MySqlCommand(sql, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Khoa
                    {
                        MaKhoa = reader["MaKhoa"].ToString(),
                        TenKhoa = reader["TenKhoa"].ToString()
                    });
                }
            }
            return list;
        }

        public bool Them(Khoa k)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "INSERT INTO Khoa VALUES (@MaKhoa, @TenKhoa)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaKhoa", k.MaKhoa);
                cmd.Parameters.AddWithValue("@TenKhoa", k.TenKhoa);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Sua(Khoa k)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "UPDATE Khoa SET TenKhoa=@TenKhoa WHERE MaKhoa=@MaKhoa";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaKhoa", k.MaKhoa);
                cmd.Parameters.AddWithValue("@TenKhoa", k.TenKhoa);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maKhoa)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "DELETE FROM Khoa WHERE MaKhoa=@MaKhoa";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<Khoa> TimKiem(string tuKhoa)
        {
            List<Khoa> list = new List<Khoa>();
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "SELECT * FROM Khoa WHERE MaKhoa LIKE @kw OR TenKhoa LIKE @kw";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + tuKhoa + "%");
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Khoa
                    {
                        MaKhoa = reader["MaKhoa"].ToString(),
                        TenKhoa = reader["TenKhoa"].ToString()
                    });
                }
            }
            return list;
        }
    }
}

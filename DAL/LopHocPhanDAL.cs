using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.DAL
{
    public class LopHocPhanDAL
    {
        private string connStr = "server=localhost;port=3306;database=QLDiemSinhVien;uid=root;pwd=;";

        public List<LopHocPhan> LayTatCa()
        {
            var ds = new List<LopHocPhan>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM LopHocPhan";
                var cmd = new MySqlCommand(sql, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new LopHocPhan
                    {
                        MaLHP = reader["MaLHP"].ToString(),
                        TenLHP = reader["TenLHP"].ToString(),
                        MaHP = reader["MaHP"].ToString(),
                        MaGV = reader["MaGV"].ToString()
                    });
                }
            }
            return ds;
        }

        public bool Them(LopHocPhan lhp)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "INSERT INTO LopHocPhan VALUES (@MaLHP, @TenLHP, @MaHP, @MaGV)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaLHP", lhp.MaLHP);
                cmd.Parameters.AddWithValue("@TenLHP", lhp.TenLHP);
                cmd.Parameters.AddWithValue("@MaHP", lhp.MaHP);
                cmd.Parameters.AddWithValue("@MaGV", lhp.MaGV);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Sua(LopHocPhan lhp)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = @"UPDATE LopHocPhan 
                           SET TenLHP=@TenLHP, MaHP=@MaHP, MaGV=@MaGV 
                           WHERE MaLHP=@MaLHP";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaLHP", lhp.MaLHP);
                cmd.Parameters.AddWithValue("@TenLHP", lhp.TenLHP);
                cmd.Parameters.AddWithValue("@MaHP", lhp.MaHP);
                cmd.Parameters.AddWithValue("@MaGV", lhp.MaGV);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maLHP)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "DELETE FROM LopHocPhan WHERE MaLHP = @MaLHP";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaLHP", maLHP);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<LopHocPhan> TimKiem(string tuKhoa)
        {
            var ds = new List<LopHocPhan>();
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "SELECT * FROM LopHocPhan WHERE MaLHP LIKE @kw OR TenLHP LIKE @kw";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kw", $"%{tuKhoa}%");
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new LopHocPhan
                    {
                        MaLHP = reader["MaLHP"].ToString(),
                        TenLHP = reader["TenLHP"].ToString(),
                        MaHP = reader["MaHP"].ToString(),
                        MaGV = reader["MaGV"].ToString()
                    });
                }
            }
            return ds;
        }
    }

}

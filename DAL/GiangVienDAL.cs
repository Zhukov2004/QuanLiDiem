using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.DAL
{
    public class GiangVienDAL
    {
        private string connStr = "server=localhost;port=3306;database=QLDiemSinhVien;uid=root;pwd=;";

        public List<GiangVien> LayTatCa()
        {
            List<GiangVien> ds = new List<GiangVien>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM GiangVien";
                var cmd = new MySqlCommand(sql, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new GiangVien
                    {
                        MaGV = reader["MaGV"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                        TrinhDo = reader["TrinhDo"].ToString(),
                        NgaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh"))
                                    ? DateTime.MinValue
                                    : reader.GetDateTime("NgaySinh"),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        BoMon = reader["BoMon"].ToString()
                    });
                }
            }
            return ds;
        }

        public bool Them(GiangVien gv)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "INSERT INTO GiangVien (MaGV, HoTen, TrinhDo, NgaySinh, GioiTinh, BoMon) VALUES (@MaGV, @HoTen, @TrinhDo, @NgaySinh, @GioiTinh, @BoMon)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaGV", gv.MaGV);
                cmd.Parameters.AddWithValue("@HoTen", gv.HoTen);
                cmd.Parameters.AddWithValue("@TrinhDo", gv.TrinhDo);
                cmd.Parameters.AddWithValue("@NgaySinh", gv.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", gv.GioiTinh);
                cmd.Parameters.AddWithValue("@BoMon", gv.BoMon);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Sua(GiangVien gv)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = @"UPDATE GiangVien 
                           SET HoTen=@HoTen, TrinhDo=@TrinhDo, NgaySinh=@NgaySinh, 
                               GioiTinh=@GioiTinh, BoMon=@BoMon 
                           WHERE MaGV=@MaGV";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaGV", gv.MaGV);
                cmd.Parameters.AddWithValue("@HoTen", gv.HoTen);
                cmd.Parameters.AddWithValue("@TrinhDo", gv.TrinhDo);
                cmd.Parameters.AddWithValue("@NgaySinh", gv.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", gv.GioiTinh);
                cmd.Parameters.AddWithValue("@BoMon", gv.BoMon);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maGV)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "DELETE FROM GiangVien WHERE MaGV = @MaGV";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaGV", maGV);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<GiangVien> TimKiem(string tuKhoa)
        {
            var ds = new List<GiangVien>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM GiangVien WHERE MaGV LIKE @kw OR HoTen LIKE @kw";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + tuKhoa + "%");
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new GiangVien
                    {
                        MaGV = reader["MaGV"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                        TrinhDo = reader["TrinhDo"].ToString(),
                        NgaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh"))
                                    ? DateTime.MinValue
                                    : reader.GetDateTime("NgaySinh"),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        BoMon = reader["BoMon"].ToString()
                    });
                }
            }
            return ds;
        }
    }
}

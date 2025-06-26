using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.DAL
{
    public class HocLaiDAL
    {
        private string connStr = "server=localhost;database=QLDiemSinhVien;uid=root;pwd=;";

        public List<HocLai> LayTatCa()
        {
            var ds = new List<HocLai>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM HocLai", conn);
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ds.Add(new HocLai
                    {
                        MaSV = rd["MaSV"].ToString(),
                        MaLHP = rd["MaLHP"].ToString(),
                        LyDo = rd["LyDo"].ToString(),
                        LanHoc = Convert.ToInt32(rd["LanHoc"]),
                        NgayDangKy = Convert.ToDateTime(rd["NgayDangKy"])
                    });
                }
            }
            return ds;
        }

        public bool Them(HocLai hl)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "INSERT INTO HocLai VALUES (@MaSV, @MaLHP, @LyDo, @LanHoc, @NgayDK)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", hl.MaSV);
                cmd.Parameters.AddWithValue("@MaLHP", hl.MaLHP);
                cmd.Parameters.AddWithValue("@LyDo", hl.LyDo);
                cmd.Parameters.AddWithValue("@LanHoc", hl.LanHoc);
                cmd.Parameters.AddWithValue("@NgayDK", hl.NgayDangKy);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Sua(HocLai hl)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "UPDATE HocLai SET LyDo=@LyDo, LanHoc=@LanHoc, NgayDangKy=@NgayDK WHERE MaSV=@MaSV AND MaLHP=@MaLHP";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", hl.MaSV);
                cmd.Parameters.AddWithValue("@MaLHP", hl.MaLHP);
                cmd.Parameters.AddWithValue("@LyDo", hl.LyDo);
                cmd.Parameters.AddWithValue("@LanHoc", hl.LanHoc);
                cmd.Parameters.AddWithValue("@NgayDK", hl.NgayDangKy);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maSV, string maLHP)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "DELETE FROM HocLai WHERE MaSV=@MaSV AND MaLHP=@MaLHP";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.Parameters.AddWithValue("@MaLHP", maLHP);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<HocLai> TimKiem(string tuKhoa)
        {
            var ds = new List<HocLai>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM HocLai WHERE MaSV LIKE @kw OR MaLHP LIKE @kw", conn);
                cmd.Parameters.AddWithValue("@kw", $"%{tuKhoa}%");
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ds.Add(new HocLai
                    {
                        MaSV = rd["MaSV"].ToString(),
                        MaLHP = rd["MaLHP"].ToString(),
                        LyDo = rd["LyDo"].ToString(),
                        LanHoc = Convert.ToInt32(rd["LanHoc"]),
                        NgayDangKy = Convert.ToDateTime(rd["NgayDangKy"])
                    });
                }
            }
            return ds;
        }
    }

}

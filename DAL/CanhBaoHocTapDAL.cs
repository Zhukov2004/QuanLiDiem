using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.DAL
{
    public class CanhBaoHocTapDAL
    {
        private string connStr = "server=localhost;port=3306;database=QLDiemSinhVien;uid=root;pwd=;";

        public List<CanhBaoHocTap> LayTatCa()
        {
            var ds = new List<CanhBaoHocTap>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = @"SELECT cb.MaSV, sv.HoTen, cb.NamHoc, cb.HocKy, cb.LyDo, cb.NgayCanhBao
                           FROM CanhBaoHocTap cb
                           JOIN SinhVien sv ON cb.MaSV = sv.MaSV";
                var cmd = new MySqlCommand(sql, conn);
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ds.Add(new CanhBaoHocTap
                    {
                        MaSV = rd["MaSV"].ToString(),
                        HoTen = rd["HoTen"].ToString(),
                        NamHoc = rd["NamHoc"].ToString(),
                        HocKy = rd["HocKy"].ToString(),
                        LyDo = rd["LyDo"].ToString(),
                        NgayCanhBao = Convert.ToDateTime(rd["NgayCanhBao"])
                    });
                }
            }
            return ds;
        }

        public bool Them(CanhBaoHocTap cb)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = @"INSERT INTO CanhBaoHocTap 
                           VALUES (@MaSV, @NamHoc, @HocKy, @LyDo, @Ngay)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", cb.MaSV);
                cmd.Parameters.AddWithValue("@NamHoc", cb.NamHoc);
                cmd.Parameters.AddWithValue("@HocKy", cb.HocKy);
                cmd.Parameters.AddWithValue("@LyDo", cb.LyDo);
                cmd.Parameters.AddWithValue("@Ngay", cb.NgayCanhBao);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Sua(CanhBaoHocTap cb)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = @"UPDATE CanhBaoHocTap SET 
                           LyDo=@LyDo, NgayCanhBao=@Ngay 
                           WHERE MaSV=@MaSV AND NamHoc=@NamHoc AND HocKy=@HocKy";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", cb.MaSV);
                cmd.Parameters.AddWithValue("@NamHoc", cb.NamHoc);
                cmd.Parameters.AddWithValue("@HocKy", cb.HocKy);
                cmd.Parameters.AddWithValue("@LyDo", cb.LyDo);
                cmd.Parameters.AddWithValue("@Ngay", cb.NgayCanhBao);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maSV, string namHoc, string hocKy)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = @"DELETE FROM CanhBaoHocTap 
                           WHERE MaSV=@MaSV AND NamHoc=@NamHoc AND HocKy=@HocKy";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.Parameters.AddWithValue("@NamHoc", namHoc);
                cmd.Parameters.AddWithValue("@HocKy", hocKy);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<CanhBaoHocTap> TimKiem(string kw)
        {
            var ds = new List<CanhBaoHocTap>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = @"SELECT cb.MaSV, sv.HoTen, cb.NamHoc, cb.HocKy, cb.LyDo, cb.NgayCanhBao
                           FROM CanhBaoHocTap cb
                           JOIN SinhVien sv ON cb.MaSV = sv.MaSV
                           WHERE cb.MaSV LIKE @kw OR sv.HoTen LIKE @kw";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kw", $"%{kw}%");
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ds.Add(new CanhBaoHocTap
                    {
                        MaSV = rd["MaSV"].ToString(),
                        HoTen = rd["HoTen"].ToString(),
                        NamHoc = rd["NamHoc"].ToString(),
                        HocKy = rd["HocKy"].ToString(),
                        LyDo = rd["LyDo"].ToString(),
                        NgayCanhBao = Convert.ToDateTime(rd["NgayCanhBao"])
                    });
                }
            }
            return ds;
        }
    }



}

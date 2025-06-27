using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.DAL
{
    public class TotNghiepDAL
    {
        private string connStr = "server=localhost;port=3306;database=QLDiemSinhVien;uid=root;pwd=;";

        public List<TotNghiep> LayTatCa()
        {
            var ds = new List<TotNghiep>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = @"SELECT tn.MaSV, sv.HoTen, tn.NgayTotNghiep, tn.XepLoai
                           FROM TotNghiep tn
                           JOIN SinhVien sv ON tn.MaSV = sv.MaSV";
                var cmd = new MySqlCommand(sql, conn);
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ds.Add(new TotNghiep
                    {
                        MaSV = rd["MaSV"].ToString(),
                        HoTen = rd["HoTen"].ToString(),
                        NgayTotNghiep = Convert.ToDateTime(rd["NgayTotNghiep"]),
                        XepLoai = rd["XepLoai"].ToString()
                    });
                }
            }
            return ds;
        }

        public bool Them(TotNghiep tn)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "INSERT INTO TotNghiep VALUES (@MaSV, @Ngay, @XepLoai)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", tn.MaSV);
                cmd.Parameters.AddWithValue("@Ngay", tn.NgayTotNghiep);
                cmd.Parameters.AddWithValue("@XepLoai", tn.XepLoai);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Sua(TotNghiep tn)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "UPDATE TotNghiep SET NgayTotNghiep=@Ngay, XepLoai=@XepLoai WHERE MaSV=@MaSV";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", tn.MaSV);
                cmd.Parameters.AddWithValue("@Ngay", tn.NgayTotNghiep);
                cmd.Parameters.AddWithValue("@XepLoai", tn.XepLoai);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maSV)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                var cmd = new MySqlCommand("DELETE FROM TotNghiep WHERE MaSV=@MaSV", conn);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<TotNghiep> TimKiem(string kw)
        {
            var ds = new List<TotNghiep>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = @"SELECT tn.MaSV, sv.HoTen, tn.NgayTotNghiep, tn.XepLoai
                           FROM TotNghiep tn
                           JOIN SinhVien sv ON tn.MaSV = sv.MaSV
                           WHERE tn.MaSV LIKE @kw OR sv.HoTen LIKE @kw";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kw", $"%{kw}%");
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ds.Add(new TotNghiep
                    {
                        MaSV = rd["MaSV"].ToString(),
                        HoTen = rd["HoTen"].ToString(),
                        NgayTotNghiep = Convert.ToDateTime(rd["NgayTotNghiep"]),
                        XepLoai = rd["XepLoai"].ToString()
                    });
                }
            }
            return ds;
        }
    }

}

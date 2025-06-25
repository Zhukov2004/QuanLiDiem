using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.DAL
{
    public class HocPhanDAL
    {
        private string connStr = "server=localhost;port=3306;database=QLDiemSinhVien;uid=root;pwd=;";

        public List<HocPhan> LayTatCa()
        {
            var ds = new List<HocPhan>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM HocPhan";
                var cmd = new MySqlCommand(sql, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new HocPhan
                    {
                        MaHP = reader["MaHP"].ToString(),
                        TenHP = reader["TenHP"].ToString(),
                        SoTinChi = Convert.ToInt32(reader["SoTinChi"]),
                        HocKy = Convert.ToInt32(reader["HocKy"]),
                        MaNganh = reader["MaNganh"].ToString()
                    });
                }
            }
            return ds;
        }

        public bool Them(HocPhan hp)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "INSERT INTO HocPhan VALUES (@MaHP, @TenHP, @SoTinChi, @HocKy, @MaNganh)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaHP", hp.MaHP);
                cmd.Parameters.AddWithValue("@TenHP", hp.TenHP);
                cmd.Parameters.AddWithValue("@SoTinChi", hp.SoTinChi);
                cmd.Parameters.AddWithValue("@HocKy", hp.HocKy);
                cmd.Parameters.AddWithValue("@MaNganh", hp.MaNganh);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Sua(HocPhan hp)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "UPDATE HocPhan SET TenHP=@TenHP, SoTinChi=@SoTinChi, HocKy=@HocKy, MaNganh=@MaNganh WHERE MaHP=@MaHP";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaHP", hp.MaHP);
                cmd.Parameters.AddWithValue("@TenHP", hp.TenHP);
                cmd.Parameters.AddWithValue("@SoTinChi", hp.SoTinChi);
                cmd.Parameters.AddWithValue("@HocKy", hp.HocKy);
                cmd.Parameters.AddWithValue("@MaNganh", hp.MaNganh);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maHP)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "DELETE FROM HocPhan WHERE MaHP = @MaHP";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaHP", maHP);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<HocPhan> TimKiem(string tuKhoa)
        {
            var ds = new List<HocPhan>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM HocPhan WHERE MaHP LIKE @kw OR TenHP LIKE @kw";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kw", $"%{tuKhoa}%");
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new HocPhan
                    {
                        MaHP = reader["MaHP"].ToString(),
                        TenHP = reader["TenHP"].ToString(),
                        SoTinChi = Convert.ToInt32(reader["SoTinChi"]),
                        HocKy = Convert.ToInt32(reader["HocKy"]),
                        MaNganh = reader["MaNganh"].ToString()
                    });
                }
            }
            return ds;
        }
    }

}

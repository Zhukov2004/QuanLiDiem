using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.DAL
{
    public class DangKyHocPhanDAL
    {
        private string connStr = "server=localhost;port=3306;database=QLDiemSinhVien;uid=root;pwd=;";

        public List<DangKyHocPhan> LayTatCa()
        {
            var ds = new List<DangKyHocPhan>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM DangKyHocPhan", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new DangKyHocPhan
                    {
                        MaSV = reader["MaSV"].ToString(),
                        MaLHP = reader["MaLHP"].ToString(),
                        HocKy = reader["HocKy"].ToString(),
                        NamHoc = reader["NamHoc"].ToString()
                    });
                }
            }
            return ds;
        }

        public bool DangKy(DangKyHocPhan dk)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "INSERT INTO DangKyHocPhan VALUES (@MaSV, @MaLHP, @HocKy, @NamHoc)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", dk.MaSV);
                cmd.Parameters.AddWithValue("@MaLHP", dk.MaLHP);
                cmd.Parameters.AddWithValue("@HocKy", dk.HocKy);
                cmd.Parameters.AddWithValue("@NamHoc", dk.NamHoc);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Huy(string maSV, string maLHP)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "DELETE FROM DangKyHocPhan WHERE MaSV=@MaSV AND MaLHP=@MaLHP";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.Parameters.AddWithValue("@MaLHP", maLHP);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<DangKyHocPhan> TimKiemTheoSinhVien(string maSV)
        {
            var ds = new List<DangKyHocPhan>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM DangKyHocPhan WHERE MaSV = @MaSV", conn);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new DangKyHocPhan
                    {
                        MaSV = reader["MaSV"].ToString(),
                        MaLHP = reader["MaLHP"].ToString(),
                        HocKy = reader["HocKy"].ToString(),
                        NamHoc = reader["NamHoc"].ToString()
                    });
                }
            }
            return ds;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.DAL
{
    public class LopDAL
    {
        private string connStr = "server=localhost;port=3306;database=QLDiemSinhVien;uid=root;pwd=;";

        public List<Lop> LayTatCa()
        {
            var ds = new List<Lop>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Lop";
                var cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ds.Add(new Lop
                        {
                            MaLop = reader["MaLop"].ToString(),
                            TenLop = reader["TenLop"].ToString(),
                            CoVanHocTap = reader["CoVanHocTap"].ToString()
                        });
                    }
                }
            }
            return ds;
        }
        public List<Lop> TimKiem(string tuKhoa)
        {
            var ds = new List<Lop>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Lop WHERE MaLop LIKE @kw OR TenLop LIKE @kw";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + tuKhoa + "%");
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new Lop
                    {
                        MaLop = reader["MaLop"].ToString(),
                        TenLop = reader["TenLop"].ToString(),
                        CoVanHocTap = reader["CoVanHocTap"].ToString()
                    });
                }
            }
            return ds;
        }

        public bool Them(Lop lop)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "INSERT INTO Lop VALUES (@MaLop, @TenLop, @CoVan)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
                cmd.Parameters.AddWithValue("@TenLop", lop.TenLop);
                cmd.Parameters.AddWithValue("@CoVan", lop.CoVanHocTap);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Sua(Lop lop)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "UPDATE Lop SET TenLop=@TenLop, CoVanHocTap=@CoVan WHERE MaLop=@MaLop";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
                cmd.Parameters.AddWithValue("@TenLop", lop.TenLop);
                cmd.Parameters.AddWithValue("@CoVan", lop.CoVanHocTap);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maLop)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "DELETE FROM Lop WHERE MaLop=@MaLop";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaLop", maLop);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}

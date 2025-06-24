using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.DAL
{
    using System.Collections.Generic;
    using MySql.Data.MySqlClient;
    using System;

    public class SinhVienDAL
    {
        private string connStr = "server=localhost;port=3306;database=QLDiemSinhVien;uid=root;pwd=;";

        public List<SinhVien> LayTatCa()
        {
            List<SinhVien> list = new List<SinhVien>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM SinhVien";
                using (var cmd = new MySqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SinhVien
                        {
                            MaSV = reader["MaSV"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                            NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                            GioiTinh = reader["GioiTinh"].ToString(),
                            QueQuan = reader["QueQuan"].ToString(),
                            CheDoUuTien = reader["CheDoUuTien"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(SinhVien sv)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "INSERT INTO SinhVien VALUES (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @QueQuan, @CheDoUuTien)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", sv.MaSV);
                cmd.Parameters.AddWithValue("@HoTen", sv.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", sv.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", sv.GioiTinh);
                cmd.Parameters.AddWithValue("@QueQuan", sv.QueQuan);
                cmd.Parameters.AddWithValue("@CheDoUuTien", sv.CheDoUuTien);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Sua(SinhVien sv)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = @"UPDATE SinhVien 
                           SET HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, 
                               QueQuan=@QueQuan, CheDoUuTien=@CheDoUuTien 
                           WHERE MaSV=@MaSV";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", sv.MaSV);
                cmd.Parameters.AddWithValue("@HoTen", sv.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", sv.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", sv.GioiTinh);
                cmd.Parameters.AddWithValue("@QueQuan", sv.QueQuan);
                cmd.Parameters.AddWithValue("@CheDoUuTien", sv.CheDoUuTien);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maSV)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "DELETE FROM SinhVien WHERE MaSV = @MaSV";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<SinhVien> TimKiem(string tukhoa)
        {
            List<SinhVien> list = new List<SinhVien>();
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "SELECT * FROM SinhVien WHERE MaSV LIKE @kw OR HoTen LIKE @kw";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + tukhoa + "%");
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new SinhVien
                    {
                        MaSV = reader["MaSV"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                        NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        QueQuan = reader["QueQuan"].ToString(),
                        CheDoUuTien = reader["CheDoUuTien"].ToString()
                    });
                }
            }
            return list;
        }
    }


}

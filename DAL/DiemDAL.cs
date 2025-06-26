using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.DAL
{
    public class DiemDAL
    {
        private string connStr = "server=localhost;port=3306;database=QLDiemSinhVien;uid=root;pwd=;";

        public List<Diem> LayTatCa()
        {
            var ds = new List<Diem>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Diem";
                var cmd = new MySqlCommand(sql, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new Diem
                    {
                        MaSV = reader["MaSV"].ToString(),
                        MaLHP = reader["MaLHP"].ToString(),
                        DiemThi = Convert.ToDecimal(reader["DiemThi"]),
                        DiemTBHK = Convert.ToDecimal(reader["DiemTBHK"]),
                        XepLoai = reader["XepLoai"].ToString(),
                        DuocXetHocBong = Convert.ToBoolean(reader["DuocXetHocBong"])
                    });
                }
            }
            return ds;
        }

        public bool Them(Diem d)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "INSERT INTO Diem VALUES (@MaSV, @MaLHP, @DiemThi, @DiemTBHK, @XepLoai, @Duoc)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", d.MaSV);
                cmd.Parameters.AddWithValue("@MaLHP", d.MaLHP);
                cmd.Parameters.AddWithValue("@DiemThi", d.DiemThi);
                cmd.Parameters.AddWithValue("@DiemTBHK", d.DiemTBHK);
                cmd.Parameters.AddWithValue("@XepLoai", d.XepLoai);
                cmd.Parameters.AddWithValue("@Duoc", d.DuocXetHocBong);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Sua(Diem d)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = @"UPDATE Diem SET DiemThi=@DiemThi, DiemTBHK=@DiemTBHK, 
                           XepLoai=@XepLoai, DuocXetHocBong=@Duoc 
                           WHERE MaSV=@MaSV AND MaLHP=@MaLHP";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", d.MaSV);
                cmd.Parameters.AddWithValue("@MaLHP", d.MaLHP);
                cmd.Parameters.AddWithValue("@DiemThi", d.DiemThi);
                cmd.Parameters.AddWithValue("@DiemTBHK", d.DiemTBHK);
                cmd.Parameters.AddWithValue("@XepLoai", d.XepLoai);
                cmd.Parameters.AddWithValue("@Duoc", d.DuocXetHocBong);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maSV, string maLHP)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "DELETE FROM Diem WHERE MaSV=@MaSV AND MaLHP=@MaLHP";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.Parameters.AddWithValue("@MaLHP", maLHP);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<Diem> TimKiem(string tuKhoa)
        {
            var ds = new List<Diem>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Diem WHERE MaSV LIKE @kw OR MaLHP LIKE @kw";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kw", $"%{tuKhoa}%");
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new Diem
                    {
                        MaSV = reader["MaSV"].ToString(),
                        MaLHP = reader["MaLHP"].ToString(),
                        DiemThi = Convert.ToDecimal(reader["DiemThi"]),
                        DiemTBHK = Convert.ToDecimal(reader["DiemTBHK"]),
                        XepLoai = reader["XepLoai"].ToString(),
                        DuocXetHocBong = Convert.ToBoolean(reader["DuocXetHocBong"])
                    });
                }
            }
            return ds;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.DAL
{
    public class NganhDAL
    {
        private string connStr = "server=localhost;port=3306;database=QLDiemSinhVien;uid=root;pwd=;";

        public List<Nganh> LayTatCa()
        {
            List<Nganh> list = new List<Nganh>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Nganh";
                var cmd = new MySqlCommand(sql, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Nganh
                    {
                        MaNganh = reader["MaNganh"].ToString(),
                        TenNganh = reader["TenNganh"].ToString()
                    });
                }
            }
            return list;
        }

        public bool Them(Nganh ng)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "INSERT INTO Nganh VALUES (@Ma, @Ten)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma", ng.MaNganh);
                cmd.Parameters.AddWithValue("@Ten", ng.TenNganh);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Sua(Nganh ng)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "UPDATE Nganh SET TenNganh=@Ten WHERE MaNganh=@Ma";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ten", ng.TenNganh);
                cmd.Parameters.AddWithValue("@Ma", ng.MaNganh);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maNganh)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "DELETE FROM Nganh WHERE MaNganh=@Ma";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma", maNganh);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<Nganh> TimKiem(string tuKhoa)
        {
            List<Nganh> list = new List<Nganh>();
            using (var conn = new MySqlConnection(connStr))
            {
                string sql = "SELECT * FROM Nganh WHERE MaNganh LIKE @kw OR TenNganh LIKE @kw";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + tuKhoa + "%");
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Nganh
                    {
                        MaNganh = reader["MaNganh"].ToString(),
                        TenNganh = reader["TenNganh"].ToString()
                    });
                }
            }
            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuanLiDiemDaiHoc.Controllers
{
    internal class DangKyController
    {
        private string connStr = "server=localhost;port=3306;database=QLDiemSinhVien;uid=root;pwd=;";

        public List<dynamic> LayThongTinSinhVienHocPhan()
        {
            var ds = new List<dynamic>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand(@"
            SELECT sv.MaSV, sv.HoTen, mh.MaHP, mh.TenHP
            FROM DangKy dk
            JOIN SinhVien sv ON dk.MaSV = sv.MaSV
            JOIN MonHoc mh ON dk.MaHP = mh.MaHP", conn);

                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ds.Add(new
                    {
                        MaSV = rd["MaSV"].ToString(),
                        HoTen = rd["HoTen"].ToString(),
                        MaHP = rd["MaHP"].ToString(),
                        TenHP = rd["TenHP"].ToString()
                    });
                }
            }
            return ds;
        }

    }
}

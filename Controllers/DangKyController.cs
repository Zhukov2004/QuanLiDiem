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
        SELECT sv.MaSV, sv.HoTen, hp.MaHP, hp.TenHP, dk.HocKy, dk.NamHoc
        FROM DangKyHocPhan dk
        JOIN SinhVien sv ON dk.MaSV = sv.MaSV
        JOIN LopHocPhan lhp ON dk.MaLHP = lhp.MaLHP
        JOIN HocPhan hp ON lhp.MaHP = hp.MaHP", conn);

                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ds.Add(new
                    {
                        MaSV = rd["MaSV"].ToString(),
                        HoTen = rd["HoTen"].ToString(),
                        MaHP = rd["MaHP"].ToString(),
                        TenHP = rd["TenHP"].ToString(),
                        HocKy = rd["HocKy"].ToString(),
                        NamHoc = rd["NamHoc"].ToString()
                    });
                }
            }
            return ds;

        }

    }
}

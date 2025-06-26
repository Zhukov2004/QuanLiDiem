using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiDiemDaiHoc.DAL;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.Controllers
{
    public class DangKyHocPhanController
    {
        DangKyHocPhanDAL dal = new DangKyHocPhanDAL();

        public List<DangKyHocPhan> LayDanhSach() => dal.LayTatCa();
        public bool DangKy(DangKyHocPhan dk) => dal.DangKy(dk);
        public bool Huy(string maSV, string maLHP) => dal.Huy(maSV, maLHP);
        public List<DangKyHocPhan> TimTheoSinhVien(string maSV) => dal.TimKiemTheoSinhVien(maSV);
    }

}

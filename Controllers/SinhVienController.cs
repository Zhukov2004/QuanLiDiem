using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiDiemDaiHoc.DAL;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.Controllers
{
    public class SinhVienController
    {
        SinhVienDAL dal = new SinhVienDAL();

        public List<SinhVien> LayDanhSach() => dal.LayTatCa();

        public bool Them(SinhVien sv) => dal.Them(sv);

        public bool Sua(SinhVien sv) => dal.Sua(sv);

        public bool Xoa(string maSV) => dal.Xoa(maSV);

        public List<SinhVien> TimKiem(string tuKhoa) => dal.TimKiem(tuKhoa);
    }

}

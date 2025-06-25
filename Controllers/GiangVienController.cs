using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiDiemDaiHoc.DAL;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.Controllers
{
    public class GiangVienController
    {
        private GiangVienDAL dal = new GiangVienDAL();

        public List<GiangVien> LayDanhSach() => dal.LayTatCa();
        public bool Them(GiangVien gv) => dal.Them(gv);
        public bool Sua(GiangVien gv) => dal.Sua(gv);
        public bool Xoa(string maGV) => dal.Xoa(maGV);
        public List<GiangVien> TimKiem(string tuKhoa) => dal.TimKiem(tuKhoa);
    }

}

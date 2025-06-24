using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiDiemDaiHoc.DAL;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.Controllers
{
    public class KhoaController
    {
        private KhoaDAL dal = new KhoaDAL();

        public List<Khoa> LayDanhSach() => dal.LayTatCa();
        public bool Them(Khoa k) => dal.Them(k);
        public bool Sua(Khoa k) => dal.Sua(k);
        public bool Xoa(string maKhoa) => dal.Xoa(maKhoa);
        public List<Khoa> TimKiem(string tuKhoa) => dal.TimKiem(tuKhoa);
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiDiemDaiHoc.DAL;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.Controllers
{
    public class LopController
    {
        private LopDAL dal = new LopDAL();

        public List<Lop> LayDanhSach() => dal.LayTatCa();
        public bool Them(Lop lop) => dal.Them(lop);
        public bool Sua(Lop lop) => dal.Sua(lop);
        public bool Xoa(string maLop) => dal.Xoa(maLop);
        public List<Lop> TimKiem(string tuKhoa) => dal.TimKiem(tuKhoa);

    }

}

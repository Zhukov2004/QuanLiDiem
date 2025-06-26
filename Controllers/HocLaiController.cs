using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiDiemDaiHoc.DAL;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.Controllers
{
    public class HocLaiController
    {
        private HocLaiDAL dal = new HocLaiDAL();

        public List<HocLai> LayDanhSach() => dal.LayTatCa();
        public bool Them(HocLai hl) => dal.Them(hl);
        public bool Sua(HocLai hl) => dal.Sua(hl);
        public bool Xoa(string maSV, string maLHP) => dal.Xoa(maSV, maLHP);
        public List<HocLai> TimKiem(string kw) => dal.TimKiem(kw);
    }

}

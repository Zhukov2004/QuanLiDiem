using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiDiemDaiHoc.DAL;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.Controllers
{
    public class LopHocPhanController
    {
        LopHocPhanDAL dal = new LopHocPhanDAL();

        public List<LopHocPhan> LayDanhSach() => dal.LayTatCa();
        public bool Them(LopHocPhan lhp) => dal.Them(lhp);
        public bool Sua(LopHocPhan lhp) => dal.Sua(lhp);
        public bool Xoa(string maLHP) => dal.Xoa(maLHP);
        public List<LopHocPhan> TimKiem(string kw) => dal.TimKiem(kw);
    }

}

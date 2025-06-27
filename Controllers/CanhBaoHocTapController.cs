using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiDiemDaiHoc.DAL;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.Controllers
{
    public class CanhBaoHocTapController
    {
        private CanhBaoHocTapDAL dal = new CanhBaoHocTapDAL();

        public List<CanhBaoHocTap> LayDanhSach() => dal.LayTatCa();
        public bool Them(CanhBaoHocTap cb) => dal.Them(cb);
        public bool Sua(CanhBaoHocTap cb) => dal.Sua(cb);
        public bool Xoa(string maSV, string namHoc, string hocKy) => dal.Xoa(maSV, namHoc, hocKy);
        public List<CanhBaoHocTap> TimKiem(string kw) => dal.TimKiem(kw);
    }


}

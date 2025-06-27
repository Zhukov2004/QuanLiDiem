using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiDiemDaiHoc.DAL;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.Controllers
{
    public class TotNghiepController
    {
        private TotNghiepDAL dal = new TotNghiepDAL();

        public List<TotNghiep> LayDanhSach() => dal.LayTatCa();
        public bool Them(TotNghiep tn) => dal.Them(tn);
        public bool Sua(TotNghiep tn) => dal.Sua(tn);
        public bool Xoa(string maSV) => dal.Xoa(maSV);
        public List<TotNghiep> TimKiem(string kw) => dal.TimKiem(kw);
    }

}

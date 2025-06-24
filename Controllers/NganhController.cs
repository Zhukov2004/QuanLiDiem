using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiDiemDaiHoc.DAL;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.Controllers
{
    public class NganhController
    {
        private NganhDAL dal = new NganhDAL();

        public List<Nganh> LayDanhSach() => dal.LayTatCa();
        public bool Them(Nganh ng) => dal.Them(ng);
        public bool Sua(Nganh ng) => dal.Sua(ng);
        public bool Xoa(string maNganh) => dal.Xoa(maNganh);
        public List<Nganh> TimKiem(string tuKhoa) => dal.TimKiem(tuKhoa);
    }

}

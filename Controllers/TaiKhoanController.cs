using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiDiemDaiHoc.DAL;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.Controllers
{
    public class TaiKhoanController
    {
        TaiKhoanDAL dal = new TaiKhoanDAL();

        public List<TaiKhoan> LayDanhSach() => dal.LayTatCa();
        public bool Them(TaiKhoan tk) => dal.Them(tk);
        public bool Sua(TaiKhoan tk) => dal.Sua(tk);
        public bool Xoa(string tenDN) => dal.Xoa(tenDN);
        public List<TaiKhoan> TimKiem(string tuKhoa) => dal.TimKiem(tuKhoa);
    }
}

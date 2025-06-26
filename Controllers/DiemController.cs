using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiDiemDaiHoc.DAL;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.Controllers
{
    public class DiemController
    {
        private DiemDAL dal = new DiemDAL();

        public List<Diem> LayDanhSach() => dal.LayTatCa();
        public bool Them(Diem d) => dal.Them(d);
        public bool Sua(Diem d) => dal.Sua(d);
        public bool Xoa(string maSV, string maLHP) => dal.Xoa(maSV, maLHP);
        public List<Diem> TimKiem(string tuKhoa) => dal.TimKiem(tuKhoa);
    }

}

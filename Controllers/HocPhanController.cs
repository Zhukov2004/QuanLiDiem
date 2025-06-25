using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiDiemDaiHoc.DAL;
using QuanLiDiemDaiHoc.Models;

namespace QuanLiDiemDaiHoc.Controllers
{
    public class HocPhanController
    {
        private HocPhanDAL dal = new HocPhanDAL();

        public List<HocPhan> LayDanhSach()
        {
            return dal.LayTatCa();
        }

        public bool Them(HocPhan hp)
        {
            return dal.Them(hp);
        }

        public bool Sua(HocPhan hp)
        {
            return dal.Sua(hp);
        }

        public bool Xoa(string maHP)
        {
            return dal.Xoa(maHP);
        }

        public List<HocPhan> TimKiem(string tuKhoa)
        {
            return dal.TimKiem(tuKhoa);
        }
    }
}

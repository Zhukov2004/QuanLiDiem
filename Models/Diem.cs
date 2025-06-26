using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDiemDaiHoc.Models
{
    public class Diem
    {
        public string MaSV { get; set; }
        public string MaLHP { get; set; }
        public decimal DiemThi { get; set; }
        public decimal DiemTBHK { get; set; }
        public string XepLoai { get; set; }
        public bool DuocXetHocBong { get; set; }
    }

}

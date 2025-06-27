using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDiemDaiHoc.Models
{
    public class TotNghiep
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }  // từ JOIN bảng SinhVien
        public DateTime NgayTotNghiep { get; set; }
        public string XepLoai { get; set; }
    }

}

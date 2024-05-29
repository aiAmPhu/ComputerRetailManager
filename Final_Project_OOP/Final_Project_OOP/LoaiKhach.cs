using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_OOP
{
    public class LoaiKhach
    {
        public string idmaLoaiKH { get; set; }
        public string phanloaiKH { get; set; }
        public string motaChiTietLoaiKH { get; set; }
        public LoaiKhach(LoaiKhach LK)
        {
            this.idmaLoaiKH = LK.idmaLoaiKH;
            this.phanloaiKH= LK.phanloaiKH;
            this.motaChiTietLoaiKH = LK.motaChiTietLoaiKH;
        }
        public LoaiKhach(string idmaLoaiKH, string phanloaiKH, string motaChiTietLoaiKH)
        {
            this.idmaLoaiKH = idmaLoaiKH;
            this.phanloaiKH = phanloaiKH;
            this.motaChiTietLoaiKH = motaChiTietLoaiKH;
        }
        //
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_OOP
{
    public class LoaiPhong
    {
        public string idmaLoaiPhong { get; set; }
        public string phanloaiPhong { get; set; }
        public string motaChiTietLoaiPhong { get; set; }
        public LoaiPhong(LoaiPhong phong)
        {
            this.idmaLoaiPhong = phong.idmaLoaiPhong;
            this.phanloaiPhong= phong.phanloaiPhong;
            this.motaChiTietLoaiPhong = phong.motaChiTietLoaiPhong;
        }
        public LoaiPhong(string idmaLoaiPhong, string phanloaiPhong, string motaChiTietLoaiPhong)
        {
            this.idmaLoaiPhong = idmaLoaiPhong;
            this.phanloaiPhong = phanloaiPhong;
            this.motaChiTietLoaiPhong = motaChiTietLoaiPhong;
        }
    }
}

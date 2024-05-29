using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_OOP
{
    public class ChiTietHoaDon
    {
        public HoaDon idmaHD { get; set; }
        public DichVu idmaDV { get; set; }
        //public string thoiGian { get; set; }
        public ChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            this.idmaHD = chiTietHoaDon.idmaHD;
            this.idmaDV = chiTietHoaDon.idmaDV;
            //this.thoiGian = chiTietHoaDon.thoiGian;
        }
        public ChiTietHoaDon(HoaDon idmaHD, DichVu idmaDV)
        {
            this.idmaHD = idmaHD;
            this.idmaDV = idmaDV;
            //this.thoiGian = thoiGian;
        }
    }
}

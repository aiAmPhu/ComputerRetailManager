using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_OOP
{
    public class LoaiMayTinh
    {
        public string maLoaiMayTinh { get; set; }
        public string tenLoaiMayTinh { get; set; }
        public string motaChiTietLoaiMay { get; set; }
        public string giaThue { get; set; }
        public LoaiMayTinh(LoaiMayTinh loaiMayTinh)
        {
            this.maLoaiMayTinh = loaiMayTinh.maLoaiMayTinh;
            this.tenLoaiMayTinh = loaiMayTinh.tenLoaiMayTinh;
            this.motaChiTietLoaiMay = loaiMayTinh.motaChiTietLoaiMay;
            this.giaThue = loaiMayTinh.giaThue;
        }
        public LoaiMayTinh(string maLoaiMayTinh, string tenLoaiMayTinh, string motaChiTietLoaiMay, string giaThue)
        {
            this.maLoaiMayTinh = maLoaiMayTinh;
            this.tenLoaiMayTinh = tenLoaiMayTinh;
            this.motaChiTietLoaiMay = motaChiTietLoaiMay;
            this.giaThue = giaThue;
        }
    }
}

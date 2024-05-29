using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_OOP
{
    public class MayTinh
    {
        public string idmaMayTinh { get; set; }
        public int soMay { get; set; }
        public string tenMayTinh { get; set; }
        public string thuongHieu { get; set; }
        public LoaiMayTinh maLoaiMayTinh { get; set; }
        public Phong maPhong { get; set; } 
        public MayTinh(MayTinh mayTinh)
        {
            this.idmaMayTinh = mayTinh.idmaMayTinh;
            this.soMay=mayTinh.soMay;
            this.tenMayTinh = mayTinh.tenMayTinh;
            this.thuongHieu = mayTinh.thuongHieu;
            this.maLoaiMayTinh = mayTinh.maLoaiMayTinh;
            this.maPhong=mayTinh.maPhong;
        }
        public MayTinh(string idmaMayTinh, int soMay, string tenMayTinh, string thuongHieu, LoaiMayTinh maLoaiMayTinh, Phong maPhong)
        {
            this.idmaMayTinh = idmaMayTinh;
            this.soMay = soMay;
            this.tenMayTinh = tenMayTinh;
            this.thuongHieu = thuongHieu;
            this.maLoaiMayTinh = maLoaiMayTinh;
            this.maPhong=maPhong;  
        }
    }
}

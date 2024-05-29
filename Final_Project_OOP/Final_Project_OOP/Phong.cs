using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_OOP
{
    public class Phong
    {
        public string idmaPhong { get; set; }
        public string soPhong { get; set; }
        public Tang idmaTang { get; set; }
        public LoaiPhong idmaLoaiPhong { get; set; }
        //public LoaiMayTinh idmaLoaiMayTinh { get; set; }
        public Phong(Phong phong)
        {
            this.idmaPhong = phong.idmaPhong;
            this.soPhong=phong.soPhong;
            this.idmaLoaiPhong = phong.idmaLoaiPhong;
            this.idmaTang = phong.idmaTang;
            //this.idmaLoaiMayTinh = phong.idmaLoaiMayTinh;
        }
        public Phong(string idmaPhong, string soPhong, Tang idmaTang, LoaiPhong idmaLoaiPhong) //LoaiMayTinh idmaLoaiMayTinh)
        {
            this.idmaPhong =idmaPhong;
            this.soPhong = soPhong;
            this.idmaLoaiPhong = idmaLoaiPhong;
            this.idmaTang= idmaTang;
            //this.idmaLoaiMayTinh = idmaLoaiMayTinh;
        }
    }
}

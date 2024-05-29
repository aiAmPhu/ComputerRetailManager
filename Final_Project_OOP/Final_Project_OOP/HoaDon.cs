using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_OOP
{
    public class HoaDon
    {
        public string idmaHD { get; set; }
        public string thoigian { get; set; }
        public int soGioThue { get; set; }
        public Khach idmaKH { get; set; }
        public MayTinh idmaMayTinh { get; set; }
        //public Phong idmaPhong { get; set; }
        public DichVu idmaDV { get; set; }
        public NhanVien idmaNV { get; set; }  
        //public HoaDon() { }
        public HoaDon(HoaDon hd)
        {
            this.idmaHD = hd.idmaHD;
            this.thoigian= hd.thoigian;
            this.soGioThue= hd.soGioThue;
            this.idmaKH= hd.idmaKH;
            this.idmaMayTinh= hd.idmaMayTinh;
           // this.idmaPhong= hd.idmaPhong;
            this.idmaDV= hd.idmaDV;
            this.idmaNV= hd.idmaNV;
        }
        public HoaDon(string idmaHD, string thoigian, int soGioThue, Khach idmaKH, MayTinh idmaMayTinh, DichVu idmaDV, NhanVien idmaNV)
        {
            this.idmaHD = idmaHD;
            this.thoigian = thoigian;
            this.soGioThue = soGioThue;
            this.idmaKH = idmaKH;
            this.idmaMayTinh = idmaMayTinh;
            //this.idmaPhong = idmaPhong;
            this.idmaDV = idmaDV;
            this.idmaNV = idmaNV;
        }
        //
    }
}

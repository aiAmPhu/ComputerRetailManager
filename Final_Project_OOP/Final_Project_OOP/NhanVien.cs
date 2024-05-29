using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_OOP
{
    public class NhanVien
    {
        public string idmaNV { get; set; }
        public string tenNV { get; set; }
        public int tuoi { get; set; }
        public string soDT { get; set; }
        public string phanLoaiNV { get; set; }
        public NhanVien(NhanVien nhanVien)
        {
            this.idmaNV= nhanVien.idmaNV;  
            this.tenNV= nhanVien.tenNV;
            this.tuoi= nhanVien.tuoi;
            this.soDT= nhanVien.soDT;
            this.phanLoaiNV= nhanVien.phanLoaiNV;
        }
        public NhanVien(string idmaNV, string tenNV, int tuoi, string soDT, string phanLoaiNV)
        {
            this.idmaNV = idmaNV;
            this.tenNV = tenNV;
            this.tuoi = tuoi;
            this.soDT = soDT;
            this.phanLoaiNV = phanLoaiNV;
        }
    }
}

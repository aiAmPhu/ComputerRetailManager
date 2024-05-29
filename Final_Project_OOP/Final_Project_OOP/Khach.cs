using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_OOP
{
    public class Khach
    {
        public string idmaKH { get; set; }//PK
        public string tenKH { get; set; }
        public int tuoi { get; set; }
        public string diaChi { get; set; }
        public string soDT { get; set; }
        public LoaiKhach idmaLoaiKH { get; set; }//Fk
        public Khach(Khach khach)
        {
            this.idmaKH = khach.idmaKH;
            this.tenKH = khach.tenKH;
            this.tuoi = khach.tuoi;
            this.diaChi = khach.diaChi;
            this.soDT = khach.soDT;
            this.idmaLoaiKH = khach.idmaLoaiKH;
        }
        public Khach(string idmaKH, string tenKH, int tuoi, string diaChi, string soDT, LoaiKhach idmaLoaiKH)
        {
            this.idmaKH = idmaKH;
            this.tenKH = tenKH;
            this.tuoi = tuoi;
            this.diaChi = diaChi;
            this.soDT = soDT;
            this.idmaLoaiKH = idmaLoaiKH;
        }
        //public Khach khach { get; set; }
        //
    }
}

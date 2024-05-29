using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_OOP
{
    public class DichVu
    {
        public string idmaDV { get; set; }
        public string tenDV { get; set; }
        public LoaiDichVu idmaLoaiDV { get; set; }
        //public DichVu() { }
        public DichVu (DichVu dv)
        {
            this.idmaDV= dv.idmaDV;
            this.tenDV= dv.tenDV;
            this.idmaLoaiDV= dv.idmaLoaiDV;
        }
        public DichVu(string idmaDV, string tenDV, LoaiDichVu idmaLoaiDV)
        {
            this.idmaDV = idmaDV;
            this.tenDV = tenDV;
            this.idmaLoaiDV = idmaLoaiDV;
        }
        //public DichVu dichVu { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_OOP
{
    public class LoaiDichVu
    {
        public string idmaLoaiDV { get; set; }
        public string phanLoaiDV { get; set; }
        public string motaChiTietLoaiDV { get; set; }
        public LoaiDichVu(LoaiDichVu loaiDV)
        {
            this.idmaLoaiDV=loaiDV.idmaLoaiDV;
            this.phanLoaiDV=loaiDV.phanLoaiDV;
            this.motaChiTietLoaiDV = loaiDV.motaChiTietLoaiDV;
        }
        public LoaiDichVu(string idmaLoaiDV, string phanLoaiDV, string motaChiTietLoaiDV)
        {
            this.idmaLoaiDV = idmaLoaiDV;
            this.phanLoaiDV = phanLoaiDV;
            this.motaChiTietLoaiDV = motaChiTietLoaiDV;
        }
    }
}

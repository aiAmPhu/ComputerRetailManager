using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_OOP
{
    public class TrucPhong
    {
        public NhanVien idmaNV { get; set; }
        public Tang idmaTang { get; set; }
        public Phong idmaPhong { get; set; }
        public string thoiGian { get; set; }
        public TrucPhong(TrucPhong trucPhong)
        {
            this.idmaNV = trucPhong.idmaNV;
            this.idmaTang = trucPhong.idmaTang;
            this.idmaPhong = trucPhong.idmaPhong;
            this.thoiGian = trucPhong.thoiGian;
        }
        public TrucPhong(NhanVien idmaNV, Tang idmaTang, Phong idmaPhong, string thoiGian)
        {
            this.idmaNV = idmaNV;
            this.idmaTang = idmaTang;
            this.idmaPhong = idmaPhong;
            this.thoiGian = thoiGian;
        }
    }
}

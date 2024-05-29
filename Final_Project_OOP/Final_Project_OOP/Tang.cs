using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_OOP
{
    public class Tang
    {
        public string idmaTang { get; set; }
        public string loaiTang { get; set; }
        public string sdtKhanCap { get; set; }
        public Tang(Tang tang)
        {
            this.idmaTang = tang.idmaTang;
            this.loaiTang= tang.loaiTang;
            this.sdtKhanCap= tang.sdtKhanCap;
        }
        public Tang(string idmaTang, string loaiTang, string sdtKhanCap)
        {
            this.idmaTang = idmaTang;
            this.loaiTang = loaiTang;
            this.sdtKhanCap = sdtKhanCap;
        }
    }
}

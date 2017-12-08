using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppB4.Enum;

namespace ConsoleAppB4.Enties
{
    class NhaQuanLy : NhanVien
    {
        //ChucVu, SoNgayCong, BacLuong
        public ChucVu ChucVu { get; set; }
        public int SoNgayCong { get; set; }
        public double BacLuong { get; set; }
    }
}

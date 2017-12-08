using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppB4.Enum;

namespace ConsoleAppB4.Enties
{
    class NhanVien
    {
        public string HoTen { get; set; }
        public DateTime NamSinh { get; set; }
        public BangCap BangCap { get; set; }

        public void Nhap()
        {
            Console.Write("Ho Ten:");
            HoTen = Console.ReadLine();
            Console.Write("Nam Sinh:");
            NamSinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Chon: 1.Ky su \t2.Thac Si \t3.Tien si");
            BangCap = (BangCap)int.Parse(Console.ReadLine());
        }
    }
}

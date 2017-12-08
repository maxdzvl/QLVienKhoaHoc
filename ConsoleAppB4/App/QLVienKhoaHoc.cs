using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppB4.Enties;
using ConsoleAppB4.Enum;

namespace ConsoleAppB4.App
{
    class QLVienKhoaHoc
    {
        // định nghĩa ds lưu nhân viên (NhaKhoaHoc, NhaQL, NhanVienPhongThiNghiem
        List<NhanVien> nhanViens = new List<NhanVien>();

        // nhập ds
        public void NhapDS()
        {
            int slNhanVien;
            int loaiNhanVien
            //nhập sl
            Console.Write("Nhap so luong nhan vien: ");
            slNhanVien = int.Parse(Console.ReadLine())
                
                // nhập nv
            for (int i = 0; i < slNhanVien; i++)
            {
                Console.Writeline("\tThong tin nhan vien thu {0}", i + 1);
                Console.WriteLine("\t\tChon loai nhan vien:");
                Console.WriteLine("\t\t\t1.Nha Quan Ly");
                Console.WriteLine("\t\t\t2.Nha Khoa Hoc");
                Console.WriteLine("\t\t\t3.Nhan Vien Phong Thi Nghiem");
                Console.Write("\t\tChon:");
                // lấy giá trị chọn 
                loaiNhanVien = int.Parse(Console.ReadLine())
                // xác định nv cần nhập
                switch(loaiNhanVien)
                {
                    case (int)loaiNhanVien.NhaQuanLy:
                        Console.WriteLine("Nhap thong tin nha quan ly");
                        nhanViens = new NhaQuanLy();
                        break;
                    case (int)loaiNhanVien.NhaKhoaHoc:
                        Console.WriteLine("Nhap thong tin nha khoa hoc");
                        nhanViens = new NhaKhoaHoc();
                        break;
                    case (int)loaiNhanVien.NhanVienPhongThiNghiem:
                        Console.WriteLine("Nhap thong tin nhan vien phong thi nghiem");
                        nhanViens = new NhanVienPhongThiNghiem();
                        break;
                    default:
                        break;
                }
                // nhập
                nhanVien.Nhap();
                nhanViens.Add(nhanVien)
            }
        }
    }
}

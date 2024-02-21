using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranNguyenThanhDat_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            QuanLyNV q1 = new QuanLyNV();
            int luaChon = 0;
            do
            {
                Console.WriteLine("CHUONG TRINH QUAN LY NHAN VIEN");
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("1. Nhap danh sach nhan vien.");
                Console.WriteLine("2. Hien thi thong tin nhan vien. ");
                Console.WriteLine("3. Thong ke tien luong cty phai tra cho nhan vien.");
                Console.WriteLine("4. Tinh tien luong thuc lanh trung binh. ");
                Console.WriteLine("0. Thoat. ");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Lua chon");
                luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            } while ();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranNguyenThanhDat_01
{
    class QuanLyNV
    {
        private List<NhanVien> dsNV;
        public QuanLyNV()
        {
            dsNV = new List<NhanVien>();
        }
        public void NhapDS()
        {
            string TiepTuc = "y";
            int chon;
            NhanVien nv;
            do
            {
                Console.WriteLine("-Chon loai nhan vien (1: Bien che | 2: Hop dong");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nv = new NhanVienBC();
                        nv.nhap();
                        dsNV.Add(nv);
                        break;
                    case 2:
                        nv = new NhanVienHD();
                        nv.nhap();
                        dsNV.Add(nv);
                        break;
                    default:
                        Console.WriteLine("Loai Nhan Vien khong phu hop!");
                        break;
                }
                Console.Write("Muon tiep tuc hay chon Y/N: ");
                TiepTuc = Console.ReadLine();
            } while (TiepTuc.ToLower() == "y");
        }
        public void XuanDS()
        {
            Console.WriteLine($"{"Ma so",-10}, {"Ho ten",20}, {"Thuc lanh",20}");
            foreach (NhanVien x in dsNV)
            {
                Console.WriteLine($"{x.Maso,-10} {x.Hoten,20} {x.TinhLuong(),20}");
            }
        }
    }
}

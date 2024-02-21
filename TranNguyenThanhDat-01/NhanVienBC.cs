using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranNguyenThanhDat_01
{
    class NhanVienBC:NhanVien
    {
        private string MucXepLoai;
        public NhanVienBC():base()
        {

        }
        public NhanVienBC(string MaSo, string HoTen, int LuongCung): base(MaSo, HoTen, LuongCung)
        {
            this.MucXepLoai = MucXepLoai;
        }
        public string mucXepLoai
        {
            set { this.MucXepLoai = value; }
            get { return MucXepLoai; }
        }
        public override void nhap()
        {
            Console.Write("-Xep Loai: ");
            this.MucXepLoai = Console.ReadLine();
        }
        public override double TinhLuong()
        {
            double Thuong;
            if (this.MucXepLoai=="a")
            {
                Thuong = 1.8 * Luongcung;
            }
            else if (this.MucXepLoai=="b")
            {
                Thuong = 1.2 * Luongcung;
            }
            else
            {
                Thuong = 0.8 * Luongcung;
            }
            return Thuong;
        }
    }
}

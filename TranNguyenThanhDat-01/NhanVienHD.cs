using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranNguyenThanhDat_01
{
    class NhanVienHD:NhanVien
    {
        private int DoanhThu;
        public NhanVienHD() : base()
        {

        }
        public NhanVienHD(string MaSo, string HoTen, int LuongCung) : base(MaSo, HoTen, LuongCung)
        {
            this.DoanhThu = DoanhThu;
        }
        public int Doanhthu
        {
            set { this.DoanhThu = value; }
            get { return DoanhThu; }
        }
        public override void nhap()
        {
            Console.Write("-Doanh Thu: ");
            this.DoanhThu = int.Parse(Console.ReadLine());
        }
        public override double TinhLuong()
        {
            return base.TinhLuong();
        }
    }
}

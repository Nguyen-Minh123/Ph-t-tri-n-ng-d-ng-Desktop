using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3_WindowsForm
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public double HeSoLuong { get; set; }
        public double HeSoPhuCap { get; set; }

        // Hàm khởi tạo
        public NhanVien(string ma, string ten, DateTime ns, double hsl, double hspc)
        {
            MaNV = ma;
            HoTen = ten;
            NgaySinh = ns;
            HeSoLuong = hsl;
            HeSoPhuCap = hspc;
        }

        // Tính tổng lương
        public double TongLuong()
        {
            return (HeSoLuong + HeSoPhuCap) * 1150000;
        }

        public string HienThi()
        {
            return string.Format("{0} , {1} , {2} , {3} , {4}",MaNV,HoTen,NgaySinh,HeSoLuong,HeSoPhuCap);
        }
    }
}

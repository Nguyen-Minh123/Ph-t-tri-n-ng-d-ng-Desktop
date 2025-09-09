using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3_WindowsForm
{
    internal class TinhToan
    {
        public static int TongDaySo(int n)
        {
            int tong = 0;
            for (int i = 1; i <= n; i++)
            {
                tong += i;
            }
            return tong;
        }
        public static long GiaiThua(int n)
        {
            long gt = 1;
            for (int i = 1; i <= n; i++)
            {
                gt *= i;
            }
            return gt;
        }

    }
    
}

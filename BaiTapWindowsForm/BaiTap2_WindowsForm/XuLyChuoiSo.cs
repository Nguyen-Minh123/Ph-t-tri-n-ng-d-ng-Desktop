using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BaiTapWindowsForm_Bai2
{
    internal class XuLyChuoiSo
    {
        public void NoiChuoi (string ho , string ten , out string s)
        {
            s = ho + " " + ten;
        }

        public long GiaiThua(long n)
        {
            if (n < 0) throw new ArgumentException("n phải >= 0");
            long gt = 1;
            for (int i = 1 ; i <= n; i++)
            {
                gt *= i;
            }
            return gt;
        }
    }


}

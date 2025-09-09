using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm_Bai2
{
    internal class PhepTinh
    {
        public int SoThuNhat {  get; set; }
        public int SoThuHai { get; set; }

        public PhepTinh( int soThuNhat, int soThuHai)
        {
            SoThuNhat = soThuNhat;
            SoThuHai = soThuHai;
        }

        public double Cong()
        {
            return SoThuNhat + SoThuHai;
        }
        public double Tru()
        {
            return SoThuNhat - SoThuHai;
        }

        public double Nhan()
        {
            return SoThuNhat * SoThuHai;
        }

        public double Chia()
        {
            if (SoThuHai == 0 )
            {
                throw new DivideByZeroException("Không thể chia cho 0!");
                
            }
            return (double)SoThuNhat / SoThuHai;
        }
    }
}

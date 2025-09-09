using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap4_WindowsForm
{
    public class TinhToan
    {

        
            // Hàm chào hỏi trả về string
            public static string ChaoHoi(string hoTen, string gioiTinh)
            {
                string loiChao = "";
                if (gioiTinh.ToLower() == "nam")
                    loiChao = "Xin chào anh " + hoTen;
                else if (gioiTinh.ToLower() == "nu")
                    loiChao = "Xin chào chị " + hoTen;
                else
                    loiChao = "Xin chào bạn " + hoTen;

                return loiChao;
            }

            // Hàm tính USCLN
            public static int USCLN(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }
        

    }
}

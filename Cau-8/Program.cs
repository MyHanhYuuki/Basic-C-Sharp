 //Đổi ra số nhị phân tương ứng với số thập phân được nhập vào.


using System;


namespace Cau_8
{

    class Program    
    {
        static void NhapSoThapPhan(out int so)
        {
            bool check = false;
            do
            {
                Console.WriteLine(" Ban hay nhap vao so thap phan:\n ");
                if (!int.TryParse(Console.ReadLine(), out so))
                    Console.WriteLine(" Kieu du lieu nhap vao khong hop le!!!\n ");
                else check = true;
            } while (!check);
        }

        static string DoiSangSoNhiPhan( int so)
        {
            string ChuoiNhiPhan = "";
            while( so != 0 )
            {
                ChuoiNhiPhan = so % 2 + ChuoiNhiPhan;
                so /= 2;
            }
            return ChuoiNhiPhan;

        }

        static void Main(string[] args)
        {
            int n;
            NhapSoThapPhan(out n);
            Console.WriteLine(" Doi sang so nhi phan la: \n");
            Console.WriteLine(" {0}(10) = {1}(2)", n, DoiSangSoNhiPhan(n));

        }
    }
}

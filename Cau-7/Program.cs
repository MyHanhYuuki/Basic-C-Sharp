/*Nhập vào số tiền. Hãy tính và in ra số tờ tiền tương ứng của các mệnh giá giảm dần: 500k, 200k, 100k, 50k. (giả sử đổi hết mệnh giá lớn, phần dư mới đổi sang mệnh giá nhỏ hơn). */


using System;

namespace Cau_7
{
    class Program
    {
        static void NhapTien(out int tien)
        {
            do
            {
                Console.WriteLine(" Ban hay nhap vao so tien tu 50 000 den 100 000 000 va la boi so cua 50 000: ");
                if (!int.TryParse(Console.ReadLine(), out tien))
                    Console.WriteLine(" Tien ban nhap vao phai la con so moi hop le!!! \n ");
                {
                    if (tien % 50000 != 0)
                        Console.WriteLine(" Tien ban nhap vao phai la boi so cua 50 000 va trong khoang tu 50 ngan den 100 trieu!!! \n");
                }
            }
            while (tien < 50000 || tien > 100000000 || tien % 50000 != 0);

        }

        static void DoiTien(int tien)
        {
            int SoTo50k, SoTo100k, SoTo200k, SoTo500k;
            SoTo500k = tien / 500000;
            SoTo200k = (tien % 500000) / 200000;
            SoTo100k = (tien % 500000 % 200000) / 100000;
            SoTo50k = (tien % 500000 % 200000 % 100000) / 50000;

            Console.WriteLine("\n So tien ban nhan duoc gom co:\n");
            Console.WriteLine("********************* \n");
            Console.WriteLine(" So to 500k la: {0} to. \n So to 200k la: {1} to.\n So to 100k la: {2} to.\n So to 50k  la: {3} to. \n", SoTo500k, SoTo200k, SoTo100k, SoTo50k);
            Console.WriteLine("***** Thank You ***** \n");
        }
    }
}
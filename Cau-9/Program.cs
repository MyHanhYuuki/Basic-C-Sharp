//Tính số ngày trong tháng ứng với tháng và năm được nhập vào.

using System;

namespace Cau_9
{
    class Program
    {
        static void NhapThang( out int thang)
        {

            do
            {
                Console.WriteLine(" Ban hay nhap thang vao (tu 1 den 12): \n");
                if (!int.TryParse(Console.ReadLine(), out thang))
                    Console.WriteLine(" Thang phai la so nguyen !!! \n");

                else{
                      if (thang < 1 || thang > 12)
                      Console.WriteLine(" Thang phai la so nguyen tu 1 den 12 !!! \n");
                }
            
            } while (thang < 1 || thang > 12);
                                                 
        }

        static void NhapNam( out int nam)
        {
            bool songuyen = false;
            do
            {
                Console.WriteLine(" Ban hay nhap nam vao: \n");
                if (!int.TryParse(Console.ReadLine(), out nam))
                    Console.WriteLine(" Nam phai la so nguyen !!! \n");
                else
                {
                    songuyen = true;
                    if (nam < 1900 || nam > 3000)
                    Console.WriteLine("Nam phai lon hon 1000 va nho hon 3000 !!! \n");
                }
            } while (!songuyen || nam < 1900 || nam > 3000);
        }

        static int TinhSoNgay(int thang)
        {
            int songay = 0;
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    songay = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    songay = 30;
                    break;
                case 2:
                    int nam;
                    NhapNam(out nam);  
                    if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                        songay = 29;
                    else
                        songay = 28;
                    break;
            }
            return songay;
        }
                      
            
            static void Main(string[] args)
        {
            int thang;
            int nam;
            NhapThang( out thang);
            NhapNam(out nam);
            Console.WriteLine(" \n Ket qua: \n ");
            Console.WriteLine("************************** \n");
            Console.WriteLine(" Thang {0} cua nam {1} co: {2} ngay !", thang, nam, TinhSoNgay(thang));
         }
    }
}
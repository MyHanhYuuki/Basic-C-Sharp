// Viết chương trình nhập vào tháng và năm. In ra số ngày của tháng đó.


using System;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ban hay nhap thang : ");
            string Sthang = Console.ReadLine();
            Console.Write("Ban hay nhap nam : ");
            string Snam = Console.ReadLine();

            int th = int.Parse(Sthang);
            int nm = int.Parse(Snam);
            int songay = 0;

            if (th >= 1 && th <= 12)
            {
                switch (th)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: songay = 31; break;
                    case 4:
                    case 6:
                    case 9:
                    case 11: songay = 30; break;

                    case 2:
                        if (nm % 400 == 0 || (nm % 4 == 0 && nm % 100 != 0))    // nam nhuan
                            songay = 29;
                        else
                            songay = 28;
                        break;
                }

                Console.Write("=> Thang " + th + "/" + nm + " co " + songay + " ngay\n");
            }
            else
                Console.Write("=> Thang khong hop le!\n");
            Console.ReadLine();
        }
    }
}

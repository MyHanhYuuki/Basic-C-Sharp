// Tính chu vi và diện tích của hình tròn có bán kính R..

using System;

namespace Cau_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, chu_vi, dien_tich;
            double PI = 3.14;
            Console.Write("Ban hay nhap ban kinh duong tron R: ");
            r = Convert.ToDouble(Console.ReadLine());
            chu_vi = 2 * PI * r;
            Console.WriteLine("\n - Chu vi cua hinh tron la: {0}", chu_vi);
            dien_tich = PI * r * r;
            Console.WriteLine("- Dien tich cua hinh tron la: {0}", dien_tich);
            Console.Read();
            Console.ReadKey();
        }
    }
}

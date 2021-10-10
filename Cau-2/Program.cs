// Tính chu vi và diện tích của hình chữ nhật, với chiều dài và chiều rộng được nhập vào.

using System;

namespace Cau_2
{
    class Program
    {
          static void Main(string[] args)
          {
            double a, b, P, D;
            Console.Write("Nhap vao chieu dai a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao chieu rong b: ");
            b = Convert.ToDouble(Console.ReadLine());

            P = (a + b) * 2;
            Console.Write("Chu vi hinh chu nhat la: {0} \n", P);

            D = a * b;
            Console.Write("Dien tich hinh chu nhat la: {0} \n", D);

            Console.ReadKey();
          }
    }                 
}    
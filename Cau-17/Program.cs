// Hiển thị menu với các lựa chọn để thực hiện các phép toán cơ bản (+ - x :) của hai số a, b.

using System;

namespace Cau_17
{
    class Program
    {
        public static void Main()
        {

            int num1, num2, opt;

            Console.Write("\n");
            Console.Write("Hien thi menu voi cac lua chon de thuc hien cac phep toan co ban( + - x :) :\n");
            Console.Write("-------------------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Ban hay nhap so nguyen thu nhat: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ban hay nhap so nguyen thu hai: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nLua chon cac phep tinh:\n");
            Console.Write("1 - Phep cong.\n2 - Phep tru.\n3 - Phep nhan.\n4 - Phep chia.\n5 - Thoat.\n");
            Console.Write("\nNhap lua chon cua ban: ");
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Console.Write("-> Tong cua hai so {0} va {1} la: {2}\n", num1, num2, num1 + num2);
                    break;

                case 2:
                    Console.Write("-> Hieu cua hai so {0} va {1} la: {2}\n", num1, num2, num1 - num2);
                    break;

                case 3:
                    Console.Write("-> Tich cua hai so {0} va {1} la: {2}\n", num1, num2, num1 * num2);
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.Write("Neu so thu hai = 0 --> Khong thuc hien duoc phep chia cho so 0.\n");
                    }
                    else
                    {
                        Console.Write("-> Thuong cua hai so {0} va {1} la: {2}\n", num1, num2, num1 / num2);
                    }
                    break;

                case 5:
                    break;

                default:
                    Console.Write("Nhap tuy chon khong hop le! \n");
                    break;
            }
            Console.ReadKey();
        }
    }
} 

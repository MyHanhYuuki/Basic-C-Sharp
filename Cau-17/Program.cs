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
            Console.Write("Hien thi menu voi cac lua chon de thuc hien cac phep toan co ban( + - x :) \n");
            Console.Write("---------------------------------------------------------------------------");
            Console.Write("\n\n");

            NhapLaiNum1:
            Console.Write("\nBan hay nhap so nguyen thu nhat: ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            if (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("So nhap vao phai la so nguyen!");
                goto NhapLaiNum1;
            }

            NhapLaiNum2:
            Console.Write("\nBan hay nhap so nguyen thu hai: ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            if (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("So nhap vao phai la so nguyen!");
                goto NhapLaiNum2;
            }

            Console.Write("\nLua chon cac phep tinh:\n");
            Console.Write("1 - Phep cong.\n2 - Phep tru.\n3 - Phep nhan.\n4 - Phep chia.\n5 - Thoat.\n");

            NhapLai:
            Console.Write("\nNhap lua chon cua ban: ");
            //opt = Convert.ToInt32(Console.ReadLine());
            if (!int.TryParse(Console.ReadLine(), out opt))
            {
                Console.WriteLine("So nhap vao phai la so nguyen!");
                goto NhapLai;
            }

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
                default:
                    Console.Write("Nhap tuy chon khong hop le! ( chon tu 1 den 4) \n");
                    Console.Write("Ban vui long nhap lai! \n");
                    goto NhapLai;
                    break;
            }
            Console.ReadKey();
        }
    }
}
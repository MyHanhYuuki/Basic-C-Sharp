// Nhập vào ĐTB của 1 học sinh. In ra màn hình kết quả xếp loại như sau:
// • 0 ≤ ĐTB < 5: Yếu
// • 5 ≤ ĐTB < 7: TB
// • 7 ≤ ĐTB < 8: Khá
// • 8 ≤ ĐTB < 9: Giỏi
// • 9 ≤ ĐTB ≤ 10: Xuất sắc

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cau_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n DIEM TRUNG BINH CUA HOC SINH \n");
            Console.WriteLine("---------------------------------");
            NhapLai:
            Console.WriteLine("\n Ban hay nhap vao DTB cua 1 hoc sinh: \n");
            Double DTB = Convert.ToDouble(Console.ReadLine());
            if (DTB < 0 || DTB > 10)
                Console.WriteLine(" Diem trung binh la mot so thuc tu 0 den 10!");

            if (DTB >= 0 && DTB < 5)
                Console.WriteLine("Hoc sinh dat loai yeu!");
            else if (DTB >= 5 && DTB < 7)
                Console.WriteLine("Hoc sinh dat loai trung binh!");
            else if (DTB >= 7 && DTB < 8)
                Console.WriteLine("Hoc sinh dat loai kha!");
            else if (DTB >= 8 && DTB < 9)
                Console.WriteLine("Hoc sinh dat loai gioi!");
            else if (DTB >= 9 && DTB <= 10)
                Console.WriteLine("Hoc sinh dat loai xuat sac!");
            else
            {
                Console.WriteLine(" Ban vui long nhap lai!");
                goto NhapLai;
            }
        }
    }
}

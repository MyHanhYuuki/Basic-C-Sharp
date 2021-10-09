//  Kiểm tra ký tự nhập vào là nguyên âm (a, e, i, o, u) hay phụ âm.

using System;

namespace Cau_6
{
    class Program
    {
        static void Main(string[] args)
        {
            char h;
            Console.Write("\n");
            Console.Write("Kiem tra ky tu nhap vao la nguyen am hay phu am! \n ");
            Console.Write("------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Ban hay nhap vao mot chu cai: ");
            h = Convert.ToChar(Console.ReadLine().ToLower());
            switch (h)
            {
                case 'a':
                    Console.WriteLine(" -> Chu cai ban vua nhap la nguyen am.");
                    break;
                case 'i':
                    Console.WriteLine(" -> Chu cai ban vua nhap la nguyen am.");
                    break;
                case 'o':
                    Console.WriteLine(" -> Chu cai ban vua nhap la nguyen am.");
                    break;
                case 'u':
                    Console.WriteLine(" -> Chu cai ban vua nhap la nguyen am.");
                    break;
                case 'e':
                    Console.WriteLine(" -> Chu cai ban vua nhap la nguyen am.");
                    break;
                default:
                    Console.WriteLine(" -> Chu cai ban vua nhap la phu am.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
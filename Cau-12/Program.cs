// Giải và biện luận phương trình bậc 1: ax + b = 0

using System;
namespace Cau_12
{
    class Program
    {
        static void NhapSoThuc(string msg, out double so)
        {
            bool valid = false;
            do
            {
                Console.Write(msg);
                if (!double.TryParse(Console.ReadLine(), out so))
                    Console.WriteLine(" Kieu du lieu khong hop le !!! \n");
                else
                    valid = true;
            } while (!valid);

        }

        static void NhapHeSo(out double a, out double b)
        {
            NhapSoThuc(" Ban hay nhap vao he so cua a: \n ", out a);
            NhapSoThuc(" Ban hay nhap vao he so cua b: \n ", out b);
        }

        static void GiaiPTBac1(double a, double b)
        {

            if (a == 0)
            {
                if (b == 0)                    
                        Console.WriteLine(" Phuong trinh co vo so nghiem ! \n ");
                    else
                        Console.WriteLine(" Phuong trinh vo nghiem ! \n");            
            }
            else
                Console.WriteLine(" Phuong trinh co nghiem x= {0}", -b / a == 0 ? 0 : -b / a);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n Giai phuong trinh bac 1: \n");
            Console.WriteLine("************************* \n");
            double hsa, hsb;
            NhapHeSo(out hsa, out hsb);
            GiaiPTBac1(hsa, hsb);
        }
    }
}
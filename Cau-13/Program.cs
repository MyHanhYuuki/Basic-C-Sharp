//Giải và biện luận phương trình bậc 2: ax2 + bx + c = 0


using System;

namespace Cau_13
{
    class Program
    { 
      static void NhapSoThuc( string msg, out double so)
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

     static void NhapHeSo( out double a, out double b, out double c)
    {
        NhapSoThuc(" Ban hay nhap vao he so cua a: \n ", out a);
        NhapSoThuc(" Ban hay nhap vao he so cua b: \n ", out b);
        NhapSoThuc(" Ban hay nhap vao he so cua c: \n ", out c);
    }

        static void GiaiPTBac2(double a, double b, double c)
        {
            /* Giai phuong trinh bac 1 */
            if (a == 0)
            {
                if (b == 0)
                    if (c == 0)
                        Console.WriteLine(" Phuong trinh co vo so nghiem ! \n ");
                    else
                        Console.WriteLine(" Phuong trinh vo nghiem ! \n");
                else
                    Console.WriteLine(" Phuong trinh co nghiem x= {0}", -c / b == 0 ? 0 : -c / b);
            }

            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                    Console.WriteLine(" Delta < 0 suy ra phuong trinh vo nghiem !\n");
                else if (delta == 0)
                    Console.WriteLine(" Phuong trinh co nghiem kep la: x1 = x2 = {0}", -b / (2 * a));
                else
                    Console.WriteLine(" Phuong trinh co 2 nghiem phan biet x1,x2: \n  x1= {0}, x2= {1}", (-b - Math.Sqrt(delta)) / (2 * a), (-b + Math.Sqrt(delta)) / (2 * a)); 
            }
        }

    static void Main(string[] args)
        {
            Console.WriteLine("\n Giai phuong trinh bac 2: \n");
            Console.WriteLine("************************* \n");
            double hsa, hsb, hsc;
            NhapHeSo(out hsa, out hsb, out hsc);
            GiaiPTBac2(hsa, hsb, hsc);
        }
    }
}

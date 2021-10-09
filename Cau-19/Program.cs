// Tìm USCLN và BSCNN của 2 số nguyên a, b theo giải thuật Euclide.

using System;

namespace Cau_19
{
    class Program
    {
        // Ham uoc so chung lon nhat (USCLN)
        static int USCLN(int a, int b)
        {
                if (b == 0) return a;
                return USCLN(b, a % b);
        }


        // Ham boi so chung nho nhat (BSCNN)         
        static int BSCNN(int a, int b)
        { 
               return (a * b) / USCLN(a, b);
        }
            
        static void Main(string[] args)
        {
                Console.Write("Ban hay nhap vao so nguyen duong a = ");
                String valA = Console.ReadLine();
                int a = Convert.ToInt32(valA);
                Console.Write("Ban hay nhap vao so nguyen duong b = ");
                String valB = Console.ReadLine();
                int b = Convert.ToInt32(valB);
                // tinh USCLN cua a và b
                Console.Write("USCLN cua {0} va {1} la: {2} \n", a, b, USCLN(a, b));
                // tinh BSCNN cua a và b
                Console.Write("USCLN cua cua {0} va {1} la: {2}", a, b, BSCNN(a, b));
        }    
    }  
}
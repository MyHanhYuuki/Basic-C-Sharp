// Tìm USCLN và BSCNN của 2 số nguyên a, b theo giải thuật Euclide.


using System;

namespace Cau_19
{
    class Program
    {
        // Ham uoc chung lon nhat (UCLN)
        static int UCLN(int a, int b)
        {
                if (b == 0) return a;
                return UCLN(b, a % b);
        }


        // Ham boi chung nho nhat (BCNN)         
        static int BCNN(int a, int b)
        { 
               return (a * b) / UCLN(a, b);
        }
            
        static void Main(string[] args)
        {
                Console.Write("Ban hay nhap vao so nguyen duong a = ");
                String valA = Console.ReadLine();
                int a = Convert.ToInt32(valA);
                Console.Write("Ban hay nhap vao so nguyen duong b = ");
                String valB = Console.ReadLine();
                int b = Convert.ToInt32(valB);
              
                Console.Write("UCLN cua {0} va {1} la: {2} \n", a, b, UCLN(a, b));          
                Console.Write("BCNN cua {0} va {1} la: {2} \n", a, b, BCNN(a, b));
                Console.ReadKey();
        }    
    }  
}
//Kiểm tra số nguyên nhập vào có phải là: số nguyên tố, số chính phương, số hoàn thiện, số đối xứng hay không.

using System;

namespace Cau_20

{
    class Program
    {

        static void NhapSo(out int n)
        {
            bool check = false;
            do
            {
                Console.WriteLine(" Ban hay nhap so vao: \n");
                if (!int.TryParse(Console.ReadLine(), out n) || n<0)
                    Console.WriteLine(" So ban nhap vao khong hop le ! \n");
                else check = true;
            } while ( !check );            
        }

        static void KTSoNguyenTo(int n)
        {
            int bien_dem = 0;
            //n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    bien_dem++;
            if (bien_dem == 2)
                Console.WriteLine(" -- So {0} la so nguyen to ! \n", n);
            else
                Console.WriteLine(" -- So {0} khong phai la so nguyen to ! \n", n);
        }

        static void KTSoChinhPhuong(int n)
        {                            
                //n = int.Parse(Console.ReadLine());
                double sqrt = Math.Sqrt(n);
                sqrt = (int)sqrt;

                if (sqrt * sqrt == n)
                {
                    Console.WriteLine(" -- So {0} La so chinh phuong !", n);
                }
                else
                {
                    Console.WriteLine(" -- So {0} Khong la so chinh phuong !", n);
                }           
        }
 
        static void KTSoHoanThien( int n)
            {            
                int i, sum;               
                sum = 0;
                //Console.Write("Cac uoc so duong cua so da cho: ");
                for (i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        sum = sum + i;                       
                    }
                }
                
                if (sum == n)
                    Console.Write("\n -- So {0} la so hoan thien ! \n", n);
                else
                    Console.Write("\n -- So {0} khong phai la so hoan thien ! \n", n);
                    Console.Write("\n");
        }

        static void KTSoDoiXung(int n)
        {
            int num, r, sum = 0;
            num = Convert.ToInt32(n);
            for (n = num; num != 0; num = num / 10)
                {
                    r = num % 10;
                    sum = sum * 10 + r;
                }
                if ( n == sum)
                    Console.Write(" -- So {0} la so doi xung !\n", n);
                else
                    Console.Write(" -- So {0} khong phai la so doi xung !\n", n);
        }

        static void Main(string[] args)
        {               
                int n;
                NhapSo(out n);
                KTSoNguyenTo(n);
                KTSoChinhPhuong(n);
                KTSoHoanThien(n);
                KTSoDoiXung(n);                
        }       
    }
}
// Viết chương trình cho phép tạo ma trận chứa các số nguyên ngẫu nhiên gồm n dòng, m cột. Cài đặt hàm thực hiện các chức năng sau:
// a. Xuất ma trận
// b. Tìm phần tử lớn nhất/ nhỏ nhất
// c. Tìm dòng có tổng lớn nhất
// d. Tính tổng các số không phải là số nguyên tố
// e. Xóa dòng thứ k trong ma trận
// f. Xóa cột chứa phần tử lớn nhất trong ma trận


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, i, j, mn, mx;
            Console.OutputEncoding = Encoding.UTF8; //dau
            Console.Write("Ban hay nhap vao so hang n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Ban hay nhap vao so cot m: ");
            m = int.Parse(Console.ReadLine());

            int[,] IntArray = new int[n, m];

            for (i = 0; i < IntArray.GetLength(0); i++)
            {
                for (j = 0; j < IntArray.GetLength(1); j++)
                {
                    Console.Write("Nhap gia tri phan tu [{0},{1}]: ", i, j);
                    IntArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // a. Xuat ma tran.
            Console.WriteLine("\nCau a)");
            Console.WriteLine("* Ma tran vua nhap *");

            for (i = 0; i < IntArray.GetLength(0); i++)
            {
                for (j = 0; j < IntArray.GetLength(1); j++)
                {
                    Console.Write("{0,3}", IntArray[i, j]);
                }
                Console.WriteLine();
            }

            // b. Tim phan tu lon nhat, nho nhat trong mang.
            mx = IntArray[0, 0];
            mn = IntArray[0, 0];

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    if (IntArray[i, j] > mx)
                    {
                        mx = IntArray[i, j];
                    }

                    if (IntArray[i, j] < mn)
                    {
                        mn = IntArray[i, j];
                    }
                }
            }

            Console.WriteLine("\nCau b)");
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", mx);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n", mn);

            // c. Tim dong co tong lon nhat.
            int[] SumRow = new int[10];
            int MaxRow = SumRow[0];
            for (i = 0; i < n; i++)
            {
                SumRow[i] = 0;
                for (j = 0; j < m; j++)
                {
                    SumRow[i] = SumRow[i] + IntArray[i, j];
                }
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    if (SumRow[i] > MaxRow)
                    {
                        MaxRow = SumRow[i];
                    }
                }
            }
            Console.WriteLine("\nCau c)");
            Console.WriteLine("Dong co tong lon nhat la: {0}", MaxRow);


         // d. Tinh tong cac so khong phai la so nguyen to.
            int[] SumPrime = new int[10];
            static Boolean isPrimeNumber(int n)
            {
                // so nguyen n < 2 khong phai la so nguyen to
                if (n < 2)
                {
                    return false;
                }
                // check so nguyen to khi n >= 2
                int squareRoot = (int)Math.Sqrt(n);
                int i;
                for (i = 2; i <= squareRoot; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            for (i = 0; i < n; i++)
            {
                SumPrime[i] = 0;
                for (j = 0; j < m; j++)
                {
                    if (isPrimeNumber(i) == false)
                    {
                        SumPrime[i] = SumPrime[i]+ IntArray[i, j];
                    }          
                }
            }
            Console.WriteLine("\nCau d)");
            Console.Write("Tong cac so khong phai so nguyen to la: {0}", SumPrime[i] );
        }
    }
}


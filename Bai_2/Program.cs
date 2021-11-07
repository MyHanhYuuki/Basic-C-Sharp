// Viết chương trình cho phép tạo mảng một chiều gồm n số nguyên ngẫu nhiên. Cài đặt hàm thực hiện các chức năng sau:
// a.Tính tổng các số lẻ trong mảng
// b. Đếm số nguyên tố trong mảng
// c. Tìm số chính phương nhỏ nhất (nếu không có hàm trả về -1)

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace Bai_2
{
    class Program
    {
        //Ham nhap mang
        public void setArray(ref int n, ref int[] a)
        {
            do
            {
                Console.Write("Ban hay nhap vao n (0 < n < 100): ");
                n = int.Parse(Console.ReadLine());
            } while (n >= 100 || n <= 0);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap a[{0}]: ", i);
                a[i] = int.Parse(Console.ReadLine().ToString());
            }
        }

        //Ham in tat ca cac phan tu trong mang
        public void print(int[] a, int n)
        {
            String tmp = "";
            for (int i = 0; i < n; i++)
            {
                tmp += a[i] + ", ";
            }
            Console.WriteLine("- Day so vua nhap: \n" + tmp.Substring(0, tmp.Length - 2));
        }

        //Ham dem so phan tu le trong mang
        public int getCountOddNumber(int[] a, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
                if (a[i] % 2 == 1) count++;
            return count;
        }

        // Ham tinh tong cac phan tu le trong mang
        public int getSumOddNumber(int[] a, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
                if (a[i] % 2 == 1) sum = sum + a[i];
            return sum;
        }

        //Ham xac dinh mot so co phai so nguyen to hay khong
        public Boolean isPrimeNumber(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i < n; i++)
                if (n % i == 0) return false;
            return true;
        }

        //Ham in cac so nguyen to trong mang
        public void printPrimeNumber(int[] a, int n)
        {
            String tmp = "";
            for (int i = 0; i < n; i++)
            {
                if (isPrimeNumber(a[i]))
                {
                    tmp += a[i] + ", ";
                }
            }
            if (tmp != "")
            {
                tmp = tmp.Substring(0, tmp.Length - 2);

                Console.WriteLine("- Cac so nguyen to trong mang: \n" + tmp);
            }
            else
            {
                Console.WriteLine("- Trong mang khong co so nguyen to !\n");
            }
        }

        //Ham dem so luong cac so nguyen to trong mang
        public int getCountPrimeNumber(int[] a, int n)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (isPrimeNumber(a[i]))
                {
                    count++;
                }
            }
            return count;
        }

        //Ham kiem tra mot so co phai so chinh phuong hay khong
        public Boolean isSquareNumber(int a)
        {
            Boolean kq = false;
            double x = Math.Sqrt(a);
            if ((int)x * x == a) { kq = true; }
            return kq;
        }

        //Ham in cac so chinh phuong trong mang
        public void printSquareNumber(int[] a, int n)
        {
            String tmp = "";            
            for (int i = 0; i < n; i++)
            {
                if (isSquareNumber(a[i]))
                {
                    tmp += a[i] + ", ";
                }
            }
            if (tmp != "")
            {
                tmp = tmp.Substring(0, tmp.Length - 2);
                Console.WriteLine("- Cac so chinh phuong trong mang: " + tmp);
            }
            else
            {
                Console.WriteLine("- Trong mang khong co so chinh phuong !");
            }
        }

        // Ham tim so chinh phuong nho nhat trong mang
        public int getMinSquareNumber(int[] a, int n)
        {

            int min = 10000;
            for (int i = 0; i < n; i++)
            {
                if (isSquareNumber(a[i]))
                {
                    if (a[i] < min) min = a[i];
                }              
            }
            return min;
        }

        // Ham Main
        static void Main(string[] args)
        {
            Program p = new Program();
            int n = 0; int[] a = new int[100];
            p.setArray(ref n, ref a);
            p.print(a, n);
            Console.WriteLine("- So luong phan tu le trong mang: " + p.getCountOddNumber(a, n));
            Console.WriteLine("--> Tong so le trong mang la: " + p.getSumOddNumber(a, n));
            p.printPrimeNumber(a, n);
            Console.WriteLine("--> So luong so nguyen to trong mang: " + p.getCountPrimeNumber(a, n));
            p.printSquareNumber(a, n);
            Console.WriteLine("--> So chinh phuong nho nhat trong mang: " + p.getMinSquareNumber(a, n));
            Console.ReadKey();
        }
    }
}

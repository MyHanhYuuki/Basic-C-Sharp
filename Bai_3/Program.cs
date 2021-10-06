//3.Viết chương trình cho phép tạo ma trận chứa các số nguyên ngẫu nhiên gồm n
//dòng, m cột. Cài đặt hàm thực hiện các chức năng sau:
//a.Xuất ma trận
//b. Tìm phần tử lớn nhất/nhỏ nhất
//c. Tìm dòng có tổng lớn nhất
//d. Tính tổng các số không phải là số nguyên tố
//e. Xóa dòng thứ k trong ma trận
//f. Xóa cột chứa phần tử lớn nhất trong ma trận

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace Bai_3
{
    class Program
    {
        //Ham nhap mang
        public void setArray(ref int n, ref int[] a)

        {
            do
            {
                Console.Write("Nhap n (0 < n < 100): ");

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
        public static void getSumOddNumber(int []a, int n)
        {

            int i, sum = 0;
            Console.WriteLine("\n- Hien thi cac so le: ");
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.ReadKey();
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

        //Ham tim so chinh phuong nho nhat
        public int getMin(int[] a, int n)
        {
            int min = a[0];
            for (int i = 0; i < n; i++)
            {
                if (isSquareNumber(a[i]))
                {
                    if (min > a[i]) min = a[i];
                }
                return min;
            }
            return min;
        }

            static void Main(string[] args)
            {
                Program p = new Program();
                int n = 0; int[] a = new int[100];
                p.setArray(ref n, ref a);
                p.print(a, n);
                Console.WriteLine("- So luong phan tu le trong mang: " + p.getCountOddNumber(a, n));
                Console.WriteLine("\n- Tong so le trong mang la:"); 
                getSumOddNumber(a, n);
                Console.WriteLine("- So luong so nguyen to trong mang: " + p.getCountPrimeNumber(a, n));
                p.printSquareNumber(a, n);
                Console.WriteLine("- So chinh phuong nho nhat trong mang: " + p.getMin(a, n));
            }
    }
}

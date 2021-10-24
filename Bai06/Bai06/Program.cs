using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapThucHanh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************Cac lop hinh hoc co ban***************");
            Console.WriteLine("Moi ban nhap vao cac so tuong ung de lua chon:");
            Console.WriteLine("1.Hinh Chu Nhat");
            Console.WriteLine("2.Hinh Tron");
            Console.WriteLine("3.Hinh Tam Giac");
            Console.WriteLine("4.Hinh Vuong");
            Console.WriteLine("5.Thoat");
            int m = int.Parse(Console.ReadLine());
            switch(m)
            {
                case 1:
                    {
                        HinhChuNhat t = new HinhChuNhat();
                        t.Nhap();
                        t.Xuat();
                    }
                    break;
                case 2:
                    {
                        HinhTron c = new HinhTron();
                        c.Nhap();
                        c.Xuat();
                    }
                    break;
                case 3:
                    {
                        HinhTamGiac t = new HinhTamGiac();
                        t.Nhap();
                        t.Xuat();
                    }
                    break;
                case 4:
                    {
                        HinhVuong v = new HinhVuong();
                        v.Nhap();
                        v.Xuat();
                    }
                    break;
                case 5:
                    break;
                default:
                    {
                        

                            Console.WriteLine("Vui long nhap so tuong ung");
                        
                    }
                    break;
            }
            Console.ReadKey();
        }
      
    }
    public abstract class Shape
        {
        public abstract void Nhap();
        public abstract void Xuat();
        }
    public class HinhChuNhat : Shape
    {
        int x, y;
        public override void Nhap()
        {
            Console.Write("Vui long nhap vao chieu dai hinh chu nhat:");
            x = int.Parse(Console.ReadLine());
            Console.Write("Vui long nhap vao chieu rong hinh chu nhat:");
            y = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            int DienTich = x * y;
            Console.WriteLine("Dien tich hinh chu nhat la:"+DienTich);
        }
    }
    public class HinhTron : Shape
    {
        int r;
        public override void Nhap()
        {
            Console.Write("Vui long nhap vao ban kinh hinh tron:");
            r = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            double DienTichHinhTron = r * r * 3.14;
            Console.WriteLine("Dien tich hinh tron la:" + DienTichHinhTron);
        }
    }
    public class HinhTamGiac : Shape
    {
        int h, j;
        public override void Nhap()
        {
            Console.WriteLine("Vui long nhap chieu dai:");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("Vui long nhap chieu cao tuong ung:");
            j = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            double DienTichHinhTamGiac = 1 / 2 * h * j;
            Console.WriteLine("Dien tich tam giac la:" + DienTichHinhTamGiac);
        }
    }
    public class HinhVuong : HinhChuNhat
    {
        int n;
        public override void Nhap()
        {
            Console.WriteLine("Vui long nhap vao do dai canh cua hinh vuong");
            n = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            int DienTichHinhVuong = n * n;
            Console.WriteLine("Dien tich hinh vuong la:" + DienTichHinhVuong);
        }

    }
}

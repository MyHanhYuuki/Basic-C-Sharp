// Da hinh dong (overriding). Tinh dien tich, chu vi hinh chu nhat.

using System;
namespace Bai03
{
    class Program
    {
        abstract class Shape
        {
            public abstract double CalculateArea();
            public abstract double CalculatePerimeter();
        }

        class Rectangle: Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle ( double width, double height)
            {
                Width = width;
                Height = height;
            }

            public override double CalculateArea()
            {
                return Width * Height;
            }

            public override double CalculatePerimeter()
            {
                return ( Width + Height ) * 2;
            }
        }

        class RectangleTester
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Ban hay nhap vao chieu dai cua HCN: ");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ban hay nhap vao chieu rong cua HCN: ");
                double height = Convert.ToDouble(Console.ReadLine());
                Rectangle rectangle = new Rectangle(width, height);
                Console.WriteLine("- Chu vi cua hinh chu nhat la: {0}", rectangle.CalculatePerimeter());
                Console.WriteLine("- Dien tich cua hinh chu nhat la: {0}", rectangle.CalculateArea());         
                Console.ReadKey();
            }                 
        }   
    }
}

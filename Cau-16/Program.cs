//Hiển thị menu với các lựa chọn để tính diện tích hình tròn, hình chữ nhật, hình tam giác tương ứng với dữ liệu đã nhập.


using System;

namespace Cau_16
{
    class Program
    {
        static void Main(string[] args)
        {

            int lua_chon, r, l, w, b, h;
            double dien_tich = 0;

            Console.Write("\n");
            Console.Write("Chuong trinh C# duoi dang mot menu co cac lua chon de tinh dien tich:\n");
            Console.Write("--------------------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Lua chon 1: tinh dien tich hinh tron\n");
            Console.Write("Lua chon 2: tinh dien tich hinh chu nhat\n");
            Console.Write("Lua chon 3: tinh dien tich hinh tam giac\n");
            Console.Write("Nhap lua chon cua ban: ");
            lua_chon = Convert.ToInt32(Console.ReadLine());

            switch (lua_chon)
            {
                case 1:
                    Console.Write("Nhap ban kinh hinh trong: ");
                    r = Convert.ToInt32(Console.ReadLine());
                    dien_tich = 3.14 * r * r;
                    break;
                case 2:
                    Console.Write("Nhap chieu dai HCN: ");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap chieu rong HCN: ");
                    w = Convert.ToInt32(Console.ReadLine());
                    dien_tich = l * w;
                    break;
                case 3:
                    Console.Write("Nhap canh huyen tam giac:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap chieu cao tam giac:");
                    h = Convert.ToInt32(Console.ReadLine());
                    dien_tich = 0.5 * b * h;
                    break;
            }
            Console.Write("Dien tich hinh la: {0}\n", dien_tich);

            Console.ReadKey();
        }
    }
}


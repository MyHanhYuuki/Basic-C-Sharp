//Hiển thị menu với các lựa chọn để thực hiện in ra: bảng cửu chương thứ n, bảng cửu chương từ m đến n và bảng cửu chương tổng hợp.


using System;

namespace Cau_18
{
    class Program
    {
        static void Main()
        {
            int lua_chon;
            int n, m;

            Console.Write("\n");
            Console.Write("In bang cuu chuong: \n");
            Console.Write("----------------------------");
            Console.Write("\n\n");

            Console.Write("Lua chon 1: In ra bang cuu chuong thu n. \n");
            Console.Write("Lua chon 2: In ra bang cuu chuong tu m den n. \n");
            Console.Write("Lua chon 3: In ra bang cuu chuong tong hop. \n");
            Console.Write(" \n Hay nhap con so lua chon cua ban: \n ");

            
            lua_chon = Convert.ToInt32(Console.ReadLine());

            switch (lua_chon)
            {
                case 1:
                    
                    Console.WriteLine(" \n --- Day la bang cuu chuong thu n --- \n");
                    Console.WriteLine(" Ban hay nhap vao n: \n");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" \n ");
                 
                    int so_nhan;
       
                    do
                    {                       
                        so_nhan = 1;
                        do
                        {
                            Console.WriteLine("{0} x {1} = {2}", n, so_nhan, n * so_nhan);
                            so_nhan++;
                        }
                        while (so_nhan <= 10);
                        Console.WriteLine();
                        
                    } while (n<2);
                    Console.ReadKey();
                    break;

                case 2:

                    Console.WriteLine(" \n --- Day la bang cuu chuong tu m den n --- \n");

                    Console.WriteLine(" Ban hay nhap vao n: \n");
                    n = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(" Ban hay nhap vao m: \n");
                    m = Convert.ToInt32(Console.ReadLine());

                    do
                    {
                        so_nhan = 1;
                        do
                        {
                            Console.WriteLine("{0} x {1} = {2}", n, so_nhan, n * so_nhan);
                            so_nhan++;
                        }
                        while (so_nhan <= 10);
                        Console.WriteLine();
                        n++;

                    } while (n <= m);
                    Console.ReadKey();                    
                    break;

                case 3:

                    Console.WriteLine(" \n --- Day la bang cuu chuong tong hop --- \n");
                    n = 2;
                    do
                    {
                        so_nhan = 1;
                        do
                        {
                            Console.WriteLine("{0} x {1} = {2}", n, so_nhan, n * so_nhan);
                            so_nhan++;
                        }
                        while (so_nhan <= 10);
                        Console.WriteLine();
                        n++;

                    } while (n <= 9);
                    Console.ReadKey();
                    break;
            }
        }
    }
}

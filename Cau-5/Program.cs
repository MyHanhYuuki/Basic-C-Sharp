// Nhập vào username và password. Nếu nhập sai quá 3 lần thì in thông báo lỗi, ngược lại hiển thị câu chào username.


using System;

namespace Cau_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string user, pass;
            int count = 0;
            Console.Write(" Dang nhap!\n");
            Console.Write("--Gia tri mac dinh la: user va password--\n");
            Console.Write("------------------------------------------------\n");

            do
            {
                Console.Write("Ten dang nhap: ");
                user = Console.ReadLine();

                Console.Write("Mat khau: ");
                pass = Console.ReadLine();

                count++;

            }
            while (((user != "user") || (pass != "password"))
                && (count != 3));

            if (count == 4)
                Console.Write("Dang nhap that bai!");
            else
                Console.Write("Mat khau chinh xac. Ban da dang nhap thanh cong!");
            Console.ReadKey();
        }
    }
}

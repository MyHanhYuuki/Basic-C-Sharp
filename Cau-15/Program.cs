//Viết chương trình mô phỏng trò chơi đoán số mà máy phát sinh. Nếu đoán đúng thì hiển thị chúc mừng, nếu nhỏ hơn hoặc lớn hơn thì thông báo cho người dùng biết mà đoán lại

using System;

namespace Cau_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" TRO CHOI DOAN SO \n");
            Console.WriteLine(" \n****************\n");
            Console.WriteLine(" Nhap gia tri nho nhat: \n");
            int minValue = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap gia tri lon nhat: \n");
            int maxValue = int.Parse(Console.ReadLine());

            Random myObject = new Random();
            int ranNum = myObject.Next(minValue, maxValue);

            Console.WriteLine(" Nhap so du doan: \n");
            int Guess = int.Parse(Console.ReadLine());
            while (Guess != ranNum)
            {
                if (Guess < ranNum)
                    Console.WriteLine(">" + Guess);
                else
                    Console.WriteLine("<" + Guess);

                Console.WriteLine(" Nhap so du doan: \n");
                Guess = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("  Chuc mung ban da doan chinh xac ! ");
        }
    }
}
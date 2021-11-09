// Viết chương trình mô phỏng trò chơi oẳn tù tì với máy.

using System;

namespace Cau_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" \n * TRO CHOI OAN TU TI * \n");

            NhapLai:
            Console.WriteLine(" Lua chon cua ban: \n 1- Ban chon Bao! \n 2- Ban chon Keo! \n 3- Ban chon Bua! \n");
            Console.WriteLine(" Ban chon ra cai gi: ");
            int user = Convert.ToInt32(Console.ReadLine());
            if(user < 1 || user > 3 )
            {
                Console.WriteLine(" Ban nhap sai, vui long nhap lai! \n");
                goto NhapLai;
            }

            Random random = new Random();
            int robot = random.Next(1, 4);

            switch (robot)
            {
                case 1:
                    Console.WriteLine(" Robot chon Bao!");
                    break;
                case 2:
                    Console.WriteLine(" Robot chon Keo!");
                    break;
                case 3:
                    Console.WriteLine(" Robot chon Bua!");
                    break;
            }

            switch (user)
            {
                case 1:
                    if (robot == 2)
                    {
                        Console.WriteLine(" Ban chon Bao!");
                        Console.WriteLine("-> Ban da thua!");
                    }
                    else if (robot == 3)
                    {
                        Console.WriteLine(" Ban chon Bao!");
                        Console.WriteLine("-> Ban da chien thang!");
                    }
                    else
                    {
                        Console.WriteLine(" Ban chon Bao!");
                        Console.WriteLine("-> Hoa nhau!");
                    }
                    break;

                case 2:
                    if (robot == 3)
                    {
                        Console.WriteLine(" Ban chon Keo!");
                        Console.WriteLine("-> Ban da thua!");
                    }
                    else if (robot == 1)
                    {
                        Console.WriteLine(" Ban chon Keo!");
                        Console.WriteLine("-> Ban da chien thang!");
                    }
                    else
                    {
                        Console.WriteLine(" Ban chon Keo!");
                        Console.WriteLine("-> Hoa nhau!");
                    }
                    break;
                case 3:
                    if (robot == 1)
                    {
                        Console.WriteLine(" Ban chon Bua!");
                        Console.WriteLine("-> Ban da thua!");
                    }
                    else if (robot == 2)
                    {
                        Console.WriteLine(" Ban chon Bua!");
                        Console.WriteLine("-> Ban da chien thang!");
                    }
                    else
                    {
                        Console.WriteLine(" Ban chon Bua!");
                        Console.WriteLine("-> Hoa nhau!");
                    }
                    break;
            }
            Console.WriteLine("\nBan co muon choi tiep khong? \n 1- Co\n 2- Khong \n");
            Console.WriteLine(" Moi ban nhap lua chon:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
                goto NhapLai;
        }
    }
}
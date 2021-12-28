// Nhap vao chuoi ho ten, chuan hoa chuoi ho ten vua nhap.

using System;

namespace Bai02
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Hay nhap vao ten cua ban: ");
            string name = Console.ReadLine();

            // loai bo dau cach o dau va cuoi.
            name = name.Trim();

            // dua tat ca ve dang viet thuong.
            name = name.ToLower();
            while (name.IndexOf("  ") != -1) 
            {   
            // loai bo cac dau cach trung nhau.
                name = name.Remove(name.IndexOf("  "), 1);
            }
            // Viet hoa len vi tri phan tach ten.
            string[] s = name.Split(' '); 
            string afterFormat = ""; 
            for (int i = 0; i < s.Length; ++i)
            {
                string first = s[i].Substring(0, 1);
                string another = s[i].Substring(1, s[i].Length - 1);            
                afterFormat += first.ToUpper() + another + " ";
            }
            afterFormat = afterFormat.Remove(afterFormat.LastIndexOf(' '), 1);
            
            Console.WriteLine("Ten cua ban sau khi duoc chuan hoa la: |{0}|", afterFormat);
            Console.ReadKey();
        }
    }
}
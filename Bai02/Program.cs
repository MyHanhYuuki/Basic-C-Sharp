using System;

namespace Bai02
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Hay nhap vao ten cua ban: ");
            string name = Console.ReadLine();

            name = name.Trim(); // loại bỏ các dấu cách thừa ở đầu và cuối.
            name = name.ToLower(); // đưa tất cả các ký tự về dạng viết thường cho dễ kiểm soát.
            while (name.IndexOf("  ") != -1) // kiểm tra xem có dấu 2 dấu cách nào liền nhau hay không.
            {              
                name = name.Remove(name.IndexOf("  "), 1); // loại bỏ đi 1 trong 2 dấu cách.
            }
            // tiếp theo đó là viết hoa lên vị trí phân tách tên.
            string[] s = name.Split(' '); // tách các từ bởi dấu cách để xử lý viết hoa dễ hơn.
            string afterFormat = ""; // biến lưu trữ lại chuỗi ký tự sau khi chuẩn hóa.
            for (int i = 0; i < s.Length; ++i) // thực hiện lặp lên toàn bộ các phần tử sau khi phân tách.
            {
                string first = s[i].Substring(0, 1); // lấy ra ký tự đầu tiên của từ đó.
                string another = s[i].Substring(1, s[i].Length - 1); // lấy ra chuỗi ký tự tính từ sau chữ cái đầu tiên.
                // tạo thành chuỗi ký tự sau khi viết hoa chữ cái đầu tiên và1 dấu cách cho việc chuẩn hóa các từ sau.
                afterFormat += first.ToUpper() + another + " ";
            }
            afterFormat = afterFormat.Remove(afterFormat.LastIndexOf(' '), 1); // xóa đi dấu cách thừa ở cuối khi thực hiện vòng lặp trên.

            // Dùng thêm 2 dấu | để khi in ra chắc chắn rằng dấu cách thừa đã bị xóa.
            Console.WriteLine("Ten cua ban sau khi chuan hoa: |{0}|", afterFormat);
            Console.ReadKey();
        }
    }
}
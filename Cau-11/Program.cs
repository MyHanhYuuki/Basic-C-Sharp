//Nhập điểm chuẩn và điểm 3 môn thi, mã khu vực (A, B, C), mã đối tượng (1, 2, 3) của thísinh. Hiển thị kết quả “Trúng tuyển” nếu tổng điểm thi 3 môn cộng với điểm ưu tiên khu vực và điểm ưu tiên đối tượng lớn hơn hoặc bằng điểm chuẩn
//• Khu vực A: cộng 1.5 điểm
//• Khu vực B: cộng 1 điểm
//• Khu vực C: cộng 0.5 điểm
//• Đối tượng 1: cộng 1.5 điểm
//• Đối tượng 2: cộng 1 điểm
//• Đối tượng 3: cộng .5 điểm


using System;

namespace Cau_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double diemchuan, diemthi, diemdt, diemkv;
            int madt;
            string makv;

            Console.WriteLine(" Ban hay nhap vao diem chuan: \n ");
            diemchuan = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Ban hay nhap vao diem 3 mon thi cua thi sinh: \n ");
            diemthi = Convert.ToDouble(Console.ReadLine());

            //Tinh diem khu vuc
            Console.WriteLine(" Ban hay chon ma khu vuc cua thi sinh (A, B or C): \n ");
            makv = Convert.ToString(Console.ReadLine());
            diemkv = 0;
            switch (makv)
            {
                case "A":
                    diemkv = 1.5;
                    Console.WriteLine(" Diem khu vuc A la: {0} \n", diemkv);                    
                    break;
                case "B":
                    diemkv = 1;
                    Console.WriteLine(" Diem khu vuc B la: {0} \n", diemkv);                    
                    break;
                case "C":
                    diemkv = 0.5;
                    Console.WriteLine(" Diem khu vuc C la: {0} \n", diemkv);                    
                    break;
            };          

            //Tinh diem doi tuong

            Console.WriteLine(" Ban hay chon ma doi tuong cua thi sinh (1, 2 or 3): \n ");
            madt = Convert.ToInt32(Console.ReadLine());
            diemdt = 0;
            switch (madt)
            {
                case 1:
                    diemdt = 1.5;
                    Console.WriteLine(" Diem doi tuong 1 la: {0} \n", diemdt);                 
                    break;
                case 2:
                    diemdt = 1;
                    Console.WriteLine(" Diem doi tuong 2 la: {0} \n", diemdt);          
                    break;
                case 3:
                    diemdt = 0.5;
                    Console.WriteLine(" Diem doi tuong 3 la: {0} \n", diemdt);                
                    break;
            };           

                //Tinh tong diem cua thi sinh va xet dieu kien.
            double tongdiem = diemthi + diemkv + diemdt;
            Console.WriteLine(" Tong diem cua thi sinh la: {0}", tongdiem);
            
            if (tongdiem >= diemchuan)
                Console.WriteLine("\n Chuc mung ban da trung tuyen !\n");
            else 
                Console.WriteLine("\n Ban da khong trung tuyen ! \n");
            Console.ReadKey();
        }

    }
}
     

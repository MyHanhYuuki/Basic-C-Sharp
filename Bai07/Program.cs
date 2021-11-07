//Bat Dong San.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai07
{
    class Xu_Ly
    {
        public Xu_Ly(string DD, int GB, float DT)
        {
            Dia_Diem = DD;
            Gia_Ban = GB;
            Dien_Tich = DT;
        }
        public string Dia_Diem { get; set; }
        public int Gia_Ban { get; set; }
        public float Dien_Tich { get; set; }
        public virtual void Xuat()
        {
            Console.WriteLine("Nhap dia diem: {0}", Dia_Diem);
            Console.WriteLine("Nhap gia ban: {0}", Gia_Ban);
            Console.WriteLine("Nhap dien tich: {0}", Dien_Tich);
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap dia diem: ");
            Dia_Diem = Console.ReadLine();
            Console.Write("Nhap gia ban: ");
            Gia_Ban = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap dien tich: ");
            Dien_Tich = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void Xuat_Theo_Dieu_Kien(int dien_tich, int nam_xay_dung, string dia_diem) { }
        public virtual void Tim_Kiem() { }
    }
    class Chung_Cu : Xu_Ly
    {
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap So Tang: ");
            So_Tang = Convert.ToInt32(Console.ReadLine());
        }
        public int So_Tang { get; set; }

        public Chung_Cu(string DD = " ", int GB = 0, float DT = 0, int ST = 0) : base(DD, GB, DT)
        {
            So_Tang = ST;
        }
        public override void Xuat_Theo_Dieu_Kien(int dien_tich, int nam_xay_dung, string dia_diem) { }
    }

    class Khu_Dat : Xu_Ly
    {
        public override void Nhap()
        {
            base.Nhap();

        }
        public Khu_Dat(string DD = " ", int GB = 0, float DT = 0) : base(DD, GB, DT)
        {
            Dia_Diem = DD;
            Gia_Ban = GB;
            Dien_Tich = DT;
        }
        public override void Xuat_Theo_Dieu_Kien(int dien_tich, int nam_xay_dung, string dia_diem)
        {
            if (Dien_Tich > dien_tich) Xuat();
        }
    }

    class Nha_Pho : Xu_Ly
    {
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap Nam Xay Dung: ");
            Nam_Xay_Dung = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap So Tang: ");
            So_Tang = Convert.ToInt32(Console.ReadLine());
        }
        public int Nam_Xay_Dung { get; set; }
        public int So_Tang { get; set; }

        public Nha_Pho(string DD = " ", int GB = 0, float DT = 0, int NXD = 0, int ST = 0) : base(DD, GB, DT)
        {
            Nam_Xay_Dung = NXD;
            So_Tang = ST;
        }
        public override void Xuat_Theo_Dieu_Kien(int dien_tich, int nam_xay_dung, string dia_diem)
        {
            if (Dien_Tich > dien_tich && Nam_Xay_Dung >= nam_xay_dung) Xuat();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Khu_Dat[] DSKD = new Khu_Dat[100];
            Nha_Pho[] DSNP = new Nha_Pho[100];
            Chung_Cu[] DSCC = new Chung_Cu[100];
            Console.Write("Nhap so khu dat: ");
            int SLKD = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < SLKD; i++)
                DSKD[i].Nhap();

            Console.Write("Nhap so chung cu: ");
            int SLCC = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < SLCC; i++)
                DSCC[i].Nhap();

            Console.Write("Nhap so nha pho: ");
            int SLNP = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < SLNP; i++)
                DSNP[i].Nhap();

            int TGKD = 0, TGNP = 0, TGCC = 0;
            for (int i = 0; i < SLNP; i++)
                TGNP += DSNP[i].Gia_Ban;
            for (int i = 0; i < SLKD; i++)
                TGKD += DSKD[i].Gia_Ban;
            for (int i = 0; i < SLCC; i++)
                TGCC += DSCC[i].Gia_Ban;


            Console.WriteLine("Tong gia nha pho: {0}", TGNP);
            Console.WriteLine("Tong gia khu dat: {0}", TGKD);
            Console.WriteLine("Tong gia chung cu: {0}", TGCC);

            for (int i = 0; i < SLKD; i++)
                DSKD[i].Xuat_Theo_Dieu_Kien(100, 0, "");

            for (int i = 0; i < SLNP; i++)
                DSKD[i].Xuat_Theo_Dieu_Kien(60, 2019, "");
        }
    }
}

// Ke thua- nong trai.
// Một nông trại chăn nuôi có 3 loại gia súc: bò, cừu, và dê. Mỗi loại gia súc đều có thể sinh con, cho sữa và phát ra tiếng kêu riêng của chúng. Khi đói, các gia súc sẽ phát ra tiếng kêu để đòi ăn. Sau một thời gian chăn nuôi, người chủ nông trại muốn thống kê xem trong nông trại có bao nhiêu gia súc ở mỗi loại, tổng số lit sữa mà tất cả các gia súc của ông đã cho.
// Áp dụng kế thừa, xây dựng chương trình cho phép người chủ nông trại nhập vào số lượng gia súc ban đầu ở mỗi loại.
// a. Một hôm người chủ nông trại đi vắng, tất cả gia súc trong nông trại đều đói. Hãy cho biết những tiếng kêu nghe được trong nông trại.
// b. Chương trình sẽ đưa ra thống kê các thông tin người chủ mong muốn (nêu trên) sau một lứa sinh và một lược cho sữa của tất cả gia súc. Biết rằng:
// -Tất cả gia súc ở mỗi loại đều sinh con.
// - Số lượng sinh của mỗi gia súc là ngẫu nhiên.
// - Tất cả gia súc ở mỗi loại đều cho sữa.
// - Số lit sữa mỗi gia súc cho là ngẫu nhiên nhưng trong giới hạn sau:
// • Bò: 0 – 20 lit.
// • Cừu: 0 – 5 lit.
// • Dê: 0 – 10 lit.

using System;

namespace Bai04
{
    class Program
    {
        public class GiaSuc
        {
            //thuoc tinh.
            protected int _Sua;
            protected int _Con;
            protected string _Keu;
            //property.
            public int Sua
            {
                get
                {
                    return this._Sua;
                }
                set
                {
                    this._Sua = value;
                }
            }
            public int Con
            {
                get
                {
                    return this._Con;
                }
                set
                {
                    this._Con = value;
                }
            }

            public string Keu
            {
                get
                {
                    return this._Keu;
                }
                set
                {
                    this._Keu = value;
                }
            }

            //khoi tao.
            public GiaSuc()
            {
                this._Sua = 1;
                this._Con = 1;
                this._Keu = "";
            }
            public GiaSuc(int Sua, int Con)
            {
                this._Sua = Sua;
                this._Con = Con;
                this._Keu = Keu;
            }
            public GiaSuc(GiaSuc Gs)
            {
                this._Sua = Gs._Sua;
                this._Con = Gs._Con;
                this._Keu = Gs._Keu;
            }
            //so con.
            public virtual void SinhCon()
            {
            }
            //luong sua.
            public virtual void LuongSua()
            {
            }
            //Tieng keu.
            public virtual void TiengKeu()
            {
            }
        }
        public class Bo : GiaSuc
        {
            //thuoc tinh.
            protected int[] _b;
            //property.
            public int this[int i]
            {
                get
                {
                    return this._b[i];
                }
                set
                {
                    this._b[i] = value;
                }
            }
            public int N
            {
                get
                {
                    return this._b.Length;
                }
            }
            //khoi tao.
            public Bo()
                : base()
            {
                this._b = new int[3] { 1, 2, 3 };
            }
            public Bo(int sua, int con, int[] b)
                : base(sua, con)
            {
                this._b = new int[b.Length];
                for (int i = 0; i < b.Length; i++)
                {
                    this._b[i] = b[i];
                }
            }
            public Bo(GiaSuc Gs, Bo b)
                : base(Gs)
            {
                this._b = new int[b.N];
                for (int i = 0; i < b.N; i++)
                {
                    this._b[i] = b[i];
                }
            }
            //nhap.
            public void Nhap()
            {
                Console.WriteLine("- Ban hay nhap vao so con bo: ");
                int n = int.Parse(Console.ReadLine());
                this._b = new int[n];
                for (int i = 0; i < this._b.Length; i++)
                {
                    Console.Write("\n {0} con", i + 1);

                }
            }

            //so con.
            public override void SinhCon()
            {
                base.SinhCon();
                Random r = new Random();
                int n = r.Next(0, 5);
                Console.Write("- So con bo duoc sinh ra la: " + n);
            }
            //luong sua.
            public override void LuongSua()
            {
                base.LuongSua();
                Random r = new Random();
                int n = r.Next(0, 20);
                Console.Write("\n- So lit sua la: " + n);
            }

            //tieng keu
            public override void TiengKeu()
            {
                base.TiengKeu();
                Console.WriteLine("\n- Tieng keu nghe duoc: boooooo");
            }
        }
        public class Cuu : GiaSuc
        {
            //thuoc tinh.
            protected int[] _c;
            //property.
            public int this[int i]
            {
                get
                {
                    return this._c[i];
                }
                set
                {
                    this._c[i] = value;
                }
            }
            public int N
            {
                get
                {
                    return this._c.Length;
                }
            }
            //khoi tao.
            public Cuu()
                : base()
            {
                this._c = new int[3] { 1, 2, 3 };
            }
            public Cuu(int sua, int con, int[] c)
                : base(sua, con)
            {
                this._c = new int[c.Length];
                for (int i = 0; i < c.Length; i++)
                {
                    this._c[i] = c[i];
                }
            }
            public Cuu(GiaSuc Gs, Cuu c)
                : base(Gs)
            {
                this._c = new int[c.N];
                for (int i = 0; i < c.N; i++)
                {
                    this._c[i] = c[i];
                }
            }
            //nhap
            public void Nhap()
            {
                Console.WriteLine("\n\n- Ban hay nhap vao so con cuu: ");
                int n = int.Parse(Console.ReadLine());
                this._c = new int[n];
                for (int i = 0; i < this._c.Length; i++)
                {
                    Console.Write("\n   {0} con", i + 1);
                }
            }

            //so con
            public override void SinhCon()
            {
                base.SinhCon();
                Random r = new Random();
                int n = r.Next(0, 5);
                Console.Write("- So con cuu duoc sinh ra la: " + n);
            }
            //luong sua
            public override void LuongSua()
            {
                base.LuongSua();
                Random r = new Random();
                int n = r.Next(0, 5);
                Console.Write("\n- So lit sua la: " + n);
            }

            //tieng keu
            public override void TiengKeu()
            {
                base.TiengKeu();
                Console.WriteLine("\n- Tieng keu nghe duoc: cuuuuuu");
            }
        }
        public class De : GiaSuc
        {
            //thuoc tinh
            protected int[] _d;
            //property
            public int this[int i]
            {
                get
                {
                    return this._d[i];
                }
                set
                {
                    this._d[i] = value;
                }
            }
            public int N
            {
                get
                {
                    return this._d.Length;
                }
            }
            //khoi tao.
            public De()
                : base()
            {
                this._d = new int[3] { 1, 2, 3 };
            }
            public De(int sua, int con, int[] d)
                : base(sua, con)
            {
                this._d = new int[d.Length];
                for (int i = 0; i < d.Length; i++)
                {
                    this._d[i] = d[i];
                }
            }
            public De(GiaSuc Gs, De d)
                : base(Gs)
            {
                this._d = new int[d.N];
                for (int i = 0; i < d.N; i++)
                {
                    this._d[i] = d[i];
                }
            }
            //nhap
            public void Nhap()
            {
                Console.WriteLine("\n\n- Ban hay nhap vao so con de: ");
                int n = int.Parse(Console.ReadLine());
                this._d = new int[n];
                for (int i = 0; i < this._d.Length; i++)
                {
                    Console.Write("\n {0} con", i + 1);
                }
            }

            //so con
            public override void SinhCon()
            {
                base.SinhCon();
                Random r = new Random();
                int n = r.Next(0, 5);
                Console.Write("- So con de duoc sinh ra la: " + n);
            }
            //luong sua
            public override void LuongSua()
            {
                base.LuongSua();
                Random r = new Random();
                int n = r.Next(0, 15);
                Console.Write("\n- So lit sua la: " + n);
            }

            //tieng keu
            public override void TiengKeu()
            {
                base.TiengKeu();
                Console.WriteLine("\n- Tieng keu nghe duoc: deeeee");
            }

        }
        public static void Main(string[] args)
        {
            Bo b = new Bo();
            b.Nhap();
            b.TiengKeu();
            b.SinhCon();
            b.LuongSua();

            Cuu c = new Cuu();
            c.Nhap();
            c.TiengKeu();
            c.SinhCon();
            c.LuongSua();

            De d = new De();
            d.Nhap();
            d.TiengKeu();
            d.SinhCon();
            d.LuongSua();

            Console.ReadLine();
        }
    }
}
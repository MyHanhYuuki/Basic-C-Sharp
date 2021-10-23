// Kế thừa- Nông trại
// Một nông trại chăn nuôi có 3 loại gia súc: bò, cừu, và dê.Mỗi loại gia súc đều có thể sinh con, cho sữa và phát ra tiếng kêu riêng của chúng. Khi đói, các gia súc sẽ phát ra tiếng kêu để đòi ăn.Sau một thời gian chăn nuôi, người chủ nông trại muốn thống kê xem trong nông trại có bao nhiêu gia súc ở mỗi loại, tổng số lít sữa mà tất cả các gia súc của ông đã cho. Áp dụng kế thừa, xây dựng chương trình cho phép người chủ nông trại nhập vào số lượng gia súc ban đầu ở mỗi loại.
// a.Một hôm người chủ nông trại đi vắng, tất cả gia súc trong nông trại đều đói. Hãy cho biết những tiếng kêu nghe được trong nông trại.
// b.Tính tổng số lượng sữa thu được của tất cả gia súc. Biết rằng số lít sữa mỗi gia súc cho là ngẫu nhiên nhưng trong giới hạn sau:
//  Bò: 0 – 20 lít.
//  Cừu: 0 – 5 lít.
//  Dê: 0 – 10 lít.

using System;

namespace Bai04
{
    class Program
    {
        public class Dongvat
        {
            protected int _Sua;
            protected string _Keu;


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

            //Khoi tao.
            public Dongvat()
            {
                this._Sua = 1;
                this._Keu = "";
            }

            public Dongvat(int Sua, string Keu)
            {
                this._Sua = Sua;
                this._Keu = Keu;
            }

            public Dongvat(Dongvat Dv)
            {
                this._Sua = Dv._Sua;
                this._Keu = Dv._Keu;
            }

            //Luong sua.
            public virtual void LuongSua()
            {
            }
            //Tieng keu.
            public virtual void TiengKeu()
            {
            }
        }

        // Con Bo.
        public class Bo : Dongvat
        {
            protected int[] _b;
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
            // Khoi tao.
            public Bo()
                      : base()
            {
                this._b = new int[3] { 1, 2, 3 };
            }
            public Bo(int Sua, string Keu, int[] b)
                      : base(Sua, Keu)
            {
                this._b = new int[b.Length];
                for (int i = 0; i < b.Length; i++)
                {
                    this._b[i] = b[i];
                }
            }
            public Bo(Dongvat Dv, Bo b)
                          : base(Dv)
            {
                this._b = new int[b.N];
                for (int i = 0; i < b.N; i++)
                {
                    this._b[i] = b[i];
                }
            }
            // Nhap.
            public int Nhap(out int n)
            {
                Console.WriteLine("- Ban hay nhap vao so con Bo: ");
                n = int.Parse(Console.ReadLine());
                return n;
            }

            // Luong sua.
            public int LuongSua(out int SuaBo)
            {
                Random r = new Random();
                SuaBo = r.Next(0, 20);
                Console.Write("\n- So lit sua moi con Bo cho la: {0} lit ", SuaBo);
                return SuaBo;
            }

            // Tieng keu.
            public override void TiengKeu()
            {
                base.TiengKeu();
                Console.WriteLine("\n- Tieng keu nghe duoc: boooooo");
            }

        }

        // Con Cuu.
        public class Cuu : Dongvat
        {
            protected int[] _c;
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

            // Khoi tao.
            public Cuu()
                : base()
            {
                this._c = new int[3] { 1, 2, 3 };
            }
            public Cuu(int Sua, string Keu, int[] c)
                : base(Sua, Keu)
            {
                this._c = new int[c.Length];
                for (int i = 0; i < c.Length; i++)
                {
                    this._c[i] = c[i];
                }
            }
            public Cuu(Dongvat Dv, Cuu c)
                : base(Dv)
            {
                this._c = new int[c.N];
                for (int i = 0; i < c.N; i++)
                {
                    this._c[i] = c[i];
                }
            }

            // Nhap.
            public void Nhap(out int m)
            {
                Console.WriteLine("\n\n- Ban hay nhap vao so con Cuu: ");
                m = int.Parse(Console.ReadLine());
            }

            // Luong sua.
            public int LuongSua(out int SuaCuu)
            {
                Random r = new Random();
                SuaCuu = r.Next(0, 5);
                Console.Write("\n- So lit sua moi con Cuu cho la: {0} lit", SuaCuu);
                return SuaCuu;
            }

            // Tieng keu.
            public override void TiengKeu()
            {
                base.TiengKeu();
                Console.WriteLine("\n- Tieng keu nghe duoc: cuuuuuu");
            }
        }

        // Con De.
        public class De : Dongvat
        {
            protected int[] _d;
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
            public De(int Sua, string Keu, int[] d)
                : base(Sua, Keu)
            {
                this._d = new int[d.Length];
                for (int i = 0; i < d.Length; i++)
                {
                    this._d[i] = d[i];
                }
            }
            public De(Dongvat Dv, De d)
                : base(Dv)
            {
                this._d = new int[d.N];
                for (int i = 0; i < d.N; i++)
                {
                    this._d[i] = d[i];
                }
            }

            // Nhap
            public void Nhap(out int p)
            {
                Console.WriteLine("\n\n- Ban hay nhap vao so con De: ");
                p = int.Parse(Console.ReadLine());
            }

            // Luong sua
            public int LuongSua(out int SuaDe)
            {

                Random r = new Random();
                SuaDe = r.Next(0, 15);
                Console.Write("\n- So lit sua moi con De cho la: {0} lit", SuaDe);
                return SuaDe;
            }

            // Tieng keu
            public override void TiengKeu()
            {
                base.TiengKeu();
                Console.WriteLine("\n- Tieng keu nghe duoc: deeeeee");
            }

        }
        public static void Main(string[] args)
        {
            int n, m, p;

            Bo b = new Bo();
            b.Nhap(out n);
            b.TiengKeu();
            b.LuongSua(out int SuaBo);

            Cuu c = new Cuu();
            c.Nhap(out m);
            c.TiengKeu();
            c.LuongSua(out int SuaCuu);

            De d = new De();
            d.Nhap(out p);
            d.TiengKeu();
            d.LuongSua(out int SuaDe);

            Console.WriteLine("\n\n- Tong so gia suc ma chu nong trai co la: {0} con", n + m + p);
            Console.WriteLine("\n- Tong luong sua cua tat ca gia suc cho la: {0} lit", n * SuaBo + m * SuaCuu + p * SuaDe);
            Console.ReadLine();
        }
    }
}

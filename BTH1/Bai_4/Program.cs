// Viết chương trình cài đặt đối tượng phân số, trong đó phân số được định nghĩa gồm có tử số và mẫu số với kiểu dữ liệu là số nguyên. Hãy cài đặt các thao tác trên đối tượng phân số này:
// a. Nhập vào một phân số, rút gọn phân số và xuất ra kết quả
// b. Nhập vào hai phân số, xuất ra các giá trị cộng, trừ, nhân, chia 2 phân số

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    class Program
    {
        // Ham phan so
        class phanso
        {
            private float tu, mau;
            public float TuSo
            {
                get { return tu; }
                set { tu = value; }
            }
            public float MauSo
            {
                get { return mau; }
                set
                {
                    if (value != 0)
                        mau = value;
                }
            }

            // Ham nhap phan so
            public void nhap()
            {
                Console.Write("+ Nhap tu so: ");
                tu = Convert.ToInt32(Console.ReadLine());
                do
                {
                    Console.Write("+ Nhap tu mau: ");
                    mau = Convert.ToInt32(Console.ReadLine());

                } while (mau == 0);
            }

            // Ham cong 2 phan so
            public static phanso operator +(phanso phanSo1, phanso phanSo2)
            {
                phanso phansoKQ = new phanso();
                phansoKQ.TuSo = phanSo1.TuSo * phanSo2.MauSo + phanSo2.TuSo * phanSo1.MauSo;
                phansoKQ.MauSo = phanSo1.MauSo * phanSo2.MauSo;
                return phansoKQ;
            }

            // Ham tru 2 phan so
            public static phanso operator -(phanso phanSo1, phanso phanSo2)
            {
                phanso phansoKQ = new phanso();
                phansoKQ.TuSo = phanSo1.TuSo * phanSo2.MauSo - phanSo2.TuSo * phanSo1.MauSo;
                phansoKQ.MauSo = phanSo1.MauSo * phanSo2.MauSo;
                return phansoKQ;
            }

            // Ham nhan 2 phan so
            public static phanso operator *(phanso phanSo1, phanso phanSo2)
            {
                phanso phansoKQ = new phanso();
                phansoKQ.TuSo = phanSo1.TuSo * phanSo2.TuSo;
                phansoKQ.MauSo = phanSo1.MauSo * phanSo2.MauSo;
                return phansoKQ;
            }

            // Ham chia 2 phan so
            public static phanso operator /(phanso phanSo1, phanso phanSo2)
            {
                phanso phansoKQ = new phanso();
                phansoKQ.TuSo = phanSo1.TuSo * phanSo2.MauSo;
                phansoKQ.MauSo = phanSo1.MauSo * phanSo2.TuSo;
                return phansoKQ;
            }

            // Ham tim uoc chung cua tu so va mau so
            public float UCLN(float a, float b)
            {
                a = Math.Abs(tu);
                b = Math.Abs(mau);
                while (a != b && b != 0 && a != 0)
                {
                    if (a > b) a = a - b;
                    else b = b - a;
                }
                return a;
            }

            // Ham rut gon phan so
            public phanso RutGonPhanSo()
            {
                phanso rutgon = new phanso();
                float uoc = UCLN(tu, mau);
                if (uoc != 0)
                {
                    rutgon.tu = tu / uoc;
                    rutgon.mau = mau / uoc;
                }
                else
                {
                    rutgon.tu = tu;
                    rutgon.mau = mau;
                }
                return rutgon;
            }

            public void xuat()
            {
                Console.Write(" {0}/{1} ", tu, mau);
            }
        }

        // b) 2 phan so
        class chuoiphanso
        {
            phanso[] ps;
            int n=2;
            public void Nhap()
            {
                ps = new phanso[n];
                for (int i = 0; i < n; i++)
                {
                    ps[i] = new phanso();
                    Console.WriteLine("\n- Phan so thu {0}:", i + 1);
                    ps[i].nhap();
                    ps[i] = ps[i].RutGonPhanSo();
                }
            }
            public void Xuat()
            {
                for (int i = 0; i < n; i++)
                {
                    ps[i].xuat();
                    ps[i] = ps[i].RutGonPhanSo();
                    Console.Write(" , ");
                }
            }
           
            public phanso tinhtong()
            {
                phanso tong = ps[0];
                for (int i = 1; i < n; i++)
                {
                    tong = tong + ps[i];
                }
                return tong;
            }
            public phanso tinhhieu()
            {
                phanso hieu = ps[0];
                for (int i = 1; i < n; i++)
                {
                    hieu = hieu - ps[i];
                }
                return hieu;
            }
            public phanso tinhtich()
            {
                phanso tich = ps[0];
                for (int i = 1; i < n; i++)
                {
                    tich = tich * ps[i];
                }
                return tich;
            }

            public phanso tinhthuong()
            {
                phanso thuong = ps[0];
                for (int i = 1; i < n; i++)
                {
                    thuong = thuong / ps[i];
                }
                return thuong;
            }
        }
                // Ham Main
        static void Main(string[] args)
        {
            Console.WriteLine("\n * Mot phan so * \n ");
            phanso p = new phanso();
            Console.WriteLine("- Nhap vao phan so: ");
            p.nhap();
            Console.WriteLine("- Xuat phan so: ");
            p.xuat();
            Console.WriteLine("\n - Rut gon phan so (neu co):");
            phanso rutgon = p.RutGonPhanSo();
            rutgon.xuat();

            Console.WriteLine("\n\n * Hai phan so * ");
            chuoiphanso c = new chuoiphanso();
            c.Nhap();
            Console.WriteLine("\n- Rut gon 2 phan so (neu co):");
            c.Xuat();

            phanso tong = c.tinhtong();
            Console.Write("\n -> Tong cua 2 phan so la : \n");
            tong.xuat();

            phanso hieu = c.tinhhieu();
            Console.Write("\n -> Hieu cua 2 phan so la : \n");
            hieu.xuat();

            phanso tich = c.tinhtich();
            Console.Write("\n -> Tich cua 2 phan so la : \n");
            tich.xuat();

            phanso thuong = c.tinhthuong();
            Console.Write("\n -> Thuong cua 2 phan so la : \n");
            thuong.xuat();
            Console.ReadKey();
        }
    }
}

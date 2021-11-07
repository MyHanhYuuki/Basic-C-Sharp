 // Thoi Gian Hien Hanh.
using System;

namespace Cau03
{
    class ThoiGian
    {
        private int ngay;
        private int thang;
        private int nam;
        private int gio;
        private int phut;
        private int giay;

        public int Ngay
        {
            get
            {
                return ngay;
            }
            set
            {
                ngay = value;
            }
        }

        public int Thang
        {
            get
            {
                return thang;
            }
            set
            {
                thang = value;
            }
        }

        public int Nam
        {
            get
            {
                return nam;
            }
            set
            {
                nam = value;
            }
        }

        public int Gio
        {
            get
            {
                return gio;
            }
            set
            {
                gio = value;
            }
        }

        public int Phut
        {
            get
            {
                return phut;
            }
            set
            {
                phut = value;
            }
        }

        public int Giay
        {
            get
            {
                return giay;
            }
            set
            {
                giay = value;
            }
        }
        public ThoiGian()
        {
            DateTime dt = DateTime.Now;
            ngay = dt.Day;
            thang = dt.Month;
            nam = dt.Year;
            gio = dt.Hour;
            phut = dt.Minute;
            giay = dt.Second;
        }

        public ThoiGian(int ngay, int thang, int nam, int gio, int phut, int giay)
        {
            this.ngay = ngay;
            this.thang = thang;
            this.nam = nam;
            this.gio = gio;
            this.phut = phut;
            this.giay = giay;
        }

        public ThoiGian(DateTime dt)
        {
            ngay = dt.Day;
            thang = dt.Month;
            nam = dt.Year;
            gio = dt.Hour;
            phut = dt.Minute;
            giay = dt.Second;
        }
        public void HienThiThoiGian()
        {
            Console.WriteLine("Thoi gian hien hanh la: {0}/{1}/{2} - {3}:{4}:{5}", this.ngay, this.thang, this.nam, this.gio, this.phut, this.giay);
        }

        class TestThoiGian
        {
            static void Main(string[] args)
            {
                ThoiGian t = new ThoiGian();
                t.HienThiThoiGian();
            }
        }
    }
}
    
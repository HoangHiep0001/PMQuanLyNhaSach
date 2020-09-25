using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_NHASACH
{
    class ChiTietPhieuNhap
    {
        public ChiTietPhieuNhap(int mactpn, int mapn, string mads, int soluong, int dongia,int thanhtien)
        {
            this.maCTPN = mactpn;
            this.maPN = mapn;
            this.maDS = mads;
            this.soLuong = soluong;
            this.donGia = dongia;
            this.thanhTien = thanhTien;
        }

        private int mactpn;
        private int mapn;
        private string mads;
        private int soluong;
        private int dongia;
        private int thanhtien;


        public int maCTPN
        {
            get { return mactpn; }
            set { mactpn = value; }
        }

        public int maPN
        {
            get { return mapn; }
            set { mapn = value; }
        }

        public string maDS
        {
            get { return mads; }
            set { mads = value; }
        }

        private int soLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        private int donGia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        private int thanhTien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
    }
}

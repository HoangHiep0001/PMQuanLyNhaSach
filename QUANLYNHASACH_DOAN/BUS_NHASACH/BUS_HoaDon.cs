using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_NHASACH;

namespace BUS_NHASACH
{
    public class BUS_HoaDon
    {
        private static BUS_HoaDon instance;

        public static BUS_HoaDon Instance
        {
            get { if (instance == null) instance = new BUS_HoaDon(); return BUS_HoaDon.instance; }
            private set { BUS_HoaDon.instance = value; }
        }

        public bool insertBill(int manv,string makh)
        {
            return DAL_HoaDon.Instance.insertBill(manv,makh);
        }

        //public int getMaxBill()
        //{
        //    return DAL_HoaDon.Instance.getMaxBill();
        //}

        public int layHoaDonChuaThanhToan()
        {
            return DAL_HoaDon.Instance.layHoaDonChuaThanhToan();
        }

        public void thanhToanHoaDon(int mahd, int tongTien)
        {
            DAL_HoaDon.Instance.thanhToanHoaDon(mahd, tongTien);
        }

        public DataTable layDanhSachHoaDonTheoThangNam(int thang, int nam)
        {
            return DAL_HoaDon.Instance.layDanhSachHoaDonTheoThangNam(thang, nam);
        }

    }
}

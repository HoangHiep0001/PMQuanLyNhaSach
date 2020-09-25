using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_NHASACH;

namespace DAL_NHASACH
{
    public class DAL_HoaDon
    {
        private static DAL_HoaDon instance;

        public static DAL_HoaDon Instance
        {
            get { if (instance == null) instance = new DAL_HoaDon(); return DAL_HoaDon.instance; }
            private set { DAL_HoaDon.instance = value; }
        }

        public bool insertBill(int manv,string makh)
        {
            string query = "insert into HOADON(NGAYLAP,MANV,MAKH,TONGTIEN) values (GETDATE(), " + manv + ",'"+makh+"' ,0)";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        //public int getMaxBill()
        //{
        //    string query = "select MAX(MAHD) from HOADON";
        //    if (DataProvider.Instance.ExecuteScalar(query) == null)
        //        return -1;
        //    return (int)DataProvider.Instance.ExecuteScalar(query);
        //}

        public int layHoaDonChuaThanhToan()
        {
            string query = "SELECT MAHD FROM HOADON WHERE TINHTRANG =0";
            if (DataProvider.Instance.ExecuteScalar(query) == null)
                return -1;
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public void thanhToanHoaDon(int mahd, int tongTien)
        {
            string query = "UPDATE HOADON SET  TINHTRANG = 1, TONGTIEN = " + tongTien + " WHERE MAHD= " + mahd;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable layDanhSachHoaDonTheoThangNam(int thang,int nam)
        {
            string query = "SELECT MAHD AS 'MÃ HÓA ĐƠN', NGAYLAP AS 'NGÀY LẬP', MANV AS 'MÃ NHÂN VIÊN', TONGTIEN AS 'TỔNG TIỀN'  FROM HOADON WHERE TINHTRANG = 1 AND MONTH(NGAYLAP)=" + thang + " AND YEAR(NGAYLAP)=" + nam;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }



    }
}

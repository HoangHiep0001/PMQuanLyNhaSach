using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_NHASACH;

namespace DAL_NHASACH
{
    public class DAL_ChiTietHoaDon
    {
        private static DAL_ChiTietHoaDon instance;

        public static DAL_ChiTietHoaDon Instance
        {
            get { if (instance == null) instance = new DAL_ChiTietHoaDon(); return DAL_ChiTietHoaDon.instance; }
            private set { DAL_ChiTietHoaDon.instance = value; }
        }

        public DataTable layDanhSachChiTietHoaDon(int mahd)
        {
            string query = "SELECT * FROM CHITIETHOADON WHERE MAHD=" + mahd;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public bool addBillDetail( int mahd,int masach,int soluong)
        {
            if (DAL_HoaDon.Instance.layHoaDonChuaThanhToan() == -1)
                return false;
            else
            {
                string query = "USP_addBillDetail @mahd , @masach , @soluong";
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahd, masach, soluong }) > 0;
            }
        }

        public bool deleteBillDetail(int mahd,int macthd)
        {
            string query = "DELETE FROM  CHITIETHOADON WHERE MAHD=" + mahd + " AND MACTHD=" + macthd;
            int a= DataProvider.Instance.ExecuteNonQuery(query) ;
            return a>0;
        }

   
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_NHASACH;

namespace DAL_NHASACH
{
    public class DAL_KhachHang
    {
        private static DAL_KhachHang instance;

        public static DAL_KhachHang Instance
        {
            get { if (instance == null) instance = new DAL_KhachHang(); return DAL_KhachHang.instance; }
            private set { DAL_KhachHang.instance = value; }
        }

        public List<KhachHang> layDanhSachKhachHang()
        {
            List<KhachHang> listKhachHang = new List<KhachHang>();

            string query = "select * from KHACHHANG ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                KhachHang info = new KhachHang(item);
                listKhachHang.Add(info);
            }
            return listKhachHang;
        }


    }
}

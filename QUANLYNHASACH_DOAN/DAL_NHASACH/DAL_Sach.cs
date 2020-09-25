using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_NHASACH;

namespace DAL_NHASACH
{
    public class DAL_Sach
    {
        private static DAL_Sach instance;

        public static DAL_Sach Instance
        {
            get { if (instance == null) instance = new DAL_Sach(); return DAL_Sach.instance; }
            private set { DAL_Sach.instance = value; }
        }

        public List<DauSach> layDanhSachSach()
        {
            List<DauSach> listSach = new List<DauSach>();

            string query = "select * from DAUSACH ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DauSach info = new DauSach(item);
                listSach.Add(info);
            }
            return listSach;
        }
        public string layTenTacGiaBangMaSach(int mads)
        {
            string query = "SELECT TACGIA FROM DAUSACH WHERE MADS=" + mads;
            return (DataProvider.Instance.ExecuteScalar(query)).ToString();
        }

        public int laySLSach(int mads)
        {
            string query = "SELECT SOLUONG FROM DAUSACH WHERE MADS=" + mads;
            return (int)(DataProvider.Instance.ExecuteScalar(query));
        }


    }
}

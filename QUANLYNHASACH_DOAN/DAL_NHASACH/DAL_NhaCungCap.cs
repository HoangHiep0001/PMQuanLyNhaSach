using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_NHASACH;


namespace DAL_NHASACH
{
    public class DAL_NhaCungCap
    {
        private static DAL_NhaCungCap instance;

        public static DAL_NhaCungCap Instance
        {
            get { if (instance == null) instance = new DAL_NhaCungCap(); return DAL_NhaCungCap.instance; }
            private set { DAL_NhaCungCap.instance = value; }
        }

        public List<NhaCungCap> layDanhSachNhaCungCap()
        {
            List<NhaCungCap> listNhaCungCap = new List<NhaCungCap>();

            string query = "SELECT * FROM NHACUNGCAP ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhaCungCap info = new NhaCungCap(item);
                listNhaCungCap.Add(info);
            }
            return listNhaCungCap;
        }

    }
}

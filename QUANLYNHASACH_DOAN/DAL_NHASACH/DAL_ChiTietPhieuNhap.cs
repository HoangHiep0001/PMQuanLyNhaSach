using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_NHASACH
{
    public class DAL_ChiTietPhieuNhap
    {
        private static DAL_ChiTietPhieuNhap instance;

        public static DAL_ChiTietPhieuNhap Instance
        {
            get { if (instance == null) instance = new DAL_ChiTietPhieuNhap(); return DAL_ChiTietPhieuNhap.instance; }
            private set { DAL_ChiTietPhieuNhap.instance = value; }
        }

        public DataTable layDanhSachChiTietPhieuNhap(int mapn)
        { 
            string query = "SELECT * FROM CHITIETPHIEUNHAP WHERE MAPN = " + mapn;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public void addChiTietPhieuNhap(string mancc, int masach, int soluong,int manv)
        {
            if (DAL_PhieuNhap.Instance.layMaPhieuNhapTheoNhaCungCap(mancc) == -1)
            {
                DAL_PhieuNhap.Instance.themPhieuNhapSach(manv, mancc);
                int mapn = DAL_PhieuNhap.Instance.layMaxMaPhieuNhap();
                string query = "USP_themChiTietPhieuNhap @mapn , @masach , @soluong";
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { mapn, masach, soluong }) ;
            }
            else
            {
                int mapn = DAL_PhieuNhap.Instance.layMaPhieuNhapTheoNhaCungCap(mancc);
                string query = "USP_themChiTietPhieuNhap @mapn , @masach , @soluong";
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { mapn, masach, soluong }) ;
            }
        }

        public bool delChiTietPhieuNhap(int mapn, int mactpn)
        {
            string query = "DELETE FROM  CHITIETPHIEUNHAP WHERE MAPN=" + mapn + " AND MACTPN=" + mactpn;
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

    }
}

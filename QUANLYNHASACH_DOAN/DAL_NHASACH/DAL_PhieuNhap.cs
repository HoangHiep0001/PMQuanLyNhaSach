using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_NHASACH
{
    public class DAL_PhieuNhap
    {
        private static DAL_PhieuNhap instance;

        public static DAL_PhieuNhap Instance
        {
            get { if (instance == null) instance = new DAL_PhieuNhap(); return DAL_PhieuNhap.instance; }
            private set { DAL_PhieuNhap.instance = value; }
        }

        public bool themPhieuNhapSach(int manv, string mancc)
        {
            string query = " insert into PHIEUNHAP(NGAYLAP,MANV, MANCC,TONGTIEN) VALUES(GETDATE(), "+manv+" ,'"+ mancc +"' ,0)";
            return DataProvider.Instance.ExecuteNonQuery(query,new object[] { manv, mancc } ) > 0;
        }

        public int layMaPhieuNhapTheoNhaCungCap(string mancc)
        {
            string query = "SELECT MAPN FROM PHIEUNHAP WHERE MANCC = '" + mancc + "' AND TINHTRANG = 0";
            if (DataProvider.Instance.ExecuteScalar(query) == null) return -1;
            return (int)DataProvider.Instance.ExecuteScalar(query);    
        }

        public int layMaxMaPhieuNhap()
        {
            string query = "SELECT MAX(MAPN) FROM PHIEUNHAP";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public void thanhToanPhieuNhap(int mapn, int tongTien)
        {
            string query = "USP_thanhToanPhieuNhap @mapn , @tongtien ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { mapn, tongTien });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_NHASACH;

namespace DAL_NHASACH
{
    public class DAL_NhanVien
    {
        private static DAL_NhanVien instance;
        public static DAL_NhanVien Instance
        {
            get { if (instance == null) instance = new DAL_NhanVien(); return DAL_NhanVien.instance; }
            private set { DAL_NhanVien.instance = value; }
        }

        public List<NhanVien> layDanhSachNhanVien()
        {
            List<NhanVien> listNhanVien = new List<NhanVien>();

            string query = "select * from NHANVIEN ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien info = new NhanVien(item);
                listNhanVien.Add(info);
            }
            return listNhanVien;
        }

        public string layChucVuNVTheoMaNV(int manv)
        {
            if (manv == -1) return null;
            string query = "SELECT MACV FROM NHANVIEN WHERE MANV=" + manv;
            return DataProvider.Instance.ExecuteScalar(query).ToString();
        }

        public DataTable layThongTinNhanVienTheoMaNhanVien(int manv)
        {
            string query = "SELECT * FROM NHANVIEN WHERE MANV=" + manv;
            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}

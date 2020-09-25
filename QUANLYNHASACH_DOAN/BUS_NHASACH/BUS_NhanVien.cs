using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_NHASACH;
using DAL_NHASACH;
using System.Data;

namespace BUS_NHASACH
{
    public class BUS_NhanVien
    {
        private static BUS_NhanVien instance;

        public static BUS_NhanVien Instance
        {
            get { if (instance == null) instance = new BUS_NhanVien(); return BUS_NhanVien.instance; }
            private set { BUS_NhanVien.instance = value; }
        }

        public List<NhanVien> layDSNhanVien()
        {
            return DAL_NhanVien.Instance.layDanhSachNhanVien();
        }

        public DataTable layThongTinNhanVienTheoMaNhanVien(int manv)
        {
            return DAL_NhanVien.Instance.layThongTinNhanVienTheoMaNhanVien(manv);
        }

        public string layChucVuNVTheoMaNV(int manv)
        {
            return DAL_NhanVien.Instance.layChucVuNVTheoMaNV(manv);
        }
    }
}

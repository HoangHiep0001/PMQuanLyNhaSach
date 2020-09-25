using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_NHASACH;

namespace BUS_NHASACH
{
    public class BUS_ChiTietPhieuNhap
    {
        private static BUS_ChiTietPhieuNhap instance;

        public static BUS_ChiTietPhieuNhap Instance
        {
            get { if (instance == null) instance = new BUS_ChiTietPhieuNhap(); return BUS_ChiTietPhieuNhap.instance; }
            private set { BUS_ChiTietPhieuNhap.instance = value; }
        }

        public DataTable layDanhSachChiTietPhieuNhap(int mapn)
        {
            return DAL_ChiTietPhieuNhap.Instance.layDanhSachChiTietPhieuNhap(mapn);
        }

        public void themChiTietPhieuNhap(string mancc, int masach, int soluong, int manv)
        {
            DAL_ChiTietPhieuNhap.Instance.addChiTietPhieuNhap(mancc, masach, soluong, manv);
        }

        public bool delChiTietPhieuNhap(int mapn, int mactpn)
        {
            return DAL_ChiTietPhieuNhap.Instance.delChiTietPhieuNhap(mapn, mactpn);
        }
    }
}

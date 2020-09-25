using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_NHASACH;

namespace BUS_NHASACH
{
    public class BUS_PhieuNhap
    {
        private static BUS_PhieuNhap instance;

        public static BUS_PhieuNhap Instance
        {
            get { if (instance == null) instance = new BUS_PhieuNhap(); return BUS_PhieuNhap.instance; }
            private set { BUS_PhieuNhap.instance = value; }
        }

        public bool themPhieuNhapSach(int manv, string mancc)
        {
            return DAL_PhieuNhap.Instance.themPhieuNhapSach(manv, mancc);
        }

        public int layMaPhieuNhapTheoNhaCungCap(string mancc)
        {
            return DAL_PhieuNhap.Instance.layMaPhieuNhapTheoNhaCungCap(mancc);
        }

        public void thanhToanPhieuNhap(int  mapn, int tongTien)
        {
            DAL_PhieuNhap.Instance.thanhToanPhieuNhap(mapn, tongTien);
        }

    }
}

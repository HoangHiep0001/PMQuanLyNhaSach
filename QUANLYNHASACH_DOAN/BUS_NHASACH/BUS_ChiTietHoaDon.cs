using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_NHASACH;

namespace BUS_NHASACH
{
    public class BUS_ChiTietHoaDon
    {
        private static BUS_ChiTietHoaDon instance;

        public static BUS_ChiTietHoaDon Instance
        {
            get { if (instance == null) instance = new BUS_ChiTietHoaDon(); return BUS_ChiTietHoaDon.instance; }
            private set { BUS_ChiTietHoaDon.instance = value; }
        }

        public bool addBillDeTail(int mahd, int masach, int soluong)
        {
            return DAL_ChiTietHoaDon.Instance.addBillDetail(mahd, masach, soluong);
        }

        public DataTable layDanhSachChiTietHoaDon(int mahd)
        {
            return DAL_ChiTietHoaDon.Instance.layDanhSachChiTietHoaDon(mahd);
        }

        public bool deleteBillDetail(int mahd,int macthd)
        {
            return DAL_ChiTietHoaDon.Instance.deleteBillDetail(mahd,macthd);
        }




    }
}

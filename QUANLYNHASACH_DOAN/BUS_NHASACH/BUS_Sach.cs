using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_NHASACH;
using DAL_NHASACH;

namespace BUS_NHASACH
{
    public class BUS_Sach
    {
        private static BUS_Sach instance;

        public static BUS_Sach Instance
        {
            get { if (instance == null) instance = new BUS_Sach(); return BUS_Sach.instance; }
            private set { BUS_Sach.instance = value; }
        }

        public List<DauSach> layDanhSachSach()
        {
            return DAL_Sach.Instance.layDanhSachSach();
        }
        public string layTenTacGiaBangMaSach(int mads)
        {
            return DAL_Sach.Instance.layTenTacGiaBangMaSach(mads);
        }

        public int laySLSach(int mads)
        {
            return DAL_Sach.Instance.laySLSach(mads);
        }


    }
}

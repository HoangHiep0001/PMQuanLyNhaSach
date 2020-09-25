using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_NHASACH;
using DAL_NHASACH;

namespace BUS_NHASACH
{
    public class BUS_NhaCungCap
    {
        private static BUS_NhaCungCap instance;

        public static BUS_NhaCungCap Instance
        {
            get { if (instance == null) instance = new BUS_NhaCungCap(); return BUS_NhaCungCap.instance; }
            private set { BUS_NhaCungCap.instance = value; }
        }

        public List<NhaCungCap> layDanhSachNhaCungCap()
        {
            return DAL_NhaCungCap.Instance.layDanhSachNhaCungCap();
        }

    }
}

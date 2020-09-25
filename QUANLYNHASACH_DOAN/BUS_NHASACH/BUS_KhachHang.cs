using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_NHASACH;
using DTO_NHASACH;

namespace BUS_NHASACH
{
   public class BUS_KhachHang
    {
        private static BUS_KhachHang instance;

        public static BUS_KhachHang Instance
        {
            get { if (instance == null) instance = new BUS_KhachHang(); return BUS_KhachHang.instance; }
            private set { BUS_KhachHang.instance = value; }
        }

        public List<KhachHang> layDanhSachKhachHang()
        {
            return DAL_KhachHang.Instance.layDanhSachKhachHang();
        }

        
    }
}

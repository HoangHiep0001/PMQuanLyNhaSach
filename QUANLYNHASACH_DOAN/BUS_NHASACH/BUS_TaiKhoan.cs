using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_NHASACH;

namespace BUS_NHASACH
{
    public class BUS_TaiKhoan
    {
        private static BUS_TaiKhoan instance;
        public static BUS_TaiKhoan Instance
        {
            get { if (instance == null) instance = new BUS_TaiKhoan(); return instance; }
            private set { instance = value; }
        }

        public bool kiemTraTaiKhoan(string userName,string pass)
        {
            return DAL_TaiKhoan.Instance.kiemTraTaiKhoan(userName, pass);
        }

        public int layMaNVTheoUserNamePassWord(string userName, string pass)
        {
            return DAL_TaiKhoan.Instance.layMaNVTheoUserNamePassWord(userName, pass);
        }
    }
}

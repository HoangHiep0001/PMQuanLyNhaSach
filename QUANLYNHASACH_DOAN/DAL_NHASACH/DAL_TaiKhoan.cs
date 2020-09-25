using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_NHASACH
{
    public class DAL_TaiKhoan
    {
        private static DAL_TaiKhoan instance;
        public static DAL_TaiKhoan Instance
        {
            get { if (instance == null) instance = new DAL_TaiKhoan(); return DAL_TaiKhoan.instance; }
            private set { DAL_TaiKhoan.instance = value; }
        }
        public bool kiemTraTaiKhoan(string userName, string pass)
        {
            if ((userName == null) || (pass == null)) return false;
            string query= "SELECT * FROM TAIKHOAN WHERE USERNAME='" +userName+"' AND PASSWORD= '" +pass+"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public int layMaNVTheoUserNamePassWord(string userName, string pass)
        {
            string query = "SELECT MANV FROM TAIKHOAN WHERE USERNAME='" + userName + "' AND PASSWORD= '" + pass + "'";
            if (DataProvider.Instance.ExecuteScalar(query) == null) return -1;
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_NHASACH;

namespace QUANLYNHASACH_DOAN
{
    public partial class frmThongtinNhanVien : Form
    {
        private int manv;


        public frmThongtinNhanVien(int manv_dangnhap)
        {
            InitializeComponent();
            manv = manv_dangnhap;
            loadThongTinNhanVien(manv);
        }

   
        void loadThongTinNhanVien(int manv)
        {
            DataTable data = BUS_NhanVien.Instance.layThongTinNhanVienTheoMaNhanVien(manv);
            tbManv.Text = data.Rows[0]["MANV"].ToString();
            tbHoten.Text= data.Rows[0]["HOTEN"].ToString();
            tbSdt.Text = data.Rows[0]["SDT"].ToString();
            tbDiachi.Text = data.Rows[0]["DIACHI"].ToString();
            tbEmail.Text = data.Rows[0]["EMAIL"].ToString();
            tbChucvu.Text = data.Rows[0]["MACV"].ToString();
        }


    }
}

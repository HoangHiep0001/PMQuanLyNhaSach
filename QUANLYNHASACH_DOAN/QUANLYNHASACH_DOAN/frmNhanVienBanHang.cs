using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHASACH_DOAN
{
    public partial class frmNhanVienBanHang : Form
    {
        private int manv_login;



        public frmNhanVienBanHang(int manv_dangnhap)
        {
            InitializeComponent();
            manv_login = manv_dangnhap;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form frm = new frmThongtinNhanVien(manv_login);
            frm.ShowDialog();
        }

        private void laphoadon_Click(object sender, EventArgs e)
        {
            Form frm = new frmHoaDon(manv_login);
            frm.ShowDialog();
        }

        private void nhapsach_Click(object sender, EventArgs e)
        {
            Form frm = new frmNhapSach(manv_login);
            frm.ShowDialog();
        }

        private void thongke_Click(object sender, EventArgs e)
        {
            Form frm = new frmBaocao();
            frm.ShowDialog();
        }
    }
}

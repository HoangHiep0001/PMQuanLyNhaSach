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
    public partial class frmNhanvien_Quanly : Form
    {
        private int manv_login;

        public frmNhanvien_Quanly(int manv_dangnhap)
        {
            InitializeComponent();
            manv_login = manv_dangnhap;
        }
   

 
        private void logout1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thongtincanhan_Click(object sender, EventArgs e)
        {
            Form frm = new frmThongtinNhanVien(manv_login);
            frm.ShowDialog();
        }

        private void changepw_Click_1(object sender, EventArgs e)
        {
            Form frm = new frmDoiMatKhau();
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

        private void tracuusach_Click(object sender, EventArgs e)
        {
            Form frm = new frmTraCuuSach();
            frm.ShowDialog();
        }

        private void quanli_kh_Click(object sender, EventArgs e)
        {
            Form frm = new frmKhachhang();
            frm.ShowDialog();
        }

        private void quanli_nv_Click(object sender, EventArgs e)
        {
            Form frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void quanli_ncc_Click(object sender, EventArgs e)
        {
            Form frm = new frmNhacuncap();
            frm.ShowDialog();
        }

        private void thongke_Click(object sender, EventArgs e)
        {
            Form frm = new frmBaocao();
            frm.ShowDialog();
        }

        private void quanlisach_Click(object sender, EventArgs e)
        {
            Form frm = new frmQuanly_sach();
            frm.ShowDialog();
        }

        private void theloai_Click(object sender, EventArgs e)
        {
            Form frm = new frmQuanly_theloai();
            frm.ShowDialog();
        }

        private void quanlytheloaisach_Click(object sender, EventArgs e)
        {
            Form frm = new frmQuanly_theloai();
            frm.ShowDialog();
        }

        private void quanlysach_Click(object sender, EventArgs e)
        {
            Form frm = new frmQuanly_sach();
            frm.ShowDialog();
        }

        
    }
}
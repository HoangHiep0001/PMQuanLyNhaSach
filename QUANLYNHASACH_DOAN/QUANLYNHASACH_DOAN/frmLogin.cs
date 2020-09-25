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
using DTO_NHASACH;

namespace QUANLYNHASACH_DOAN
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
        //    Form frm = new frmDangki();
        //    frm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int manv = BUS_TaiKhoan.Instance.layMaNVTheoUserNamePassWord(tbUserName.Text, tbPassWord.Text);
            if (BUS_NhanVien.Instance.layChucVuNVTheoMaNV(manv)=="CV001")
            {
                int manv_login = BUS_TaiKhoan.Instance.layMaNVTheoUserNamePassWord(tbUserName.Text,tbPassWord.Text);
                Form frm = new frmNhanvien_Quanly(manv_login);
                frm.ShowDialog();
            }
            else if(BUS_NhanVien.Instance.layChucVuNVTheoMaNV(manv) == "CV002")
            {
                int manv_login = BUS_TaiKhoan.Instance.layMaNVTheoUserNamePassWord(tbUserName.Text, tbPassWord.Text);
                Form frm = new frmNhanVienBanHang(manv_login);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Thong tin tai khoan hoac mat khau khong chinh xac");
            }


        }
    }
}

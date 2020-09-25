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
    public partial class frmHoaDon : Form
    {
        int masach = 0;
        //int manv = 0;
        string makh;
        int manv_dangnhap;
        public frmHoaDon(int manv_login)
        {
            InitializeComponent();
            loadSach();
            manv_dangnhap = manv_login;
            LayThongTinNhanVienQuaMaNV(manv_dangnhap);
            loadDanhSachKhachHang();
        }

        void loadSach()
        {
            cbSach.DataSource = BUS_Sach.Instance.layDanhSachSach();
            cbSach.DisplayMember = "tenSach";
            cbSach.ValueMember = "maDS";
        }

        void loadDanhSachKhachHang()
        {
            cbKhachHang.DataSource = BUS_KhachHang.Instance.layDanhSachKhachHang();
            cbKhachHang.DisplayMember = "hoTen";
            cbKhachHang.ValueMember = "maKH";
        }

      
        void LayThongTinNhanVienQuaMaNV(int manv)
        {
            DataTable data = BUS_NhanVien.Instance.layThongTinNhanVienTheoMaNhanVien(manv_dangnhap);
            tbNhanVien.Text = data.Rows[0]["HOTEN"].ToString();
        }


        void loadChiTietHoaDon()
        {
            dgvChiTietHoaDon.DataSource = BUS_ChiTietHoaDon.Instance.layDanhSachChiTietHoaDon(BUS_HoaDon.Instance.layHoaDonChuaThanhToan());
            int totalPrice = 0;

            for (int i = 0; i < dgvChiTietHoaDon.RowCount; i++)
            {
                if (dgvChiTietHoaDon.Rows[i].Cells["THANHTIEN"].Value != null)
                {
                    totalPrice += (int)dgvChiTietHoaDon.Rows[i].Cells["THANHTIEN"].Value;
                }
                else totalPrice += 0;
            }
            tbTongTien.Text = totalPrice.ToString();
        }
        private void cbSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            DauSach selected = cb.SelectedItem as DauSach;
            masach = selected.maDS;
            tbTacGia.Text = BUS_Sach.Instance.layTenTacGiaBangMaSach(masach);
            //tbSL.Text = BUS_Sach.Instance.laySLSach(masach).ToString();
        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            if (BUS_HoaDon.Instance.insertBill(manv_dangnhap,makh))
            {
                cbSach.Enabled = true;
                tbTacGia.Enabled = true;
                //tbSL.Enabled = true;
                tbSLSachMua.Enabled = true;
                btnThemSach.Enabled = true;
                btnXoaSach.Enabled = true;
                btnNewBill.Enabled = false;
                btnThanhToan.Enabled = true;

                MessageBox.Show("Them hoa don thanh cong");
            }
            else MessageBox.Show("Them hoa don khong thanh cong");
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ComboBox cb = sender as ComboBox;
        //    if (cb.SelectedItem == null)
        //        return;
        //    NhanVien selected = cb.SelectedItem as NhanVien;
        //    manv = selected.maNV;

        //}

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (tbSLSachMua.Text == null) MessageBox.Show("Them Sach Khong Thanh Cong");
            else
            {
                if (BUS_ChiTietHoaDon.Instance.addBillDeTail(BUS_HoaDon.Instance.layHoaDonChuaThanhToan(), masach, Convert.ToInt32(tbSLSachMua.Text.ToString())))
                {
                    MessageBox.Show("Them Sach Thanh Cong");
                    loadChiTietHoaDon();
                }
                else MessageBox.Show("Them Sach Khong Thanh Cong");
            }
        }


        int maChiTietHoaDon = 0;
        int maHoaDon = 0;
        private void dgvChiTietHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChiTietHoaDon.SelectedCells.Count > 0)
            {
                maChiTietHoaDon = (int)dgvChiTietHoaDon.SelectedCells[0].OwningRow.Cells["MACTHD"].Value;
                maHoaDon = (int)dgvChiTietHoaDon.SelectedCells[0].OwningRow.Cells["MAHD"].Value;
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (BUS_ChiTietHoaDon.Instance.deleteBillDetail(maHoaDon, maChiTietHoaDon))
            {
                MessageBox.Show("Xóa Thành Công");
                loadChiTietHoaDon();
            }
            else MessageBox.Show("Xóa Không Thành Công");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int tongTien = Convert.ToInt32(tbTongTien.Text);
            int maHoaDon = BUS_HoaDon.Instance.layHoaDonChuaThanhToan();
            BUS_HoaDon.Instance.thanhToanHoaDon(maHoaDon, tongTien);
            MessageBox.Show("Thanh Toan Thanh Cong");
            loadChiTietHoaDon();

            cbSach.Enabled = false;
            tbTacGia.Enabled = false;
            //tbSL.Enabled = false;
            tbSLSachMua.Enabled = false;
            btnThemSach.Enabled = false;
            btnXoaSach.Enabled = false;
            btnNewBill.Enabled = true;
            btnThanhToan.Enabled = false;
        }

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            KhachHang selected = cb.SelectedItem as KhachHang;
            makh = selected.maKH;  
        }
    }
}
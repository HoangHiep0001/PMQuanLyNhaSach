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
    public partial class frmNhapSach : Form
    {

        string maNhaCungCap ;
        int maSach = 0;
        int manv;

        public frmNhapSach(int manv_dangnhap)
        {
            InitializeComponent();
            manv = manv_dangnhap;
            loadSach();
            loadNhaCungCap();
            loadNhanVien();
            loadDanhSachChiTietPhieuNhap();
            
        }

        void loadSach()
        {
            cbSach.DataSource = BUS_Sach.Instance.layDanhSachSach();
            cbSach.DisplayMember = "tenSach";
            cbSach.ValueMember = "maDS";
        }

        void loadNhaCungCap()
        {
            cbNhaCungCap.DataSource = BUS_NhaCungCap.Instance.layDanhSachNhaCungCap();
            cbNhaCungCap.DisplayMember = "tenNhaCungCap";
            cbNhaCungCap.ValueMember = "maNhaCungCap";
        }

        void loadNhanVien()
        {
            DataTable data = BUS_NhanVien.Instance.layThongTinNhanVienTheoMaNhanVien(manv);
            tbNhanVien.Text = data.Rows[0]["HOTEN"].ToString();
            
        }

        void loadDanhSachChiTietPhieuNhap()//load len datagridview danh sach chi tiet phieu nhap
        {
            dgvChiTietPhieuNhap.DataSource = BUS_ChiTietPhieuNhap.Instance.layDanhSachChiTietPhieuNhap(BUS_PhieuNhap.Instance.layMaPhieuNhapTheoNhaCungCap(maNhaCungCap));
            int totalPrice = 0;

            for (int i = 0; i < dgvChiTietPhieuNhap.RowCount; i++)
            {
                if (dgvChiTietPhieuNhap.Rows[i].Cells["THANHTIEN"].Value != null)
                {
                    totalPrice += (int)dgvChiTietPhieuNhap.Rows[i].Cells["THANHTIEN"].Value;
                }
                else totalPrice += 0;
            }
            tbTongTien.Text = totalPrice.ToString();
        }

        #region rac
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSLSachMua_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion



        private void cbNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            NhaCungCap selected = cb.SelectedItem as NhaCungCap ;
            maNhaCungCap = selected.maNhaCungCap;
            loadDanhSachChiTietPhieuNhap();
        }

        private void cbSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            DauSach selected = cb.SelectedItem as DauSach;
            maSach = selected.maDS;
            tbTacGia.Text = BUS_Sach.Instance.layTenTacGiaBangMaSach(maSach);
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            BUS_ChiTietPhieuNhap.Instance.themChiTietPhieuNhap(maNhaCungCap, maSach, Convert.ToInt32(tbSLSachNhap.Text), manv);
            loadDanhSachChiTietPhieuNhap();
        }


        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            NhanVien selected = cb.SelectedItem as NhanVien;
            manv = selected.maNV;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BUS_PhieuNhap.Instance.thanhToanPhieuNhap(BUS_PhieuNhap.Instance.layMaPhieuNhapTheoNhaCungCap(maNhaCungCap), Convert.ToInt32(tbTongTien.Text));
            MessageBox.Show("Thanh Toán Thành Công");
            loadDanhSachChiTietPhieuNhap();
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (BUS_ChiTietPhieuNhap.Instance.delChiTietPhieuNhap(maPhieuNhap,maChiTietPhieuNhap) ==true)
            {
                MessageBox.Show("Xóa Thành Công");
                loadDanhSachChiTietPhieuNhap();
            }
            else MessageBox.Show("Xóa Không Thành Công");
        }

        int maPhieuNhap;
        int maChiTietPhieuNhap;
        private void dgvChiTietPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChiTietPhieuNhap.SelectedCells.Count > 0)
            {
                maChiTietPhieuNhap = (int)dgvChiTietPhieuNhap.SelectedCells[0].OwningRow.Cells["MACTPN"].Value;
                maPhieuNhap = (int)dgvChiTietPhieuNhap.SelectedCells[0].OwningRow.Cells["MAPN"].Value;
            }
        }
    }
}

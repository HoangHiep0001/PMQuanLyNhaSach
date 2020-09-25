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
    public partial class frmBaocao : Form
    {
        int thang = 0, nam = 0;

        public frmBaocao()
        {
            InitializeComponent();
            loadDanhSachHoaDon(thang, nam);
            nam = (int)nudNam.Value;
        }
        void loadDanhSachHoaDon(int thang, int nam)
        {
            dgvHoaDon.DataSource = BUS_HoaDon.Instance.layDanhSachHoaDonTheoThangNam(thang, nam);
            int totalPrice = 0;

            for (int i = 0; i < dgvHoaDon.RowCount; i++)
            {
                if (dgvHoaDon.Rows[i].Cells["TỔNG TIỀN"].Value != null)
                {
                    totalPrice += (int)dgvHoaDon.Rows[i].Cells["TỔNG TIỀN"].Value;
                }
                else totalPrice += 0;
            }
            tbTongTien.Text = totalPrice.ToString();
        }


        

        private void nudNam_ValueChanged(object sender, EventArgs e)
        {
            nam = (int)nudNam.Value;
        }

        //nam = (int) nudNam.Text;

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            loadDanhSachHoaDon(thang, nam);
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbThang.Text != null)
            thang = Convert.ToInt32(cbThang.Text);
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLYNHASACH_DOAN
{
    public partial class frmTraCuuSach : Form
    {
        public DataTable dt;
        public SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VSOEAK5M;Initial Catalog=DOAN_QUANLYNHASACH;Integrated Security=True");
        public DataTable Display()
        {
            DataTable tblSach = new DataTable();
            try
            {
                con.Open();
                string SQL = "select TENSACH,TENTL,TACGIA,DONGIA,SOLUONG from DAUSACH ds, THELOAI tl where ds.MATL = tl.MATL";
                SqlCommand cmd = new SqlCommand(SQL, con);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                adt.Fill(tblSach);
                return tblSach;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }
        private void LoadData()
        {
            dgvSach.DataSource = Display();
        }
        public DataTable Tracuu()
        {
            DataTable tblS = new DataTable();

            try
            {
                string str = tbTensach.Text;
                string tacgia = tbTacgia.Text;
                string theloai = tbTheloai.Text;
                con.Open();
                string SQL = "select TENSACH,TENTL,TACGIA,DONGIA,SOLUONG from DAUSACH ds, THELOAI tl where ds.MATL = tl.MATL and TENSACH LIKE '%"+str+ "%' OR TACGIA LIKE '%" + TACGIA + "%' " ;
                SqlCommand cmd = new SqlCommand(SQL, con);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                adt.Fill(tblS);
                return tblS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }
        private void LoadDataTracuu()
        {
            dgvSach.DataSource = Tracuu();
        }

        public frmTraCuuSach()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            tbTensach.Clear();
            tbTacgia.Text = "";
            tbTacgia.Text = "";
            LoadData();

        }
            
        private void frmTraCuuSach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTracuu_Click(object sender, EventArgs e)
        {
            LoadDataTracuu();
        }
    }
}

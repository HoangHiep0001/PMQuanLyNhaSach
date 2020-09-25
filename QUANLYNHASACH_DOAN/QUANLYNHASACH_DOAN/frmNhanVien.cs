using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHASACH_DOAN
{
    public partial class frmNhanVien : Form
    {
        public DataTable dt;
        public SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VSOEAK5M;Initial Catalog=DOAN_QUANLYNHASACH;Integrated Security=True");
        public DataTable Display()
        {
            DataTable tblStaff = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            try
            {
                con.Open();     
                string SQL = "SELECT * FROM NHANVIEN ";

                SqlCommand cmd = new SqlCommand(SQL, con);
                adt.SelectCommand = cmd;
                adt.Fill(tblStaff);
                return tblStaff;
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

        public DataTable Display1()
        {
            DataTable dt = new DataTable();
            con.Open();
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("Select MACV From CHUCVU", con);
                da.Fill(dt);
                return (dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);            
            }
            finally
            {
                con.Close();
            }
            return null;
        }
    
        public bool checkData()
        {
            //if (string.IsNullOrWhiteSpace(tbManv.Text) == true)
            //{
            //    MessageBox.Show("Bạn chưa nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    tbManv.Focus();
            //    return false;
            //}
            if (string.IsNullOrWhiteSpace(tbHoten.Text) == true)
            {
                MessageBox.Show("Bạn chưa nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbHoten.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbDiachi.Text) == true)
            {
                MessageBox.Show("Bạn chưa nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbDiachi.Focus();
                return false;
            }
            return true;
        }
        public frmNhanVien()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dgvStaff.DataSource = Display();
            cboChucvu.DataSource = Display1();
            cboChucvu.DisplayMember = "MACV";
            cboChucvu.ValueMember = "MACV";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                try
                {
                    con.Open();
                    DialogResult dr;
                    dr = MessageBox.Show("Bạn có muốn thêm không ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        string SQL = string.Format("Insert Into NHANVIEN ( HOTEN, SDT, DIACHI, EMAIL, MACV) Values ( N'{0}', N'{1}', N'{2}', '{3}','{4}')", tbHoten.Text, tbSDT.Text, tbDiachi.Text, tbEmail.Text,cboChucvu.Text);                    
                        SqlCommand cmd = new SqlCommand(SQL, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        LoadData();

                        tbManv.Text = "";
                        tbHoten.Text = "";
                        tbDiachi.Text = "";
                        tbSDT.Text = "";
                        tbEmail.Text = "";
                        cboChucvu.Text = "";
                    }
                    else
                    {

                        tbManv.Text = "";
                        tbHoten.Text = "";
                        tbDiachi.Text = "";
                        tbSDT.Text = "";
                        tbEmail.Text = "";
                        cboChucvu.Text = "";
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("Bạn bị trùng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            con.Close();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn quay lại không ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn hủy không ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                tbManv.Text = "";
                tbHoten.Text = "";
                tbDiachi.Text = "";
                tbSDT.Text = "";
                tbEmail.Text = "";
                cboChucvu.Text = "";
            }
        }

        

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DialogResult dr;
                dr = MessageBox.Show("Bạn có muốn thay đổi không ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                string SQL = string.Format("Update NHANVIEN Set HOTEN = N'{1}', SDT = '{2}', DIACHI = N'{3}', EMAIL = '{4}', MACV = N'{5}' Where MANV = '{0}'", tbManv.Text, tbHoten.Text, tbSDT.Text, tbDiachi.Text, tbEmail.Text, cboChucvu.Text);
                SqlCommand cmd = new SqlCommand(SQL, con);
                cmd.ExecuteNonQuery();
                    con.Close();
                    LoadData();
                }
                else
                {
                    con.Close();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dr;
                dr = MessageBox.Show("Bạn có muốn xóa  không ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    con.Open();
                    string SQL = string.Format("Delete From NHANVIEN Where MANV = '{0}'", dgvStaff.CurrentRow.Cells[0].Value.ToString());
                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadData();
                }
                else
                {
                    LoadData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            tbManv.Text = dgvStaff.CurrentRow.Cells[0].Value.ToString();
            tbHoten.Text = dgvStaff.CurrentRow.Cells[1].Value.ToString();
            tbSDT.Text = dgvStaff.CurrentRow.Cells[2].Value.ToString();
            tbDiachi.Text = dgvStaff.CurrentRow.Cells[3].Value.ToString();
            tbEmail.Text = dgvStaff.CurrentRow.Cells[4].Value.ToString();
            cboChucvu.Text = dgvStaff.CurrentRow.Cells[5].Value.ToString();
        }
    }
}

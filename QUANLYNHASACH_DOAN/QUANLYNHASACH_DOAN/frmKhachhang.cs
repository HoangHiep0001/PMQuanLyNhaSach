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
    public partial class frmKhachhang : Form
    {
        public DataTable dt;
        public SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VSOEAK5M;Initial Catalog=DOAN_QUANLYNHASACH;Integrated Security=True");
        public DataTable Display()
        {
            DataTable tblCustomer = new DataTable();
            try
            {
                con.Open();
                string SQL = "Select * From KHACHHANG";
                SqlCommand cmd = new SqlCommand(SQL, con);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                adt.Fill(tblCustomer);
                return tblCustomer;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }


        public frmKhachhang()
        {
            InitializeComponent();
        }
      
        
        
        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(tbMakh.Text) == true)
            {
                MessageBox.Show("Bạn chưa nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMakh.Focus();
                return false;
            }
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
            if (string.IsNullOrWhiteSpace(tbSdt.Text) == true)
            {
                MessageBox.Show("Bạn chưa nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSdt.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbEmail.Text) == true)
            {
                MessageBox.Show("Bạn chưa nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbGender.Text) == true)
            {
                MessageBox.Show("Bạn chưa nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbGender.Focus();
                return false;
            }
            return true;
        }

        public void LoadData()
        {
            dgvCustomer.DataSource = Display();
        }
     
        public void frmKhachhang_Load(object sender, EventArgs e)
        {
            LoadData(); 

        }

        private void bntQuaylai_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn quay lại không ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btbXoa_Click(object sender, EventArgs e)
        {
            try
            {
                
                DialogResult dr;
                dr = MessageBox.Show("Bạn có muốn xóa  không ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {    
                con.Open();
                string SQL = string.Format("Delete From KHACHHANG Where MAKH = '{0}'", dgvCustomer.CurrentRow.Cells[0].Value.ToString());
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

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn hủy không ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                tbMakh.Text = "";
            tbHoten.Text = "";
            tbDiachi.Text = "";
            tbSdt.Text = "";
            tbEmail.Text = "";
            tbGender.Text = "";   
            }
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
                    string SQL = string.Format("Insert Into KHACHHANG (MAKH, HOTEN, DIACHI, SDT, EMAIL, GIOITINH) Values ('{0}', N'{1}', N'{2}', '{3}', '{4}', '{5}')", tbMakh.Text, tbHoten.Text, tbDiachi.Text, tbSdt.Text, tbEmail.Text, tbGender.Text);
                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.ExecuteNonQuery();
                        con.Close();
                        LoadData();

                        tbMakh.Text = "";
                        tbHoten.Text = "";
                        tbDiachi.Text = "";
                        tbSdt.Text = "";
                        tbEmail.Text = "";
                        tbGender.Text = "";
                    }
                    else
                    {
                        tbMakh.Text = "";
                        tbHoten.Text = "";
                        tbDiachi.Text = "";
                        tbSdt.Text = "";
                        tbEmail.Text = "";
                        tbGender.Text = "";
                    }
                }
                catch(Exception )
                {
                    MessageBox.Show("Trùng thông tin mã khách hàng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            con.Close();

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
                string SQL = string.Format("Update KHACHHANG Set HOTEN = N'{1}', DIACHI = N'{2}', SDT = '{3}', EMAIL = '{4}', GIOITINH = '{5}' Where MAKH = '{0}'",tbMakh.Text, tbHoten.Text, tbDiachi.Text, tbSdt.Text, tbEmail.Text, tbGender.Text);
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

        private void dgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            tbMakh.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            tbHoten.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            tbDiachi.Text = dgvCustomer.CurrentRow.Cells[2].Value.ToString();
            tbSdt.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
            tbEmail.Text = dgvCustomer.CurrentRow.Cells[4].Value.ToString();
            tbGender.Text = dgvCustomer.CurrentRow.Cells[5].Value.ToString();

        }

        
    }
}

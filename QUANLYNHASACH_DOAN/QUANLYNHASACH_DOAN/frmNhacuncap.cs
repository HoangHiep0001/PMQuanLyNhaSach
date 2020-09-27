using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHASACH_DOAN
{
    public partial class frmNhacuncap : Form
    {
        public DataTable dt;
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JBEGP9H;Initial Catalog=DOAN_QUANLYNHASACH;Integrated Security=True");
        public DataTable Display()
        {
            DataTable tblSupplier = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            try
            {
                con.Open();
                string SQL = "SELECT * FROM NHACUNGCAP ";

                SqlCommand cmd = new SqlCommand(SQL, con);
                adt.SelectCommand = cmd;
                adt.Fill(tblSupplier);
                return tblSupplier;
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
        public frmNhacuncap()
        {
            InitializeComponent();
        }
         private void LoadData()
        {
            dgvSupplier.DataSource = Display();
        }
         private void frmNhacuncap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(tbMancc.Text) == true)
            {
                MessageBox.Show("Bạn chưa nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMancc.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbTenncc.Text) == true)
            {
                MessageBox.Show("Bạn chưa nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTenncc.Focus();
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
            return true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn hủy không ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                tbMancc.Text = "";
                tbTenncc.Text = "";
                tbSdt.Text = "";
                tbDiachi.Text = "";
                tbEmail.Text = "";
               
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
                    string SQL = string.Format("Insert Into NHACUNGCAP (MANCC, TENNCC, SDT, DIACHI, EMAIL) Values ('{0}', N'{1}', '{2}', N'{3}', '{4}')", tbMancc.Text, tbTenncc.Text, tbSdt.Text, tbDiachi.Text, tbEmail.Text);
                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.ExecuteNonQuery();

                        con.Close();
                        LoadData();

                        tbMancc.Text = "";
                        tbTenncc.Text = "";
                        tbSdt.Text = "";
                        tbDiachi.Text = "";
                        tbEmail.Text = "";
                    }
                    else
                    {
                        tbMancc.Text = "";
                        tbTenncc.Text = "";
                        tbSdt.Text = "";
                        tbDiachi.Text = "";
                        tbEmail.Text = "";
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("Bạn bị trùng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            con.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dr;
                dr = MessageBox.Show("Bạn có muốn xóa  không ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    con.Open();
                    string SQL = string.Format("Delete From NHACUNGCAP Where MANCC = '{0}'", dgvSupplier.CurrentRow.Cells[0].Value.ToString());
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
            catch (Exception )
            {
                MessageBox.Show("Bạn không thể xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
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
                string SQL = string.Format("Update NHACUNGCAP Set TENNCC = N'{1}', SDT = '{2}', DIACHI = N'{3}', EMAIL = '{4}' Where MANCC = '{0}'", tbMancc.Text, tbTenncc.Text, tbSdt.Text, tbDiachi.Text, tbEmail.Text);
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
                MessageBox.Show("Thông tin không thay đổi ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

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

        private void dgvSupplier_SelectionChanged(object sender, EventArgs e)
        {
            tbMancc.Text = dgvSupplier.CurrentRow.Cells[0].Value.ToString();
            tbTenncc.Text = dgvSupplier.CurrentRow.Cells[1].Value.ToString();
            tbSdt.Text = dgvSupplier.CurrentRow.Cells[2].Value.ToString();
            tbDiachi.Text = dgvSupplier.CurrentRow.Cells[3].Value.ToString();
            tbEmail.Text = dgvSupplier.CurrentRow.Cells[4].Value.ToString();
            
        }
    }
}

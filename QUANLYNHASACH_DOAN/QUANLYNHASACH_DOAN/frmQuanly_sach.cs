using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHASACH_DOAN
{
    public partial class frmQuanly_sach : Form
    {
        public DataTable dt;
        public SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VSOEAK5M;Initial Catalog=DOAN_QUANLYNHASACH;Integrated Security=True");
        public DataTable Display()
        {
            DataTable tblBook = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            try
            {
                con.Open();
                string SQL = "SELECT * FROM DAUSACH ";

                SqlCommand cmd = new SqlCommand(SQL, con);
                adt.SelectCommand = cmd;
                adt.Fill(tblBook);
                return tblBook;
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

                SqlDataAdapter da = new SqlDataAdapter("Select MATL From THELOAI", con);
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
        public frmQuanly_sach()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dgvBook.DataSource = Display();
            cboTheloai.DataSource = Display1();
            cboTheloai.DisplayMember = "MATL";
            cboTheloai.ValueMember = "MATL";
        }
    

        private void frmQuanly_sach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(tbMads.Text) == true)
            {
                MessageBox.Show("Bạn chưa nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMads.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbTensach.Text) == true)
            {
                MessageBox.Show("Bạn chưa nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTensach.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cboTheloai.Text) == true)
            {
                MessageBox.Show("Bạn chưa nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboTheloai.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbTacgia.Text) == true)
            {
                MessageBox.Show("Bạn chưa nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTacgia.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbSoluong.Text) == true)
            {
                MessageBox.Show("Bạn chưa nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSoluong.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbDongia.Text) == true)
            {
                MessageBox.Show("Bạn chưa nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbDongia.Focus();
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
                tbMads.Text = "";
                tbTensach.Text = "";
                cboTheloai.Text = "";
                tbTacgia.Text = "";
                tbSoluong.Text = "";
                tbDongia.Text = "";
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
                    string SQL = string.Format("Insert Into DAUSACH ( TENSACH, MATL, TACGIA, SOLUONG, DONGIA) Values ( N'{0}', N'{1}', N'{2}', '{3}', '{4}')", tbTensach.Text, cboTheloai.Text, tbTacgia.Text, tbSoluong.Text, tbDongia.Text);

                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.ExecuteNonQuery();
                   
                        con.Close();
                        LoadData();
                        tbMads.Text = "";
                        tbTensach.Text = "";
                        cboTheloai.Text = "";
                        tbTacgia.Text = "";
                        tbSoluong.Text = "";
                        tbDongia.Text = "";

                    }
                    else
                    {
                        tbMads.Text = "";
                        tbTensach.Text = "";
                        cboTheloai.Text = "";
                        tbTacgia.Text = "";
                        tbSoluong.Text = "";
                        tbDongia.Text = "";
                        
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
                    string SQL = string.Format("Delete From DAUSACH Where MADS = '{0}'", dgvBook.CurrentRow.Cells[0].Value.ToString());
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DialogResult dr;
                dr = MessageBox.Show("Bạn có muốn thay đổi không ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string SQL = string.Format("Update DAUSACH Set TENSACH = N'{1}', MATL = '{2}', TACGIA = N'{3}', SOLUONG = '{4}', DONGIA = '{5}' Where MADS = '{0}'", tbMads.Text, tbTensach.Text, cboTheloai.Text, tbTacgia.Text, tbSoluong.Text, tbDongia.Text);
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

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn quay lại không ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvBook_SelectionChanged(object sender, EventArgs e)
        {
            tbMads.Text = dgvBook.CurrentRow.Cells[0].Value.ToString();
            tbTensach.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
            cboTheloai.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
            tbTacgia.Text = dgvBook.CurrentRow.Cells[3].Value.ToString();
            tbSoluong.Text = dgvBook.CurrentRow.Cells[4].Value.ToString();
            tbDongia.Text = dgvBook.CurrentRow.Cells[5].Value.ToString();

        }
    }

}

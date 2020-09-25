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
    public partial class frmQuanly_theloai : Form
    {
        public DataTable dt;
        public SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VSOEAK5M;Initial Catalog=DOAN_QUANLYNHASACH;Integrated Security=True");
        public DataTable Display()
        {
            DataTable tblCategory = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();
            try
            {
                con.Open();
                string SQL = "SELECT * FROM THELOAI ";

                SqlCommand cmd = new SqlCommand(SQL, con);
                adt.SelectCommand = cmd;
                adt.Fill(tblCategory);
                return tblCategory;
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

        public frmQuanly_theloai()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dgvCategory.DataSource = Display();
        }

        private void frmQuanly_theloai_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(tbMaTL.Text) == true)
            {
                MessageBox.Show("Bạn chưa nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaTL.Focus();
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(tbTenTL.Text) == true)
            {
                MessageBox.Show("Bạn chưa nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTenTL.Focus();
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
                tbMaTL.Text = "";
                tbTenTL.Text = "";
                
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
                        string SQL = string.Format("Insert Into THELOAI ( MATL, TENTL ) Values ('{0}',N'{1}')",tbMaTL.Text ,tbTenTL.Text );

                        SqlCommand cmd = new SqlCommand(SQL, con);
                        cmd.ExecuteNonQuery();

                        con.Close();
                        LoadData();
                        tbMaTL.Text = "";
                        tbTenTL.Text = "";
                        

                    }
                    else
                    {
                        tbMaTL.Text = "";
                        tbTenTL.Text = "";
                     
                    }

                }
                catch (Exception )
                {
                    MessageBox.Show("Bạn bị trùng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            con.Close();
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
                    string SQL = string.Format("Delete From THELOAI Where MATL = '{0}'", dgvCategory.CurrentRow.Cells[0].Value.ToString());
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
                    string SQL = string.Format("Update THELOAI Set TENTL = N'{1}' Where MATL = '{0}' ", tbMaTL.Text, tbTenTL.Text );
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
            catch (Exception )
            {
                MessageBox.Show("Không thay đổi được ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvCategory_SelectionChanged(object sender, EventArgs e)
        {

            tbTenTL.Text = dgvCategory.CurrentRow.Cells[1].Value.ToString();
            tbMaTL.Text = dgvCategory.CurrentRow.Cells[0].Value.ToString();
        }
    }
}

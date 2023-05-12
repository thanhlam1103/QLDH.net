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
using System.Configuration;

namespace QuanLyDonHang
{
    public partial class frmchangePass : Form
    {
        public frmchangePass()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmchangePass_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtCurPass.PasswordChar = (char)0;
                txtNewPass.PasswordChar = (char)0;
                txtConfPass.PasswordChar = (char)0;
            }
            else
            {
                txtCurPass.PasswordChar = '*';
                txtNewPass.PasswordChar = '*';
                txtConfPass.PasswordChar = '*';
            }
        }
        public bool KiemTra()
        {
            if (txtTenTK.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng nhập tên tài khoản !!";
                txtTenTK.Focus();
                return false;
            }
            else if (txtCurPass.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng nhập mật khẩu hiện tại !!";
                txtCurPass.Focus();
                return false;
            }
            else if (txtNewPass.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng nhập mật khẩu mới !!";
                txtNewPass.Focus();
                return false;
            }
            else if (txtConfPass.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng xác nhận mật khẩu !!";
                txtConfPass.Focus();
                return false;
            }
            else if (txtNewPass.Text != txtConfPass.Text)
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Mật khẩu mới và mật khẩu xác nhận không trùng khớp";
                txtConfPass.Focus();
                txtConfPass.SelectAll();
                return false;
            }
            return true;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                SqlConnection conn = new SqlConnection();
                try
                {
                    conn.ConnectionString = @"Data Source=LAPTOP-CITAPQOU;Initial Catalog=QuanLyDonHang;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_Update_Pass";
                    cmd.Parameters.Add("@User", SqlDbType.NVarChar).Value = txtTenTK.Text;
                    cmd.Parameters.Add("@OldPass", SqlDbType.NVarChar).Value = txtCurPass.Text;
                    cmd.Parameters.Add("@NewPass", SqlDbType.NVarChar).Value = txtNewPass.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.GetInt32(0) == 1)
                    {
                        lblShowInfor.ForeColor = System.Drawing.Color.Blue;
                        lblShowInfor.Text = dr.GetString(1);
                        txtConfPass.Text = "";
                        txtCurPass.Text = "";
                        txtNewPass.Text = "";
                        txtCurPass.Focus();
                    }
                    else
                    {
                        lblShowInfor.ForeColor = System.Drawing.Color.Red;
                        lblShowInfor.Text = dr.GetString(1);
                        txtCurPass.Focus();
                        txtCurPass.SelectAll();
                    }
                    dr.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        
    }
    }
}

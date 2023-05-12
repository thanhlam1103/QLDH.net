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
    public partial class frmLogin : Form
    {
        public static string UserName = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txtMk.PasswordChar = (char)0;
            }
            else
            {
                txtMk.PasswordChar = '*';
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
               
                conn.ConnectionString = @"Data Source=LAPTOP-CITAPQOU;Initial Catalog=QuanLyDonHang;Integrated Security=True";
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AuthoLogin";
                cmd.Parameters.AddWithValue("@UserName", txtTk.Text);
                cmd.Parameters.AddWithValue("@Password", txtMk.Text);
                cmd.Connection = conn;
                UserName = txtTk.Text;
                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                if (code == 0)
                {
                    MessageBox.Show("Chào mừng User đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmMain Main = new frmMain();
                    Main.ShowDialog();
                    this.Close();
                }
                else if (code == 1)
                {
                    MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (code == 2)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMk.Text = "";
                    txtTk.Text = "";
                    txtTk.Focus();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMk.Text = "";
                    txtTk.Text = "";
                    txtTk.Focus();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUser_MouseClick(object sender, MouseEventArgs e)
        {
            txtTk.SelectAll();
        }

        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            txtMk.SelectAll();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void txtTk_MouseClick(object sender, MouseEventArgs e)
        {
            txtTk.SelectAll();
        }

        private void txtMk_MouseClick(object sender, MouseEventArgs e)
        {
            txtMk.SelectAll();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}


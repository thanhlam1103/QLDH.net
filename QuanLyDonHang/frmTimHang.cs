using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDonHang.Class;
using System.Data.SqlClient;

namespace QuanLyDonHang
{
    public partial class frmTimHang : Form
    {
        public static SqlConnection Con;
        public frmTimHang()
        {
            InitializeComponent();
        }

        private void frmTimHang_Load(object sender, EventArgs e)
        {

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            ShowHang();
        }
        private void ShowHang()
        {
            //khởi tạo các đối tượng SqlConnection, SqlDataAdapter, DataTable
            SqlConnection conn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            //lấy chuỗi kết nối từ file App.config

            conn.ConnectionString = @"Data Source=LAPTOP-CITAPQOU;Initial Catalog=QuanLyDonHang;Integrated Security=True";
            try
            {
                //mở chuỗi kết nối
                conn.Open();
                //khởi tạo đối tượng SqlCommand
                da.SelectCommand = new SqlCommand();
                //cung cấp tên thủ tục
                da.SelectCommand.CommandText = "SP_ShowHang";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //gán chuỗi chuỗi nối
                da.SelectCommand.Connection = conn;
                //sử dụng phương thức fill() để điền dữ liệu vào DataDataAdapter
                da.Fill(dt);
                //sử dụng thuộc tính datasource để điền dữ liệu vào từ datatable
                dgvTimHang.DataSource = dt;
                //đóng chuỗi kết nối
                conn.Close();
                //set up độ dài và tiêu đề cho các cột
               
                dgvTimHang.Columns[0].HeaderText = "Mã hàng";
                dgvTimHang.Columns[1].HeaderText = "Tên hàng";
                dgvTimHang.Columns[2].HeaderText = "Chất liệu";
                dgvTimHang.Columns[3].HeaderText = "Số lượng";
                dgvTimHang.Columns[4].HeaderText = "Đơn giá nhập";
                dgvTimHang.Columns[5].HeaderText = "Đơn giá bán";
                //dgvTimHang.Columns[6].HeaderText = "Ảnh";
                dgvTimHang.Columns[6].HeaderText = "Ghi chú";
                dgvTimHang.Columns[0].Width = 80;
                dgvTimHang.Columns[1].Width = 140;
                dgvTimHang.Columns[2].Width = 80;
                dgvTimHang.Columns[3].Width = 80;
                dgvTimHang.Columns[4].Width = 100;
                dgvTimHang.Columns[5].Width = 100;
                // dgvTimHang.Columns[6].Width = 200;
                dgvTimHang.Columns[6].Width = 300;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResset_Click(object sender, EventArgs e)
        {
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox)
                {
                    ct.Text = string.Empty;
                }
                if (ct is MaskedTextBox)
                {
                    ct.Text = string.Empty;
                }
            }
        }

        private void dgvTimHang_DoubleClick(object sender, EventArgs e)
        {
            string makh;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                makh = dgvTimHang.CurrentRow.Cells["MaHang"].Value.ToString();
                frmDMHang frm = new frmDMHang();
                frm.txtMaHang.Text = makh;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }

        private void dgvTimHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaHang.Text = dgvTimHang.CurrentRow.Cells["MaHang"].Value.ToString();
            txtTenHang.Text = dgvTimHang.CurrentRow.Cells["TenHang"].Value.ToString();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

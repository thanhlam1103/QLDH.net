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
    public partial class frmTimKH : Form
    {

        public static SqlConnection Con;
        public frmTimKH()
        {
            InitializeComponent();
        }

        private void frmTimKH_Load(object sender, EventArgs e)
        {
           
        }
       
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ShowKhachHang();
        }

        //viết hàm hiển thị danh sách học sinh
        private void ShowKhachHang()
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
                da.SelectCommand.CommandText = "SP_ShowKhachHang";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //gán chuỗi chuỗi nối
                da.SelectCommand.Connection = conn;
                //sử dụng phương thức fill() để điền dữ liệu vào DataDataAdapter
                da.Fill(dt);
                //sử dụng thuộc tính datasource để điền dữ liệu vào từ datatable
                dgvTimKH.DataSource = dt;
                //đóng chuỗi kết nối
                conn.Close();
                //set up độ dài và tiêu đề cho các cột
                dgvTimKH.Columns[0].Width = 100;
                dgvTimKH.Columns[0].HeaderText = "Mã Khách hàng";
                dgvTimKH.Columns[1].Width = 180;
                dgvTimKH.Columns[1].HeaderText = "Tên khách hàng";
                dgvTimKH.Columns[2].Width = 150;
                dgvTimKH.Columns[2].HeaderText = "Địa chỉ";
                dgvTimKH.Columns[3].Width = 150;
                dgvTimKH.Columns[3].HeaderText = "Số điện thoại";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTimKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaKhach_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "TenKhach", "*" + txtTenKH.Text + "*");
            (dgvTimKH.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void dgvTimKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaKhach.Text = dgvTimKH.Rows[numrow].Cells[1].Value.ToString();
            txtTenKH.Text = dgvTimKH.Rows[numrow].Cells[1].Value.ToString();
            mtbDienThoai.Text = dgvTimKH.CurrentRow.Cells["DienThoai"].Value.ToString();
            txtDc.Text = dgvTimKH.CurrentRow.Cells["Diachi"].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
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

        private void dgvTimKH_DoubleClick(object sender, EventArgs e)
        {
            string makh;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                makh = dgvTimKH.CurrentRow.Cells["MaKhach"].Value.ToString();
                frmDMKhachHang frm = new frmDMKhachHang();
                frm.txtMaKhach.Text = makh;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }
    }
    
}

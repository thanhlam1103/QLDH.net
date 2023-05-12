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
using QuanLyDonHang.Class;

namespace QuanLyDonHang
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            //fillChart();
        }
        private void fillChart()
        {
            //chart1.Series["Salary"].Points.AddXY("", "");
        }

        private void btn_TK_Click(object sender, EventArgs e)
        {
            {//Biểu đồ hình tròn
             //khởi tạo các đối tượng SqlConnection, SqlDataAdapter, DataTable
                SqlConnection conn = new SqlConnection();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                //lấy chuỗi kết nối từ file App.config

                conn.ConnectionString = @"Data Source=LAPTOP-CITAPQOU;Initial Catalog=QuanLyDonHang;Integrated Security=True";
                string cl = "SELECT * FROM tblHDBan,tblChiTietHDBan";

                SqlCommand cmd = new SqlCommand(cl, conn);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                conn.Open();
                chart1.DataSource = ds;
                chart1.Series["Oder Statistics"].XValueMember = "MaHDBan";
                chart1.Series["Oder Statistics"].YValueMembers = "TongTien";
                chart1.Titles.Add("Oder Statistics Chart");
                //Ẩn đường lưới dọc
                chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                ////Chuyển kiểu biểu đồ hình tròn
                //chart1.Series[0].ChartType = SeriesChartType.Pie;
                conn.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

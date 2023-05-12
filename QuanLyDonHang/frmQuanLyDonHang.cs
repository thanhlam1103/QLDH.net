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
using QuanLyDonHang.Class;

namespace QuanLyDonHang
{
    public partial class frmQuanLyDonHang : Form
    {
        public static SqlConnection Con;
        public frmQuanLyDonHang()
        {
            InitializeComponent();
        }

        private void QuanLyDonHang_Load(object sender, EventArgs e)
        {
            string sql = @"Select
tblHDBan.*,
tblKhach.TenKhach,
tblKhach.Diachi,
tblKhach.DienThoai as DienThoaiKH,
tblNhanVien.DienThoai as DienThoaiNV,
tblNhanVien.TenNhanVien
from
tblHDBan, tblKhach, tblNhanVien
where
tblHDBan.MaKhach = tblKhach.MaKhach
and tblHDBan.MaNhanVien = tblNhanVien.MaNhanVien";

            Con = new SqlConnection();   //Khởi tạo đối tượng
            Con.ConnectionString = @"Data Source=LAPTOP-CITAPQOU;Initial Catalog=QuanLyDonHang;Integrated Security=True";
            SqlDataAdapter datblKhach =
                new SqlDataAdapter(sql, Con);
            DataTable dttblHDBan = new DataTable();
            datblKhach.Fill(dttblHDBan);
            dgvDSDonHang.DataSource = dttblHDBan;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmHoaDonBan x = new frmHoaDonBan();//Khởi tạo đối tượng
           x.ShowDialog(); //Hiển thị
        }
    }
}

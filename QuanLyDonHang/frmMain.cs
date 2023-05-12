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


namespace QuanLyDonHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
          Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            frmDMChatLieu frm = new frmDMChatLieu(); //Khởi tạo đối tượng
            frm.ShowDialog(); //Hiển thị
        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {
            frmTimHDBan frmTim = new frmTimHDBan();//Khởi tạo đối tượng
            frmTim.ShowDialog(); //Hiển thị
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHang frm = new frmDMHang();
            frm.ShowDialog();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frmHDBan = new frmHoaDonBan();//Khởi tạo đối tượng
            frmHDBan.ShowDialog(); //Hiển thị
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanvien frmNhanvien = new frmDMNhanvien();//Khởi tạo đối tượng
            frmNhanvien.ShowDialog(); //Hiển thị
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frmKH = new frmDMKhachHang();//Khởi tạo đối tượng
            frmKH.ShowDialog(); //Hiển thị
        }

        private void mnuBCDoanhThu_Click(object sender, EventArgs e)
        {
            frmQuanLyDonHang frmQLDH = new frmQuanLyDonHang();//Khởi tạo đối tượng
            frmQLDH.ShowDialog(); //Hiển thị
        }

        private void mnuFindKhachHang_Click(object sender, EventArgs e)
        {
            frmTimKH TimKH = new frmTimKH();//Khởi tạo đối tượng
            TimKH.ShowDialog(); //Hiển thị
        }

        private void mnuFindHang_Click(object sender, EventArgs e)
        {
            frmTimHang TimH = new frmTimHang();//Khởi tạo đối tượng
            TimH.ShowDialog();
        }

        private void mnuHienTroGiup_Click(object sender, EventArgs e)
        {
            frmThongKe TK = new frmThongKe();//Khởi tạo đối tượng
            TK.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchangePass dTK = new frmchangePass();//Khởi tạo đối tượng
            dTK.ShowDialog();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();//Khởi tạo đối tượng
            login.ShowDialog();
        }
    }
}

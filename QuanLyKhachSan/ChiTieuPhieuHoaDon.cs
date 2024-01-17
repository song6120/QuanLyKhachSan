using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class ChiTieuPhieuHoaDon : Form
    {
        QuanLyKhachSanEntities QuanLyKhachSan = new QuanLyKhachSanEntities();
        public static int id;
        public static string tenkh;
        public static string ngayld;
        public static string sohd;
        public static string tennv;
        public static string sophong;
        public static int songay;
        public static string loaiphong;
        public static string giaphong;
        public static DateTime ngaythue;
        public static DateTime ngaytra;

        public ChiTieuPhieuHoaDon()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChiTieuPhieuHoaDon_Load(object sender, EventArgs e)
        {
            TimeSpan ts;
            ts = ngaytra - ngaythue;
            lbKhachHang.Text = tenkh;
            lbNgayLapDon.Text = ngayld;
            lbSoHoaDon.Text = sohd;
            lbNhanVien.Text = tennv;
            lbSoPhong.Text = sophong;
            lbSoNgay.Text = ts.TotalDays.ToString();
            lbGiaPhong.Text = giaphong;
            lbLoaiPhong.Text = loaiphong;

            var cthd = from item in QuanLyKhachSan.ChiTietHoaDons
                       join hd in QuanLyKhachSan.HoaDons
                       on item.MaHoaDon equals hd.MaHoaDon
                       join dv in QuanLyKhachSan.DichVus
                       on item.MaDichVu equals dv.MaDichVu
                       select new
                       {
                           dv.TenDichVu,
                           dv.Gia,
                           item.SoLuong,
                           item.TongTien
                       };
            DataChiTietDatPhong.DataSource = cthd.ToList();
            DataChiTietDatPhong.Columns[0].HeaderText = "Dịch vụ";
            DataChiTietDatPhong.Columns[1].HeaderText = "Giá";
            DataChiTietDatPhong.Columns[2].HeaderText = "Số lượng";
            DataChiTietDatPhong.Columns[3].HeaderText = "Tổng tiền";
        }

        private void lbLoaiPhong_Click(object sender, EventArgs e)
        {

        }

        private void lbSoNgay_Click(object sender, EventArgs e)
        {

        }

        private void lbSoHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}

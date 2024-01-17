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
    public partial class ChiTietDatPhong : Form
    {
        QuanLyKhachSanEntities QuanLyKhachSan = new QuanLyKhachSanEntities();
        public static int id;
        public ChiTietDatPhong()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChiTietDatPhong_Load(object sender, EventArgs e)
        {
            var ctdp = from dp in QuanLyKhachSan.DatPhongs
                       join kh in QuanLyKhachSan.KhachHangs
                       on dp.MaKhachHang equals kh.MaKhachHang
                       join nv in QuanLyKhachSan.NhanViens
                       on dp.MaNhanVien equals nv.MaNhanVien
                       where dp.MaDatPhong == id
                       select new
                       {
                           kh.TenKhachHang,
                           dp.MaPhong,
                           dp.NgayThue,
                           dp.NgayTra,
                           nv.TenNhanVien
                       };
            DataChiTietDatPhong.DataSource = ctdp.ToList();
            DataChiTietDatPhong.Columns[0].HeaderText = "Khách hàng";
            DataChiTietDatPhong.Columns[1].HeaderText = "Số phòng";
            DataChiTietDatPhong.Columns[2].HeaderText = "Ngày thuê";
            DataChiTietDatPhong.Columns[3].HeaderText = "Ngày trả";
            DataChiTietDatPhong.Columns[4].HeaderText = "Tên nhân viên";
        }
    }
}

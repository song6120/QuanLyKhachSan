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
    public partial class DatDichVu : Form
    {
        QuanLyKhachSanEntities quanLyKhachSan = new QuanLyKhachSanEntities();
        public static string sophong;
        public static string tenkh;
        public static string ngaythue;
        public static string ngaytra;
        public DatDichVu()
        {
            InitializeComponent();
        }


        private void DatDichVu_Load(object sender, EventArgs e)
        {
            lbPhong.Text = sophong;
            lbKhachHang.Text = tenkh;  
            lbNgayThue.Text = ngaythue;
            lbNgayTra.Text = ngaytra;

            var xp = from item in quanLyKhachSan.Phongs
                    where item.MaPhong == sophong
                    select item;
            DataPhong.DataSource = xp.ToList();

            int matt = Convert.ToInt16(DataPhong.Rows[0].Cells[1].Value.ToString());

            if (matt == 1)
            {
                panelNhanPhong.Hide();
                panelGoiDichVu.Show();
                panelthanhToan.Show();
            }
            else
            {
                panelNhanPhong.Show();
                panelthanhToan.Hide();
                panelGoiDichVu.Hide();
            }

            Display();
        }
        public void Display()
        {

            var dp = from item in quanLyKhachSan.DatPhongs
                     join cthd in quanLyKhachSan.ChiTietHoaDons
                     on item.MaDatPhong equals cthd.MaDatPhong
                     join p in quanLyKhachSan.Phongs
                     on item.MaPhong equals p.MaPhong
                     join kh in quanLyKhachSan.KhachHangs
                     on item.MaKhachHang equals kh.MaKhachHang
                     join dv in quanLyKhachSan.DichVus
                     on cthd.MaDichVu equals dv.MaDichVu
                     where item.MaPhong == sophong && p.MaTrangThai == 1
                     select new
                     {
                         dv.TenDichVu,
                         cthd.SoLuong,
                         dv.Gia
                     };
            DataThongTinDichVu.DataSource = dp.ToList();
            DataThongTinDichVu.Columns[0].HeaderText = "Dịch vụ";
            DataThongTinDichVu.Columns[1].HeaderText = "Số lượng";
            DataThongTinDichVu.Columns[2].HeaderText = "Giá";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            var editp = from item in quanLyKhachSan.Phongs
                    where item.MaPhong == sophong
                    select item;
            Phong pp = editp.First();
            pp.MaTrangThai = 1;

            int matt = Convert.ToInt16(DataPhong.Rows[0].Cells[1].Value.ToString());

            if (matt == 1)
            {
                panelNhanPhong.Hide();
                panelGoiDichVu.Show();
                panelthanhToan.Show();
            }
            else
            {
                panelNhanPhong.Show();
                panelthanhToan.Hide();
                panelGoiDichVu.Hide();
            }

            quanLyKhachSan.SaveChanges();


        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ChiTieuPhieuHoaDon chi = new ChiTieuPhieuHoaDon();
            chi.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dp = from item in quanLyKhachSan.DatPhongs
                     join cthd in quanLyKhachSan.ChiTietHoaDons
                     on item.MaDatPhong equals cthd.MaDatPhong
                     join p in quanLyKhachSan.Phongs
                     on item.MaPhong equals p.MaPhong
                     join kh in quanLyKhachSan.KhachHangs
                     on item.MaKhachHang equals kh.MaKhachHang
                     join dv in quanLyKhachSan.DichVus
                     on cthd.MaDichVu equals dv.MaDichVu
                     where item.MaPhong == sophong && p.MaTrangThai == 1
                     select new
                     {
                         item.MaDatPhong
                     };
            dataMaDatPhong.DataSource = dp.ToList();
            int madp = Convert.ToInt16(dataMaDatPhong.Rows[0].Cells[0].Value.ToString());
            GoiDichVu.id = madp;
            GoiDichVu goiDich = new GoiDichVu();
            goiDich.ShowDialog();
            Display();
        }
    }
}

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
    public partial class ThemDatPhong : Form
    {
        QuanLyKhachSanEntities QuanLyKhachSan = new QuanLyKhachSanEntities();
        private int makh;
        public ThemDatPhong()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int n = DataDatPhong.CurrentRow.Index;
            string id = DataDatPhong.Rows[n].Cells[0].Value.ToString();
            makh = Convert.ToInt16(datakhachhang.Rows[0].Cells[0].Value.ToString());
            DatPhong dp = new DatPhong();
            dp.MaKhachHang = makh;
            dp.MaPhong = id;
            dp.NgayThue = txtNgayThue.Value;
            dp.NgayTra = txtNgayTra.Value;
            dp.MaNhanVien = 1;
            QuanLyKhachSan.DatPhongs.Add(dp);
            QuanLyKhachSan.SaveChanges();
            MessageBox.Show("Đặt phòng thành công!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var p = from item in QuanLyKhachSan.Phongs
                    where item.MaPhong == id
                    select item;
            Phong phong = p.First();
            phong.MaTrangThai = 2;
            QuanLyKhachSan.SaveChanges();
            Close();

        }

        private void ThemDatPhong_Load(object sender, EventArgs e)
        {
            var lp = from item in QuanLyKhachSan.LoaiPhongs
                     select item;
            cbLoaiPhong.DataSource = lp.ToList();
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbLoaiPhong.ValueMember = "MaLoaiPhong";

            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.Items.Add("Nam");

            var p = from item in QuanLyKhachSan.Phongs
                    join l in QuanLyKhachSan.LoaiPhongs
                    on item.MaLoaiPhong equals l.MaLoaiPhong
                    join tt in QuanLyKhachSan.TrangThais
                    on item.MaTrangThai equals tt.MaTrangThai
                    join dd in QuanLyKhachSan.DonDeps
                    on item.MaDonDep equals dd.MaDonDep
                    where l.TenLoaiPhong.Contains(cbLoaiPhong.Text) && tt.TenTrangThai.Contains("Phòng trống")
                    select new
                    {
                        item.MaPhong,
                        l.TenLoaiPhong,
                        tt.TenTrangThai,
                        dd.TenDonDep
                    };
            DataDatPhong.DataSource = p.ToList();
            DataDatPhong.Columns[0].HeaderText = "Số phòng";
            DataDatPhong.Columns[1].HeaderText = "Loại phòng";
            DataDatPhong.Columns[2].HeaderText = "Trạng thái";
            DataDatPhong.Columns[3].HeaderText = "Tình trạng";
            displayKhachHang();
            
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            var p = from item in QuanLyKhachSan.Phongs
                    join l in QuanLyKhachSan.LoaiPhongs
                    on item.MaLoaiPhong equals l.MaLoaiPhong
                    join tt in QuanLyKhachSan.TrangThais
                    on item.MaTrangThai equals tt.MaTrangThai
                    join dd in QuanLyKhachSan.DonDeps
                    on item.MaDonDep equals dd.MaDonDep
                    where l.TenLoaiPhong.Contains(cbLoaiPhong.Text) && tt.TenTrangThai.Contains("Phòng trống")
                    select new
                    {
                        item.MaPhong,
                        l.TenLoaiPhong,
                        tt.TenTrangThai,
                        dd.TenDonDep
                    };
            DataDatPhong.DataSource = p.ToList();
            DataDatPhong.Columns[0].HeaderText = "Số phòng";
            DataDatPhong.Columns[1].HeaderText = "Loại phòng";
            DataDatPhong.Columns[2].HeaderText = "Trạng thái";
            DataDatPhong.Columns[3].HeaderText = "Tình trạng";
        }
        public void displayKhachHang()
        {
            var mkh = from item in QuanLyKhachSan.KhachHangs
                      where item.CCCD.Contains(txtCCCD.Text)
                      select new
                      {
                          item.MaKhachHang
                      };
            datakhachhang.DataSource = mkh.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var kkh = from item in QuanLyKhachSan.KhachHangs
                      where item.CCCD == txtCCCD.Text
                      select item;
            if (kkh.Count() > 0)
            {
                MessageBox.Show("Khách hàng này đã có trong danh sách!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCCCD.Clear();
                return;
            }
            else
            {
                KhachHang kh = new KhachHang();
                kh.TenKhachHang = txtTenkh.Text;
                kh.GioiTinh = Convert.ToBoolean(cbGioiTinh.SelectedIndex);
                kh.CCCD = txtCCCD.Text;
                kh.SDT = txtSDT.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.QuocTich = txtQuocGia.Text;
                QuanLyKhachSan.KhachHangs.Add(kh);
                QuanLyKhachSan.SaveChanges();
                displayKhachHang();
            }
        }
    }
}

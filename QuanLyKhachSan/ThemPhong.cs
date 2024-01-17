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
    public partial class ThemPhong : Form
    {
        QuanLyKhachSanEntities QuanLyKhachSan = new QuanLyKhachSanEntities();
        public ThemPhong()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var ktp = from item in QuanLyKhachSan.Phongs
                      where item.MaPhong == txtMaPhong.Text.Trim()
                      select item;
            if(ktp.Count() > 0)
            {
                MessageBox.Show("Phòng đã có!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Phong p = new Phong();
                p.MaPhong = txtMaPhong.Text.Trim();
                p.MaDonDep = Convert.ToInt16(cbTinhTrang.SelectedValue);
                p.MaLoaiPhong = Convert.ToInt16(cbLoaiPhong.SelectedValue);
                p.MaTrangThai = 3;
                QuanLyKhachSan.Phongs.Add(p);
                QuanLyKhachSan.SaveChanges();
                Close();
            }
        }

        private void ThemPhong_Load(object sender, EventArgs e)
        {
            var tt = from item in QuanLyKhachSan.DonDeps
                     select item;
            cbTinhTrang.DataSource = tt.ToList();
            cbTinhTrang.DisplayMember = "TenDonDep";
            cbTinhTrang.ValueMember = "MaDonDep";

            var lp = from item in QuanLyKhachSan.LoaiPhongs
                     select item;
            cbLoaiPhong.DataSource = lp.ToList();
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbLoaiPhong.ValueMember = "MaLoaiPhong";
        }
    }
}

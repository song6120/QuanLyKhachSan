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
    public partial class SuaPhong : Form
    {
        QuanLyKhachSanEntities QuanLyKhachSan = new QuanLyKhachSanEntities();
        public static string id;
        public static int tinhtrang;
        public static int loaiphong;
        public SuaPhong()
        {
            InitializeComponent();
        }

        private void SuaPhong_Load(object sender, EventArgs e)
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
            txtMaPhong.Text = id;
            cbTinhTrang.SelectedValue = tinhtrang;
            cbLoaiPhong.SelectedValue = loaiphong;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var p = from item in QuanLyKhachSan.Phongs
                    where item.MaPhong == id
                    select item;
            Phong sp = p.First();
            sp.MaPhong = txtMaPhong.Text;
            sp.MaDonDep = Convert.ToInt16(cbTinhTrang.SelectedValue);
            sp.MaLoaiPhong = Convert.ToInt16(cbLoaiPhong.SelectedValue);
            QuanLyKhachSan.SaveChanges();
            Close();
        }
    }
}

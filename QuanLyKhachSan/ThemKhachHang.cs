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
    public partial class ThemKhachHang : Form
    {
        QuanLyKhachSanEntities quanLyKhachSan;
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            quanLyKhachSan = new QuanLyKhachSanEntities();
            var tkh = from item in quanLyKhachSan.KhachHangs
                      where item.CCCD == txtCCCD.Text
                      select item;
            if (tkh.Count() > 0)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Khách hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK) return;
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
                quanLyKhachSan.KhachHangs.Add(kh);
                quanLyKhachSan.SaveChanges();
                Close();
            }
        }

        private void ThemKhachHang_Load(object sender, EventArgs e)
        {
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.Items.Add("Nam");
        }
    }
}

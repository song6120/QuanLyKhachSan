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
    public partial class ThemTaiKhoan : Form
    {
        QuanLyKhachSanEntities QuanLyKhachSan = new QuanLyKhachSanEntities();
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var kttk = from nv in QuanLyKhachSan.NhanViens
                       join ttk in QuanLyKhachSan.TaiKhoans
                       on nv.MaNhanVien equals ttk.MaNhanVien
                       where (nv.TenNhanVien == cbNhanVien.Text) || (ttk.TenTaiKhoan == txtTenTaiKhoan.Text)
                       select ttk;
            if (kttk.Count() > 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTaiKhoan.Clear();
                return;
            }
            else
            {
                TaiKhoan tk = new TaiKhoan();
                tk.MaNhanVien = Convert.ToInt16(cbNhanVien.SelectedValue);
                tk.TenTaiKhoan = txtTenTaiKhoan.Text;
                tk.MatKhau = txtMatKhau.Text;
                tk.CapDo = Convert.ToInt16(cbCapDo.Text);
                QuanLyKhachSan.TaiKhoans.Add(tk);
                QuanLyKhachSan.SaveChanges();
                Close();
            }
        }

        private void ThemTaiKhoan_Load(object sender, EventArgs e)
        {
            var nv = from item in QuanLyKhachSan.NhanViens
                     select item;
            cbNhanVien.DataSource = nv.ToList();
            cbNhanVien.DisplayMember = "TenNhanVien";
            cbNhanVien.ValueMember = "MaNhanVien";

            cbCapDo.Items.Add("1");
            cbCapDo.Items.Add("2");
            cbCapDo.Items.Add("3");
        }
    }
}

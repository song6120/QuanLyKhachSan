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
    public partial class Login : Form
    {
        QuanLyKhachSanEntities QuanLyKhachSan = new QuanLyKhachSanEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            var dn = from item in QuanLyKhachSan.TaiKhoans
                     where item.TenTaiKhoan == txtTaiKhoan.Text && item.MatKhau == txtMatKhau.Text
                     select item;
            if(dn.Count() > 0)
            {
                TrangChu trangChu = new TrangChu();
                TrangChu.tenadmin = txtTaiKhoan.Text;
                trangChu.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không chính xác!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtTaiKhoan.Clear();
                return;
            }
        }
    }
}

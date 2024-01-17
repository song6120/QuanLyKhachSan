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
    public partial class SuaTaiKhoan : Form
    {
        QuanLyKhachSanEntities QuanLyKhachSan = new QuanLyKhachSanEntities();
        public static int id;
        public static string tentk;
        public static string tennv;
        public static string mk;
        public static string capdo;
        public SuaTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Chắc chắn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No) return;
            var tk = from item in QuanLyKhachSan.TaiKhoans
                     where item.TenTaiKhoan == txtTenTaiKhoan.Text
                     select item;
            if(tk.Count() > 0)
            {
                MessageBox.Show("Tên tài khoản này đã tồn tại!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTaiKhoan.Clear();
                return;
            }
            else
            {
                var kttk = from item in QuanLyKhachSan.TaiKhoans
                           where item.MaTaiKhoan == id
                           select item;
                TaiKhoan taiKhoan = kttk.First();
                taiKhoan.TenTaiKhoan = txtTenTaiKhoan.Text;
                taiKhoan.MatKhau = txtMatKhau.Text;
                taiKhoan.CapDo = Convert.ToInt16(cbCapDo.Text);
                QuanLyKhachSan.SaveChanges();
                Close();
            }
        }

        private void SuaTaiKhoan_Load(object sender, EventArgs e)
        {
            cbCapDo.Items.Add("1");
            cbCapDo.Items.Add("2");
            cbCapDo.Items.Add("3");

            lbTenTaiKhoan.Text = "Tài Khoản: " + tennv;
            txtTenTaiKhoan.Text = tentk;
            txtMatKhau.Text = mk;
            cbCapDo.SelectedItem = capdo;
        }
    }
}

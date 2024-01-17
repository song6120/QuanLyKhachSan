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
    public partial class SuaKhachHang : Form
    {
        public static int id;
        public static string Tenkh = "";
        public static string cccd = "";
        public static string sdt = "" ;
        public static string quocgia = "";
        public static string diachi = "";
        public static int gioitinh;
        QuanLyKhachSanEntities QuanLyKhachSan = new QuanLyKhachSanEntities();
        public SuaKhachHang()
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
            dr = MessageBox.Show("Chắc chắn sửa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No) return;
            var upkh = from item in QuanLyKhachSan.KhachHangs
                       where item.MaKhachHang == id
                       select item;
            KhachHang kh = upkh.First();
            kh.TenKhachHang = txtTenkh.Text;
            kh.GioiTinh = Convert.ToBoolean(cbGioiTinh.SelectedIndex);
            kh.CCCD = txtCCCD.Text;
            kh.SDT = txtSDT.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.QuocTich = txtQuocGia.Text;
            QuanLyKhachSan.SaveChanges();
            Close();
        }

        private void SuaKhachHang_Load(object sender, EventArgs e)
        {
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.Items.Add("Nam");
            txtTenkh.Text = Tenkh;
            txtCCCD.Text = cccd;
            txtSDT.Text = sdt;
            txtDiaChi.Text = diachi;
            txtQuocGia.Text = quocgia;
            cbGioiTinh.SelectedIndex = gioitinh;
        }
    }
}

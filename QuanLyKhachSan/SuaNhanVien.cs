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
    public partial class SuaNhanVien : Form
    {
        QuanLyKhachSanEntities quanLyKhachSan;
        public static int id;
        public static string Tennv = "";
        public static string cccd = "";
        public static string sdt = "";
        public static string quocgia = "";
        public static string diachi = "";
        public static int chucvu;
        public static string ngaysinh = "";
        public static string luong = "";
        public static int gioitinh;
        public SuaNhanVien()
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
            var nv = from item in quanLyKhachSan.NhanViens
                     where item.MaNhanVien == id
                     select item;

            NhanVien nnv = nv.First();
            nnv.TenNhanVien = txtTennv.Text;
            nnv.MaChucVu = Convert.ToInt16(cbChucVu.SelectedValue);
            nnv.NgaySinh = Convert.ToDateTime(txtNgaysinh.Text);
            nnv.CCCD = txtCCCD.Text;
            nnv.SDT = txtSDT.Text;
            nnv.DiaChi = txtDiaChi.Text;
            nnv.QuocTich = txtQuocGia.Text;
            nnv.GioiTinh = Convert.ToBoolean(cbGioiTinh.SelectedIndex);
            nnv.Luong = Convert.ToDecimal(txtLuong.Text);

            quanLyKhachSan.SaveChanges();
            Close();
        }

        private void SuaNhanVien_Load(object sender, EventArgs e)
        {
            quanLyKhachSan = new QuanLyKhachSanEntities();
            var cv = from item in quanLyKhachSan.ChucVus
                     select item;
            cbChucVu.DataSource = cv.ToList();
            cbChucVu.DisplayMember = "TenChucVu";
            cbChucVu.ValueMember = "MaChucVu";

            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.Items.Add("Nam");

            txtTennv.Text = Tennv;
            txtCCCD.Text = cccd;
            txtSDT.Text = sdt;
            txtDiaChi.Text = diachi;
            txtNgaysinh.Text = ngaysinh;
            cbGioiTinh.SelectedIndex = gioitinh;
            txtQuocGia.Text = quocgia;
            txtLuong.Text = luong;
            cbChucVu.SelectedValue = chucvu;
        }
    }
}

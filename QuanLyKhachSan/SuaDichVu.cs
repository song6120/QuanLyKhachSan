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
    public partial class SuaDichVu : Form
    {
        QuanLyKhachSanEntities QuanLyKhachSan = new QuanLyKhachSanEntities();
        public static int id;
        public static string tendv;
        public static int loaidv;
        public static string gia;
        public SuaDichVu()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SuaDichVu_Load(object sender, EventArgs e)
        {
            var ldv = from item in QuanLyKhachSan.LoaiDichVus
                      select item;
            cbLoaiDichVu.DataSource = ldv.ToList();
            cbLoaiDichVu.DisplayMember = "TenLoaiDichVu";
            cbLoaiDichVu.ValueMember = "MaLoaiDichVu";

            txtTenDichVu.Text = tendv;
            txtDonGia.Text = gia;
            cbLoaiDichVu.SelectedValue = loaidv;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var dv = from item in QuanLyKhachSan.DichVus
                     where item.MaDichVu == id
                     select item;
            DichVu dichVu = dv.First();
            dichVu.TenDichVu = txtTenDichVu.Text;
            dichVu.Gia = Convert.ToDecimal(txtDonGia.Text);
            dichVu.MaLoaiDichVu = Convert.ToInt16(cbLoaiDichVu.SelectedValue);
            QuanLyKhachSan.SaveChanges();
            Close();
        }
    }
}

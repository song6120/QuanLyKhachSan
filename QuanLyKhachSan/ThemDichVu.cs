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
    public partial class ThemDichVu : Form
    {
        QuanLyKhachSanEntities QuanLyKhachSan = new QuanLyKhachSanEntities();
        public ThemDichVu()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var ktldv = from item in QuanLyKhachSan.DichVus
                       where item.TenDichVu == txtTenDichVu.Text.Trim()
                       select item;
            if (ktldv.Count() > 0)
            {
                MessageBox.Show("Loại dịch vụ này đã tồn tại!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDichVu.Clear();
                txtGia.Clear();
                return;
            }
            else
            {
                DichVu dv = new DichVu();
                dv.TenDichVu = txtTenDichVu.Text;
                dv.MaLoaiDichVu = Convert.ToInt16(cbLoaiDichVu.SelectedValue);
                dv.Gia = Convert.ToDecimal(txtGia.Text);
                QuanLyKhachSan.DichVus.Add(dv);
                QuanLyKhachSan.SaveChanges();
                Close();
            }
        }

        private void ThemDichVu_Load(object sender, EventArgs e)
        {
            var ldv = from item in QuanLyKhachSan.LoaiDichVus
                      select item;
            cbLoaiDichVu.DataSource = ldv.ToList();
            cbLoaiDichVu.DisplayMember = "TenLoaiDichVu";
            cbLoaiDichVu.ValueMember = "MaLoaiDichVu";
        }
    }
}

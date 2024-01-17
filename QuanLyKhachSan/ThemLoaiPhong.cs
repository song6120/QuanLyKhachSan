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
    public partial class ThemLoaiPhong : Form
    {
        QuanLyKhachSanEntities quanLyKhachSan;
        public ThemLoaiPhong()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void ThemLoaiPhong_Load(object sender, EventArgs e)
        {
            quanLyKhachSan = new QuanLyKhachSanEntities();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var ktlp = from item in quanLyKhachSan.LoaiPhongs
                       where item.TenLoaiPhong == txtTenLoaiPhong.Text.Trim()
                       select item;
            if (ktlp.Count() > 0)
            {
                MessageBox.Show("Loại phòng này đã tồn tại!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoaiPhong.Clear();
                txtSoGiuong.Clear();
                txtGiaNgay.Clear();
                txtGiaGio.Clear();
                return;
            }
            else
            {
                LoaiPhong lp = new LoaiPhong();
                lp.TenLoaiPhong = txtTenLoaiPhong.Text;
                lp.SoGiuong = Convert.ToInt16(txtSoGiuong.Text);
                lp.GiaNgay = Convert.ToDecimal(txtGiaNgay.Text);
                lp.GiaGio = Convert.ToDecimal(txtGiaGio.Text);
                quanLyKhachSan.LoaiPhongs.Add(lp);
                quanLyKhachSan.SaveChanges();
                Close();
            }
        }
    }
}

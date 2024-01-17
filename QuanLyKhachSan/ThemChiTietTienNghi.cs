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
    public partial class ThemChiTietTienNghi : Form
    {
        QuanLyKhachSanEntities QuanLyKhachSan = new QuanLyKhachSanEntities();
        public ThemChiTietTienNghi()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var kt = from cttn in QuanLyKhachSan.ChiTietTienNghis
                     join tiennghi in QuanLyKhachSan.TienNghis
                     on cttn.MaTienNghi equals tiennghi.MaTienNghi
                     where ((cttn.MaPhong == cbMaphong.Text) && (tiennghi.TenTienNghi == cbTienNghi.Text))
                     select cttn;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Tiện nghi đã có trong phòng!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int n = Convert.ToInt16(txtSoLuong.Text.Trim());
                if(n > 1)
                {
                    MessageBox.Show("Tiện nghi trong mỗi phòng không lớn hơn 1!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                    ChiTietTienNghi ct = new ChiTietTienNghi();
                    ct.MaPhong = cbMaphong.Text;
                    ct.MaTienNghi = Convert.ToInt16(cbTienNghi.SelectedValue);
                    ct.SoLuong = n;
                    QuanLyKhachSan.ChiTietTienNghis.Add(ct);
                    QuanLyKhachSan.SaveChanges();
                    Close();
            }
        }

        private void ThemChiTietTienNghi_Load(object sender, EventArgs e)
        {
            var p = from item in QuanLyKhachSan.Phongs
                    select item;
            cbMaphong.DataSource = p.ToList();
            cbMaphong.DisplayMember = "MaPhong";
            cbMaphong.ValueMember = "MaPhong";

            var tiennghi = from item in QuanLyKhachSan.TienNghis
                           select item;
            cbTienNghi.DataSource = tiennghi.ToList();
            cbTienNghi.DisplayMember = "TenTienNghi";
            cbTienNghi.ValueMember = "MaTienNghi";
        }
    }
}

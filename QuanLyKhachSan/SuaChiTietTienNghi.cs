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
    public partial class SuaChiTietTienNghi : Form
    {
        QuanLyKhachSanEntities QuanLyKhachSan = new QuanLyKhachSanEntities();
        public static int id;
        public static string phong;
        public static int tn;
        public static string soluong;
        public SuaChiTietTienNghi()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var kt = from cttn in QuanLyKhachSan.ChiTietTienNghis
                     join tiennghi in QuanLyKhachSan.TienNghis
                     on cttn.MaTienNghi equals tiennghi.MaTienNghi
                     where ((cttn.MaPhong == cbPhong.Text) && (tiennghi.TenTienNghi == cbTienNghi.Text))
                     select cttn;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Tiện nghi đã có trong phòng!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int n = Convert.ToInt16(txtSoLuong.Text.Trim());
                if (n > 1)
                {
                    MessageBox.Show("Tiện nghi trong mỗi phòng không lớn hơn 1!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var ct = from item in QuanLyKhachSan.ChiTietTienNghis
                                     where item.MaChiTietTienNghi == id
                                     select item;
                ChiTietTienNghi cttn = ct.First();
                cttn.MaPhong = cbPhong.Text.Trim();
                cttn.MaTienNghi = Convert.ToInt16(cbTienNghi.SelectedValue);
                cttn.SoLuong = n;
                QuanLyKhachSan.SaveChanges();
                Close();
            }
        }

        private void SuaChiTietTienNghi_Load(object sender, EventArgs e)
        {
            var p = from item in QuanLyKhachSan.Phongs
                    select item;
            cbPhong.DataSource = p.ToList();
            cbPhong.DisplayMember = "MaPhong";
            cbPhong.ValueMember = "MaPhong";

            var tiennghi = from item in QuanLyKhachSan.TienNghis
                           select item;
            cbTienNghi.DataSource = tiennghi.ToList();
            cbTienNghi.DisplayMember = "TenTienNghi";
            cbTienNghi.ValueMember = "MaTienNghi";

            cbPhong.SelectedValue = phong;
            cbTienNghi.SelectedValue = tn;

            txtSoLuong.Text = soluong;

        }
    }
}

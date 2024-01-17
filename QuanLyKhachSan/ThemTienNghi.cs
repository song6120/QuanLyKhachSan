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
    public partial class ThemTienNghi : Form
    {
        QuanLyKhachSanEntities quanLyKhachSan = new QuanLyKhachSanEntities();
        public ThemTienNghi()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var kt = from item in quanLyKhachSan.TienNghis
                     where item.TenTienNghi == txtTienNghi.Text
                     select item;
            if(kt.Count() > 0)
            {
                MessageBox.Show("Tiện nghi này đã có", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                TienNghi tiennghi = new TienNghi();
                tiennghi.TenTienNghi = txtTienNghi.Text;
                quanLyKhachSan.TienNghis.Add(tiennghi);
                quanLyKhachSan.SaveChanges();
                Close();
            }
        }
    }
}

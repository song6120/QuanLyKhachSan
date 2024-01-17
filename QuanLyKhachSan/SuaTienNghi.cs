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
    public partial class SuaTienNghi : Form
    {
        QuanLyKhachSanEntities quanLyKhachSan = new QuanLyKhachSanEntities();
        public static int id;
        public static string tentn;
        public SuaTienNghi()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var kt = from item in quanLyKhachSan.TienNghis
                     where item.TenTienNghi == txtTenTienNghi.Text
                     select item;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng tiện nghi!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                var tiennghi = from item in quanLyKhachSan.TienNghis
                               where item.MaTienNghi == id
                               select item;
                TienNghi suatiennghi = tiennghi.First();
                suatiennghi.TenTienNghi = txtTenTienNghi.Text;
                quanLyKhachSan.SaveChanges();
                Close();
            }
            
        }

        private void SuaTienNghi_Load(object sender, EventArgs e)
        {
            txtTenTienNghi.Text = tentn;
        }
    }
}

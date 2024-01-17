using QuanLyKhachSan;
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
    public partial class ThemLoaiDichVu : Form
    {
        private QuanLyKhachSanEntities QuanLyKhachSan;
        public ThemLoaiDichVu()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var lldv = from item in QuanLyKhachSan.LoaiDichVus
                      where item.TenLoaiDichVu == txtLoaiDichVu.Text
                      select item;
            if (lldv.Count() > 0)
            {
                MessageBox.Show("Loại dịch vụ này đã có!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoaiDichVu.Clear();
                return;
            }
            else
            {
                LoaiDichVu ldv = new LoaiDichVu();
                ldv.TenLoaiDichVu = txtLoaiDichVu.Text;
                QuanLyKhachSan.LoaiDichVus.Add(ldv);
                QuanLyKhachSan.SaveChanges();
                Close();
            }
        }

        private void ThemLoaiDichVu_Load(object sender, EventArgs e)
        {
            QuanLyKhachSan = new QuanLyKhachSanEntities();
        }
    }
}

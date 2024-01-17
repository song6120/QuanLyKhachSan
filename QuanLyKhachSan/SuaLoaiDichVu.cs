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
    public partial class SuaLoaiDichVu : Form
    {
        QuanLyKhachSanEntities quanLyKhachSan = new QuanLyKhachSanEntities();
        public static int id;
        public static string tenldv;
        public SuaLoaiDichVu()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var lldv = from item in quanLyKhachSan.LoaiDichVus
                       where item.TenLoaiDichVu == txtTenLoaiDichVu.Text
                       select item;
            if (lldv.Count() > 0)
            {
                MessageBox.Show("Loại dịch vụ này đã có!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoaiDichVu.Clear();
                return;
            }
            else
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Chắc chắn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No) return;
                var ldv = from item in quanLyKhachSan.LoaiDichVus
                          where item.MaLoaiDichVu == id
                          select item;
                LoaiDichVu loaiDichVu = ldv.First();
                loaiDichVu.TenLoaiDichVu = txtTenLoaiDichVu.Text;
                quanLyKhachSan.SaveChanges();
                Close();
            }

        }

        private void SuaLoaiDichVu_Load(object sender, EventArgs e)
        {
            txtTenLoaiDichVu.Text = tenldv;
        }
    }
}

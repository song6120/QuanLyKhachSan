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
    public partial class ThemNhanVien : Form
    {
        private QuanLyKhachSanEntities quanLyKhachSan;
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            quanLyKhachSan = new QuanLyKhachSanEntities();
            var tnv = from item in quanLyKhachSan.NhanViens
                      where item.CCCD == txtCCCD.Text
                      select item;
            if (tnv.Count() > 0)
            {
                MessageBox.Show("Nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string ns = cbNgaysinh.Value.ToString();
                string[] ngaysinh = ns.Split(new char[] { ' ' });
                NhanVien nv = new NhanVien();
                nv.TenNhanVien = txtTennv.Text;
                nv.NgaySinh = Convert.ToDateTime(ngaysinh[0]);
                nv.SDT = txtSDT.Text;
                nv.GioiTinh = Convert.ToBoolean(cbGioiTinh.SelectedIndex);
                nv.CCCD = txtCCCD.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.Luong = Convert.ToDecimal(txtLuong.Text);
                nv.MaChucVu = Convert.ToInt16(cbChucVu.SelectedValue.ToString());
                nv.QuocTich = txtQuocGia.Text;
                quanLyKhachSan.NhanViens.Add(nv);
                quanLyKhachSan.SaveChanges();
                Close();
            }
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            quanLyKhachSan = new QuanLyKhachSanEntities();
            var cv = from item in quanLyKhachSan.ChucVus
                     select item;
            cbChucVu.DataSource = cv.ToList();
            cbChucVu.DisplayMember = "TenChucVu";
            cbChucVu.ValueMember = "MaChucVu";

            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.Items.Add("Nam");
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
         //   MessageBox.Show(cbdate.Value.ToString(), "Thông báo..", MessageBoxButtons.OK);
        }
    }
}

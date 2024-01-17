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
    public partial class SuaLoaiPhong : Form
    {
        QuanLyKhachSanEntities quanLyKhachSan = new QuanLyKhachSanEntities();
        public static int id;
        public static string tenlp="";
        public static int sogiuong;
        public static string giangay="";
        public static string giagio = "";
        public SuaLoaiPhong()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var ktlp = from item in quanLyKhachSan.LoaiPhongs
                       where item.TenLoaiPhong == txtTenLoaiPhong.Text.Trim()
                       select item;
            if (ktlp.Count() > 0)
            {
                MessageBox.Show("Loại phòng này đã tồn tại!", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Chắc chắn sửa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No) return;

                var lp = from item in quanLyKhachSan.LoaiPhongs
                         where item.MaLoaiPhong == id
                         select item;

                LoaiPhong addlp = lp.First();
                addlp.TenLoaiPhong = txtTenLoaiPhong.Text;
                addlp.SoGiuong = Convert.ToInt16(txtSoGiuong.Text);
                addlp.GiaNgay = Convert.ToDecimal(txtGiaNgay.Text);
                addlp.GiaGio = Convert.ToDecimal(txtGiaGio.Text);

                quanLyKhachSan.SaveChanges();
                Close();
            }

        }

        private void SuaLoaiPhong_Load(object sender, EventArgs e)
        {
            txtTenLoaiPhong.Text = tenlp;
            txtSoGiuong.Text = sogiuong.ToString();
            txtGiaNgay.Text = giangay;
            txtGiaGio.Text = giagio;
        }
    }
}

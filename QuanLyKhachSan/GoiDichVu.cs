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
    public partial class GoiDichVu : Form
    {
        QuanLyKhachSanEntities QuanLyKhachSan = new QuanLyKhachSanEntities();
        public static int id;

        public GoiDichVu()
        {
            InitializeComponent();
        }

        private void GoiDichVu_Load(object sender, EventArgs e)
        {
            var ldv = from item in QuanLyKhachSan.LoaiDichVus
                      select item;
            cbLoaiDichVu.DataSource = ldv.ToList();
            cbLoaiDichVu.DisplayMember = "TenLoaiDichVu";
            cbLoaiDichVu.ValueMember = "MaLoaiDichVu";


            Display();

        }
        public void Display()
        {
            var dv = from item in QuanLyKhachSan.DichVus
                     join ld in QuanLyKhachSan.LoaiDichVus
                     on item.MaLoaiDichVu equals ld.MaLoaiDichVu
                     select new
                     {
                         item.MaDichVu,
                         ld.TenLoaiDichVu,
                         item.TenDichVu,
                         item.Gia
                     };
            DataDichVu.DataSource = dv.ToList();
            DataDichVu.Columns[1].HeaderText = "Mã dịch vụ";
            DataDichVu.Columns[2].HeaderText = "Loại";
            DataDichVu.Columns[3].HeaderText = "Tên dịch vụ";
            DataDichVu.Columns[4].HeaderText = "Giá";

            var ddv = from item in QuanLyKhachSan.DichVus
                      join ld in QuanLyKhachSan.LoaiDichVus
                      on item.MaLoaiDichVu equals ld.MaLoaiDichVu
                      join cthd in QuanLyKhachSan.ChiTietHoaDons
                      on item.MaDichVu equals cthd.MaDichVu
                      where cthd.MaDatPhong == id
                      select new
                      {
                          cthd.MaDichVu,
                          ld.TenLoaiDichVu,
                          item.TenDichVu,
                          cthd.SoLuong,
                          cthd.TongTien
                      };
            DataDichVuDaChon.DataSource = ddv.ToList();
            DataDichVuDaChon.Columns[1].HeaderText = "Mã dịch vụ";
            DataDichVuDaChon.Columns[2].HeaderText = "Loại";
            DataDichVuDaChon.Columns[3].HeaderText = "Tên dịch vụ";
            DataDichVuDaChon.Columns[4].HeaderText = "Số lượng";
            DataDichVuDaChon.Columns[5].HeaderText = "Giá";

        }

        private void lbPhong_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbLoaiDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ldv = from item in QuanLyKhachSan.DichVus
                      join l in QuanLyKhachSan.LoaiDichVus
                      on item.MaLoaiDichVu equals l.MaLoaiDichVu
                      where l.TenLoaiDichVu.Contains(cbLoaiDichVu.Text)
                      select new
                      {
                          item.MaDichVu,
                          l.TenLoaiDichVu,
                          item.TenDichVu,
                          item.Gia
                      };
            DataDichVu.DataSource = ldv.ToList();
            DataDichVu.Columns[1].HeaderText = "Mã dịch vụ";
            DataDichVu.Columns[2].HeaderText = "Loại";
            DataDichVu.Columns[3].HeaderText = "Tên dịch vụ";
            DataDichVu.Columns[4].HeaderText = "Giá";
        }

        private void DataDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataDichVu.Columns[e.ColumnIndex].Name == "Them")
            {


                int n = DataDichVu.CurrentRow.Index;
                int madv = Convert.ToInt16(DataDichVu.Rows[n].Cells[1].Value.ToString());

                var i = from item in QuanLyKhachSan.ChiTietHoaDons
                        where item.MaDichVu == madv
                        select item;

                if (i.Count() > 1)
                {
                    MessageBox.Show("Sản phẩm này đã có", "Thông báo...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    string gia = DataDichVu.Rows[n].Cells[4].Value.ToString();

                    ChiTietHoaDon chiTiet = new ChiTietHoaDon();
                    chiTiet.MaDatPhong = id;
                    chiTiet.MaDichVu = madv;
                    chiTiet.SoLuong = 1;
                    chiTiet.TongTien = Convert.ToDecimal(gia);

                    QuanLyKhachSan.ChiTietHoaDons.Add(chiTiet);
                    Display();
                }
               
            }
        }

        private void DataDichVuDaChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataDichVuDaChon.Columns[e.ColumnIndex].Name == "Xoa")
            {
                int n = DataDichVuDaChon.CurrentRow.Index;
                int madv = Convert.ToInt16(DataDichVuDaChon.Rows[n].Cells[1].Value.ToString());

                var i = from item in QuanLyKhachSan.ChiTietHoaDons
                        where item.MaDichVu == madv
                        select item;

                ChiTietHoaDon chiTiet = i.First();
                QuanLyKhachSan.ChiTietHoaDons.Remove(chiTiet);
                QuanLyKhachSan.SaveChanges();
                Display();
            }
        }
    }
}

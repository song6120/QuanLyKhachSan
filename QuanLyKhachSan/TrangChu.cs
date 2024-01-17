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
    public partial class TrangChu : Form
    {
        public static string tenadmin;
        private bool sideBar;
        private bool sideBarMenu;
        private QuanLyKhachSanEntities quanLyKhachSan;
        public TrangChu()
        {
            InitializeComponent();
        }

        private void timersidebar_Tick(object sender, EventArgs e)
        {
            if (sideBar)
            {
                sidebarmenu.Width -= 10;
                if (sidebarmenu.Width == sidebarmenu.MinimumSize.Width)
                {
                    timersidebar.Stop();
                    sideBar = false;
                }
            }
            else
            {
                sidebarmenu.Width += 10;
                if (sidebarmenu.Width == sidebarmenu.MaximumSize.Width)
                {
                    timersidebar.Stop();
                    sideBar = true;
                }
            }
        }

        private void timemenuadmin_Tick(object sender, EventArgs e)
        {
            if (sideBarMenu)
            {
                menuadmin.Height -= 30;
                if (menuadmin.Height == menuadmin.MinimumSize.Height)
                {
                    timemenuadmin.Stop();
                    sideBarMenu = false;
                }
            }
            else
            {
                menuadmin.Height += 30;
                if (menuadmin.Height == menuadmin.MaximumSize.Height)
                {
                    timemenuadmin.Stop();
                    sideBarMenu = true;
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            sideBarMenu = true;
            timemenuadmin.Start();
            timersidebar.Start();
        }
        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            panelKhachHang.Hide();
            panelTrangChu.Show();
            panelNhanVien.Hide();
            panelPhong.Hide();
            panelLoaiTienNghi.Hide();
            panelHoaDon.Hide();
            panelThongTinPhong.Hide();
            panelTienIch.Hide();
            panelDichVu.Hide();
            panelTaiKhoan.Hide();
            panelDatPhong.Hide();
            panelLoaiDichVu.Hide();
            panelLoaiPhong.Hide();
            sideBarMenu = true;
            sideBar = true;
            timemenuadmin.Start();
            timersidebar.Start();
        }
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            timemenuadmin.Start();
        }

        private void btnQLThongKe_Click(object sender, EventArgs e)
        {

        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            quanLyKhachSan = new QuanLyKhachSanEntities();
            panelKhachHang.Hide();
            panelTrangChu.Show();
            panelNhanVien.Hide();
            panelTienIch.Hide();
            panelHoaDon.Hide();
            panelTaiKhoan.Hide();
            panelDatPhong.Hide();
            panelThongTinPhong.Hide();
            panelLoaiTienNghi.Hide();
            panelLoaiDichVu.Hide();
            panelPhong.Hide();
            panelDichVu.Hide();
            panelLoaiPhong.Hide();
            sideBarMenu = true;
            sideBar = true;
            timemenuadmin.Start();
            timersidebar.Start();

            txtTenAdmin.Text = tenadmin;
        }

        //Quản lý khách hàng

        public void DisplayKhachHang()
        {
            var nv = from item in quanLyKhachSan.KhachHangs
                     select new
                     {
                         item.MaKhachHang,
                         item.TenKhachHang,
                         item.CCCD,
                         item.SDT,
                         item.DiaChi,
                         item.GioiTinh,
                         item.QuocTich,
                     };
            DataKhachHang.DataSource = nv.ToList();
            DataKhachHang.Columns[2].HeaderText = "Mã khách hàng";
            DataKhachHang.Columns[3].HeaderText = "Tên khách hàng";
            DataKhachHang.Columns[4].HeaderText = "CCCD";
            DataKhachHang.Columns[5].HeaderText = "Điện thoại";
            DataKhachHang.Columns[6].HeaderText = "Địa chỉ";
            DataKhachHang.Columns[7].HeaderText = "Giới tính";
            DataKhachHang.Columns[8].HeaderText = "Quốc tịch";
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            panelNhanVien.Hide();
            panelPhong.Hide();
            panelHoaDon.Hide();
            panelTrangChu.Hide();
            panelDatPhong.Hide();
            panelTienIch.Hide();
            panelTaiKhoan.Hide();
            panelLoaiTienNghi.Hide();
            panelThongTinPhong.Hide();
            panelDichVu.Hide();
            panelLoaiDichVu.Hide();
            panelLoaiPhong.Hide();
            panelKhachHang.Show();
            DisplayKhachHang();
            sideBarMenu = true;
            sideBar = true;
            timemenuadmin.Start();
            timersidebar.Start();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            ThemKhachHang tkh = new ThemKhachHang();
            tkh.ShowDialog();
            DisplayKhachHang();
        }

        private void btnTimKiemKhachHang_Click(object sender, EventArgs e)
        {
            var kh = from item in quanLyKhachSan.KhachHangs
                     where item.TenKhachHang.Contains(txtTenkh.text)
                     select new
                     {
                         item.MaKhachHang,
                         item.TenKhachHang,
                         item.CCCD,
                         item.SDT,
                         item.DiaChi,
                         item.GioiTinh,
                         item.QuocTich,
                     };
            DataKhachHang.DataSource = kh.ToList();
            DataKhachHang.Columns[2].HeaderText = "Mã khách hàng";
            DataKhachHang.Columns[3].HeaderText = "Tên khách hàng";
            DataKhachHang.Columns[4].HeaderText = "CCCD";
            DataKhachHang.Columns[5].HeaderText = "Điện thoại";
            DataKhachHang.Columns[6].HeaderText = "Địa chỉ";
            DataKhachHang.Columns[7].HeaderText = "Giới tính";
            DataKhachHang.Columns[8].HeaderText = "Quốc tịch";
        }

        private void DataKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataKhachHang.Columns[e.ColumnIndex].Name == "Xoa")
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Chắc chắn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No) return;
                int n = DataKhachHang.CurrentRow.Index;
                int id = Convert.ToInt16(DataKhachHang.Rows[n].Cells[2].Value.ToString());
                var dekh = from item in quanLyKhachSan.KhachHangs
                           where item.MaKhachHang == id
                           select item;
                quanLyKhachSan.KhachHangs.Remove(dekh.First());
                quanLyKhachSan.SaveChanges();
                DisplayKhachHang();
            }
            if(DataKhachHang.Columns[e.ColumnIndex].Name == "Sua")
            {
                int n = DataKhachHang.CurrentRow.Index;
                int id = Convert.ToInt16(DataKhachHang.Rows[n].Cells[2].Value.ToString());
                string ten = DataKhachHang.Rows[n].Cells[3].Value.ToString();
                string cd = DataKhachHang.Rows[n].Cells[4].Value.ToString();
                string dt = DataKhachHang.Rows[n].Cells[5].Value.ToString();
                string dc = DataKhachHang.Rows[n].Cells[6].Value.ToString();
                string qg = DataKhachHang.Rows[n].Cells[8].Value.ToString();
                bool gt = Convert.ToBoolean(DataKhachHang.Rows[n].Cells[7].Value.ToString());
                SuaKhachHang.id = id;
                SuaKhachHang.Tenkh = ten;
                SuaKhachHang.cccd = cd;
                SuaKhachHang.sdt = dt;
                SuaKhachHang.diachi = dc;
                if(gt == false)
                {
                    SuaKhachHang.gioitinh = 0;
                }
                else
                {
                    SuaKhachHang.gioitinh = 1;
                }
                SuaKhachHang.quocgia = qg;
                SuaKhachHang skh = new SuaKhachHang();
                skh.ShowDialog();
                DisplayKhachHang();
            }
        }


        //Quản lý nhân viên
        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            panelNhanVien.Show();
            panelKhachHang.Hide();
            panelTaiKhoan.Hide();
            panelDatPhong.Hide();
            panelTrangChu.Hide();
            panelHoaDon.Hide();
            panelLoaiTienNghi.Hide();
            panelTienIch.Hide();
            panelThongTinPhong.Hide();
            panelPhong.Hide();
            panelLoaiDichVu.Hide();
            panelLoaiPhong.Hide();
            panelDichVu.Hide();
            sideBarMenu = true;
            sideBar = true;
            timemenuadmin.Start();
            timersidebar.Start();
            DisplayNhanVien();
        }
        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            ThemNhanVien tnv = new ThemNhanVien();
            tnv.ShowDialog();
            DisplayNhanVien();
        }

        private void btnTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            var ttnv = from nv in quanLyKhachSan.NhanViens
                       join cv in quanLyKhachSan.ChucVus
                       on nv.MaChucVu equals cv.MaChucVu
                       where nv.TenNhanVien.Contains(txtTennv.text)
                       select new
                       {
                           nv.MaNhanVien,
                           nv.MaChucVu,
                           nv.TenNhanVien,
                           nv.NgaySinh,
                           cv.TenChucVu,
                           nv.GioiTinh,
                           nv.DiaChi,
                           nv.SDT,
                           nv.CCCD,
                           nv.QuocTich,
                           nv.Luong
                       };
            DataNhanVien.DataSource = ttnv.ToList();
            DataNhanVien.Columns[2].HeaderText = "Mã nhân viên";
            DataNhanVien.Columns[3].HeaderText = "Mã chức vụ";
            DataNhanVien.Columns[4].HeaderText = "Tên nhân viên";
            DataNhanVien.Columns[5].HeaderText = "Giới tình";
            DataNhanVien.Columns[6].HeaderText = "Địa chỉ";
            DataNhanVien.Columns[7].HeaderText = "Điện thoại";
            DataNhanVien.Columns[8].HeaderText = "CCCD";
            DataNhanVien.Columns[9].HeaderText = "Quốc gia";
            DataNhanVien.Columns[10].HeaderText = "Lương";
        }
        private void DisplayNhanVien()
        {
            var ttnv = from nv in quanLyKhachSan.NhanViens
                       join cv in quanLyKhachSan.ChucVus
                       on nv.MaChucVu equals cv.MaChucVu
                       select new
                       {
                           nv.MaNhanVien,
                           nv.MaChucVu,
                           nv.TenNhanVien,
                           nv.NgaySinh,
                           cv.TenChucVu,
                           nv.GioiTinh,
                           nv.DiaChi,
                           nv.SDT,
                           nv.CCCD,
                           nv.QuocTich,
                           nv.Luong
                       };
            DataNhanVien.DataSource = ttnv.ToList();
            DataNhanVien.Columns[2].HeaderText = "Mã nhân viên";
            DataNhanVien.Columns[3].HeaderText = "Mã chức vụ";
            DataNhanVien.Columns[4].HeaderText = "Tên nhân viên";
            DataNhanVien.Columns[5].HeaderText = "Giới tình";
            DataNhanVien.Columns[6].HeaderText = "Địa chỉ";
            DataNhanVien.Columns[7].HeaderText = "Điện thoại";
            DataNhanVien.Columns[8].HeaderText = "CCCD";
            DataNhanVien.Columns[9].HeaderText = "Quốc gia";
            DataNhanVien.Columns[10].HeaderText = "Lương";
        }

        private void DataNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataNhanVien.Columns[e.ColumnIndex].Name == "XoaNV")
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Chắc chắn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No) return;
                int n = DataNhanVien.CurrentRow.Index;
                int id = Convert.ToInt16(DataNhanVien.Rows[n].Cells[2].Value.ToString());
                var xoanv = from item in quanLyKhachSan.NhanViens
                            where item.MaNhanVien == id
                            select item;
                quanLyKhachSan.NhanViens.Remove(xoanv.First());
                quanLyKhachSan.SaveChanges();
                DisplayNhanVien();
            }
            if (DataNhanVien.Columns[e.ColumnIndex].Name == "SuaNV")
            {
                int n = DataNhanVien.CurrentRow.Index;
                int id = Convert.ToInt16(DataNhanVien.Rows[n].Cells[2].Value.ToString());
                int cv =Convert.ToInt16(DataNhanVien.Rows[n].Cells[3].Value.ToString());
                string tennv = DataNhanVien.Rows[n].Cells[4].Value.ToString();
                string ngays = DataNhanVien.Rows[n].Cells[5].Value.ToString();
                string[] ns = ngays.Split(new char[] { ' ' });
                bool gt = Convert.ToBoolean(DataNhanVien.Rows[n].Cells[7].Value.ToString());
                string dc = DataNhanVien.Rows[n].Cells[8].Value.ToString();
                string sdt = DataNhanVien.Rows[n].Cells[9].Value.ToString();
                string cccd = DataNhanVien.Rows[n].Cells[10].Value.ToString();
                string quocgia = DataNhanVien.Rows[n].Cells[11].Value.ToString();
                string luong = DataNhanVien.Rows[n].Cells[12].Value.ToString();

                SuaNhanVien.id = id;
                SuaNhanVien.Tennv = tennv;
                SuaNhanVien.ngaysinh = ns[0];
                SuaNhanVien.diachi = dc;
                SuaNhanVien.sdt = sdt;
                SuaNhanVien.cccd = cccd;
                SuaNhanVien.luong = luong;
                SuaNhanVien.chucvu = cv;
                SuaNhanVien.quocgia = quocgia;

                if(gt == true)
                {
                    SuaNhanVien.gioitinh = 1;
                }
                else
                {
                    SuaNhanVien.gioitinh = 0;
                }
                SuaNhanVien snv = new SuaNhanVien();
                snv.ShowDialog();
                DisplayNhanVien();
            }
        }

        //Quản lý phòng
        private void btnQLPhong_Click(object sender, EventArgs e)
        {
            panelNhanVien.Hide();
            panelKhachHang.Hide();
            panelTrangChu.Hide();
            panelDatPhong.Hide();
            panelTienIch.Hide();
            panelLoaiTienNghi.Hide();
            panelHoaDon.Hide();
            panelTaiKhoan.Hide();
            panelLoaiDichVu.Hide();
            panelThongTinPhong.Hide();
            panelPhong.Show();
            panelLoaiPhong.Hide();
            panelDichVu.Hide();
            sideBarMenu = true;
            sideBar = true;
            timemenuadmin.Start();
            timersidebar.Start();
            DisplayPhong();
        }
        private void btnTimKiemPhong_Click(object sender, EventArgs e)
        {
            var ttp = from tt in quanLyKhachSan.DonDeps
                      join p in quanLyKhachSan.Phongs
                      on tt.MaDonDep equals p.MaDonDep
                      join lp in quanLyKhachSan.LoaiPhongs
                      on p.MaLoaiPhong equals lp.MaLoaiPhong
                      join trt in quanLyKhachSan.TrangThais
                      on p.MaTrangThai equals trt.MaTrangThai
                      where p.MaPhong == txtTenPhong.text
                      select new
                      {
                          p.MaPhong,
                          p.MaDonDep,
                          lp.MaLoaiPhong,
                          tt.TenDonDep,
                          lp.TenLoaiPhong,
                          trt.TenTrangThai
                      };
            DataPhong.DataSource = ttp.ToList();
            DataPhong.Columns[2].HeaderText = "Phòng";
            DataPhong.Columns[3].HeaderText = "Mã tình trạng";
            DataPhong.Columns[4].HeaderText = "Mã loại phòng";
            DataPhong.Columns[5].HeaderText = "Tình trạng";
            DataPhong.Columns[6].HeaderText = "Loại phòng";
            DataPhong.Columns[7].HeaderText = "Trạng thái";
        }
        private void DisplayPhong()
        {
            var ttp = from tt in quanLyKhachSan.DonDeps
                      join p in quanLyKhachSan.Phongs
                      on tt.MaDonDep equals p.MaDonDep
                      join lp in quanLyKhachSan.LoaiPhongs
                      on p.MaLoaiPhong equals lp.MaLoaiPhong
                      join trt in quanLyKhachSan.TrangThais
                      on p.MaTrangThai equals trt.MaTrangThai
                      select new
                      {
                          p.MaPhong,
                          p.MaDonDep,
                          lp.MaLoaiPhong,
                          tt.TenDonDep,
                          lp.TenLoaiPhong,
                          trt.TenTrangThai
                      };
            DataPhong.DataSource = ttp.ToList();
            DataPhong.Columns[2].HeaderText = "Phòng";
            DataPhong.Columns[3].HeaderText = "Mã tình trạng";
            DataPhong.Columns[4].HeaderText = "Mã loại phòng";
            DataPhong.Columns[5].HeaderText = "Tình trạng";
            DataPhong.Columns[6].HeaderText = "Loại phòng";
            DataPhong.Columns[7].HeaderText = "Trạng thái";
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            ThemPhong themPhong = new ThemPhong();
            themPhong.ShowDialog();
            DisplayPhong();
        }

        private void DataPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataPhong.Columns[e.ColumnIndex].Name == "XoaPhong")
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Chắc chắn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No) return;
                int n = DataPhong.CurrentRow.Index;
                string id = DataPhong.Rows[n].Cells[2].Value.ToString();
                var p = from item in quanLyKhachSan.Phongs
                        where item.MaPhong == id
                        select item;
                Phong xp = p.First();
                quanLyKhachSan.Phongs.Remove(xp);
                quanLyKhachSan.SaveChanges();
                DisplayPhong();
            }
            if(DataPhong.Columns[e.ColumnIndex].Name == "Suap")
            {
                int n = DataPhong.CurrentRow.Index;
                string id = DataPhong.Rows[n].Cells[2].Value.ToString();
                int tinhtrang = Convert.ToInt16(DataPhong.Rows[n].Cells[3].Value.ToString());
                int loaiphong = Convert.ToInt16(DataPhong.Rows[n].Cells[4].Value.ToString());

                SuaPhong.id = id;
                SuaPhong.tinhtrang = tinhtrang;
                SuaPhong.loaiphong = loaiphong;

                SuaPhong sp = new SuaPhong();
                sp.ShowDialog();
                DisplayPhong();
            }
        }

        //Quản lý loại phòng
        private void btnQLLoaiPhong_Click(object sender, EventArgs e)
        {
            panelLoaiPhong.Show();
            panelNhanVien.Hide();
            panelLoaiDichVu.Hide();
            panelKhachHang.Hide();
            panelDatPhong.Hide();
            panelHoaDon.Hide();
            panelThongTinPhong.Hide();
            panelTaiKhoan.Hide();
            panelTienIch.Hide();
            panelTrangChu.Hide();
            panelLoaiTienNghi.Hide();
            panelPhong.Hide();
            panelDichVu.Hide();
            sideBarMenu = true;
            sideBar = true;
            timemenuadmin.Start();
            timersidebar.Start();
            DisplayLoaiPhong();
        }
        public void DisplayLoaiPhong()
        {
            var lp = from item in quanLyKhachSan.LoaiPhongs
                     select new
                     {
                         item.MaLoaiPhong,
                         item.TenLoaiPhong,
                         item.SoGiuong,
                         item.GiaNgay,
                         item.GiaGio
                     };
            DataLoaiPhong.DataSource = lp.ToList();
            DataLoaiPhong.Columns[2].HeaderText = "Mã loại phòng";
            DataLoaiPhong.Columns[3].HeaderText = "Tên loại phòng";
            DataLoaiPhong.Columns[4].HeaderText = "Số giường";
            DataLoaiPhong.Columns[5].HeaderText = "Giá ngày";
            DataLoaiPhong.Columns[6].HeaderText = "Giá giờ";
        }
        private void btnThemloaiphong_Click(object sender, EventArgs e)
        {
            ThemLoaiPhong themLoaiPhong = new ThemLoaiPhong();
            themLoaiPhong.ShowDialog();
            DisplayLoaiPhong();
        }

        private void btnTimKiemLoaiPhong_Click(object sender, EventArgs e)
        {
            var lp = from item in quanLyKhachSan.LoaiPhongs
                     where item.TenLoaiPhong.Contains(txtTenLoaiPhong.text)
                     select new
                     {
                         item.MaLoaiPhong,
                         item.TenLoaiPhong,
                         item.SoGiuong,
                         item.GiaNgay,
                         item.GiaGio
                     };
            DataLoaiPhong.DataSource = lp.ToList();
            DataLoaiPhong.Columns[2].HeaderText = "Mã loại phòng";
            DataLoaiPhong.Columns[3].HeaderText = "Tên loại phòng";
            DataLoaiPhong.Columns[4].HeaderText = "Số giường";
            DataLoaiPhong.Columns[5].HeaderText = "Giá ngày";
            DataLoaiPhong.Columns[6].HeaderText = "Giá giờ";
        }

        private void DataLoaiPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataLoaiPhong.Columns[e.ColumnIndex].Name == "xoalp")
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Chắc chắn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No) return;
                int n = DataLoaiPhong.CurrentRow.Index;
                int id = Convert.ToInt16(DataLoaiPhong.Rows[n].Cells[2].Value.ToString());
                var xlp = from item in quanLyKhachSan.LoaiPhongs
                          where item.MaLoaiPhong == id
                          select item;
                LoaiPhong x = xlp.First();
                quanLyKhachSan.LoaiPhongs.Remove(x);
                quanLyKhachSan.SaveChanges();
                DisplayLoaiPhong();
            }
            if(DataLoaiPhong.Columns[e.ColumnIndex].Name == "sualp")
            {
                int n = DataLoaiPhong.CurrentRow.Index;
                int id = Convert.ToInt16(DataLoaiPhong.Rows[n].Cells[2].Value.ToString());
                string tenlp = DataLoaiPhong.Rows[n].Cells[3].Value.ToString();
                int sogiuong = Convert.ToInt16(DataLoaiPhong.Rows[n].Cells[4].Value.ToString());
                string giangay = DataLoaiPhong.Rows[n].Cells[5].Value.ToString();
                string giagio = DataLoaiPhong.Rows[n].Cells[6].Value.ToString();

                SuaLoaiPhong.id = id;
                SuaLoaiPhong.tenlp = tenlp;
                SuaLoaiPhong.sogiuong = sogiuong;
                SuaLoaiPhong.giangay = giangay;
                SuaLoaiPhong.giagio = giagio;

                SuaLoaiPhong suaLoaiPhong = new SuaLoaiPhong();
                suaLoaiPhong.ShowDialog();
                DisplayLoaiPhong();
            }
        }

        // Quản lý dịch vụ
        private void btnQLDichVu_Click(object sender, EventArgs e)
        {
            panelDichVu.Show();
            panelLoaiDichVu.Hide();
            panelLoaiPhong.Hide();
            panelTaiKhoan.Hide();
            panelLoaiTienNghi.Hide();
            panelThongTinPhong.Hide();
            panelHoaDon.Hide();
            panelTienIch.Hide();
            panelDatPhong.Hide();
            panelNhanVien.Hide();
            panelKhachHang.Hide();
            panelTrangChu.Hide();
            panelPhong.Hide();
            sideBarMenu = true;
            sideBar = true;
            timemenuadmin.Start();
            timersidebar.Start();
            DisplayDichVu();
        }
        public void DisplayDichVu()
        {
            var dv = from item in quanLyKhachSan.DichVus
                     join loai in quanLyKhachSan.LoaiDichVus
                     on item.MaLoaiDichVu equals loai.MaLoaiDichVu
                     select new
                     {
                         item.MaDichVu,
                         item.MaLoaiDichVu,
                         item.TenDichVu,
                         loai.TenLoaiDichVu,
                         item.Gia
                     };
            DataDichVu.DataSource = dv.ToList();
            DataDichVu.Columns[2].HeaderText = "Mã dịch vụ";
            DataDichVu.Columns[3].HeaderText = "Mã loại dịch vụ";
            DataDichVu.Columns[4].HeaderText = "Tên dịch vụ";
            DataDichVu.Columns[5].HeaderText = "Tên loại dịch vụ";
            DataDichVu.Columns[6].HeaderText = "Giá";
        }
        private void btnTimKiemDichVu_Click(object sender, EventArgs e)
        {
            var dv = from item in quanLyKhachSan.DichVus
                     join loai in quanLyKhachSan.LoaiDichVus
                     on item.MaLoaiDichVu equals loai.MaLoaiDichVu
                     where item.TenDichVu.Contains(txtTenDichVu.text.Trim())
                     select new
                     {
                         item.MaDichVu,
                         item.MaLoaiDichVu,
                         item.TenDichVu,
                         loai.TenLoaiDichVu,
                         item.Gia
                     };
            DataDichVu.DataSource = dv.ToList();
            DataDichVu.Columns[2].HeaderText = "Mã dịch vụ";
            DataDichVu.Columns[3].HeaderText = "Mã loại dịch vụ";
            DataDichVu.Columns[4].HeaderText = "Tên dịch vụ";
            DataDichVu.Columns[5].HeaderText = "Tên loại dịch vụ";
            DataDichVu.Columns[6].HeaderText = "Giá";
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            ThemDichVu themDichVu = new ThemDichVu();
            themDichVu.ShowDialog();
            DisplayDichVu();
        }

        private void DataDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DataDichVu.Columns[e.ColumnIndex].Name == "xoadv")
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Chắc chắn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No) return;
                int n = DataDichVu.CurrentRow.Index;
                int id = Convert.ToInt16(DataDichVu.Rows[n].Cells[2].Value.ToString());
                var dv = from item in quanLyKhachSan.DichVus
                         where item.MaDichVu == id
                         select item;
                DichVu xdv = dv.First();
                quanLyKhachSan.DichVus.Remove(xdv);
                quanLyKhachSan.SaveChanges();
                DisplayDichVu();
            }
            if(DataDichVu.Columns[e.ColumnIndex].Name == "suadv")
            {
                int n = DataDichVu.CurrentRow.Index;
                int id = Convert.ToInt16(DataDichVu.Rows[n].Cells[2].Value.ToString());
                string tendv = DataDichVu.Rows[n].Cells[4].Value.ToString();
                int loaidv = Convert.ToInt16(DataDichVu.Rows[n].Cells[3].Value.ToString());
                string gia = DataDichVu.Rows[n].Cells[6].Value.ToString();

                SuaDichVu.id = id;
                SuaDichVu.tendv = tendv;
                SuaDichVu.loaidv = loaidv;
                SuaDichVu.gia = gia;

                SuaDichVu suaDichVu = new SuaDichVu();
                suaDichVu.ShowDialog();
                DisplayDichVu();
            }
        }


        // Quản lý loại dịch vụ
        private void btnQLLoaiDichVu_Click(object sender, EventArgs e)
        {
            panelLoaiDichVu.Show();
            panelTienIch.Hide();
            panelDichVu.Hide();
            panelLoaiTienNghi.Hide();
            panelThongTinPhong.Hide();
            panelLoaiPhong.Hide();
            panelHoaDon.Hide();
            panelTaiKhoan.Hide();
            panelDatPhong.Hide();
            panelNhanVien.Hide();
            panelKhachHang.Hide();
            panelTrangChu.Hide();
            panelPhong.Hide();
            sideBarMenu = true;
            sideBar = true;
            timemenuadmin.Start();
            timersidebar.Start();
            DisplayLoaiDichVu();
        }
        private void btnThemLoaiDichVu_Click(object sender, EventArgs e)
        {
            ThemLoaiDichVu themLoaiDichVu = new ThemLoaiDichVu();
            themLoaiDichVu.ShowDialog();
            DisplayLoaiDichVu();
        }

        private void btnTimKiemLoaiDichVu_Click(object sender, EventArgs e)
        {
            var ldv = from item in quanLyKhachSan.LoaiDichVus
                      where item.TenLoaiDichVu == txtTenLoaiDichVu.text
                      select new
                      {
                          item.MaLoaiDichVu,
                          item.TenLoaiDichVu
                      };
            DataLoaiDichVu.DataSource = ldv.ToList();
            DataLoaiDichVu.Columns[2].HeaderText = "Mã loại dịch vụ";
            DataLoaiDichVu.Columns[3].HeaderText = "Tên loại dịch vụ";
        }
        public void DisplayLoaiDichVu()
        {
            var ldv = from item in quanLyKhachSan.LoaiDichVus
                      select new
                      {
                          item.MaLoaiDichVu,
                          item.TenLoaiDichVu
                      };
            DataLoaiDichVu.DataSource = ldv.ToList();
            DataLoaiDichVu.Columns[2].HeaderText = "Mã loại dịch vụ";
            DataLoaiDichVu.Columns[3].HeaderText = "Tên loại dịch vụ";
        }
        private void DataLoaiDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataLoaiDichVu.Columns[e.ColumnIndex].Name == "xoaldv")
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Chắc chắn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No) return;
                int n = DataLoaiDichVu.CurrentRow.Index;
                int id = Convert.ToInt16(DataLoaiDichVu.Rows[n].Cells[2].Value.ToString());

                var ldv = from item in quanLyKhachSan.LoaiDichVus
                          where item.MaLoaiDichVu == id
                          select item;

                LoaiDichVu xoaldv = ldv.First();
                quanLyKhachSan.LoaiDichVus.Remove(xoaldv);
                quanLyKhachSan.SaveChanges();
                DisplayLoaiDichVu();
            }
            if (DataLoaiDichVu.Columns[e.ColumnIndex].Name == "sualdv")
            {
                int n = DataLoaiDichVu.CurrentRow.Index;
                int id = Convert.ToInt16(DataLoaiDichVu.Rows[n].Cells[2].Value.ToString());
                string tenldv = DataLoaiDichVu.Rows[n].Cells[3].Value.ToString();

                SuaLoaiDichVu.id = id;
                SuaLoaiDichVu.tenldv = tenldv;
                SuaLoaiDichVu suaLoaiDichVu = new SuaLoaiDichVu();
                suaLoaiDichVu.ShowDialog();
                DisplayLoaiDichVu();
            }
        }
        // Quản lý tiện ích
        private void btnQLTienIch_Click(object sender, EventArgs e)
        {
            panelTienIch.Show();
            panelLoaiTienNghi.Hide();
            panelLoaiDichVu.Hide();
            panelDichVu.Hide();
            panelThongTinPhong.Hide();
            panelLoaiPhong.Hide();
            panelTaiKhoan.Hide();
            panelDatPhong.Hide();
            panelHoaDon.Hide();
            panelNhanVien.Hide();
            panelKhachHang.Hide();
            panelTrangChu.Hide();
            panelPhong.Hide();
            sideBarMenu = true;
            sideBar = true;
            timemenuadmin.Start();
            timersidebar.Start();
            DisplayTiennghi();
        }
        private void btnThemTienIch_Click(object sender, EventArgs e)
        {
            ThemTienNghi themTienNghi = new ThemTienNghi();
            themTienNghi.ShowDialog();
            DisplayTiennghi();
        }

        private void btnTimKiemTienIch_Click(object sender, EventArgs e)
        {
            var tienich = from item in quanLyKhachSan.TienNghis
                          where item.TenTienNghi.Contains(txtTentienIch.text)
                          select new
                          {
                              item.MaTienNghi,
                              item.TenTienNghi
                          };
            DataTienIch.DataSource = tienich.ToList();
            DataTienIch.Columns[2].HeaderText = "Mã tiện nghi";
            DataTienIch.Columns[3].HeaderText = "Tên tiện nghi";
        }

        private void DataTienIch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataTienIch.Columns[e.ColumnIndex].Name == "xoati")
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Chắc chắn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No) return;
                int n = DataTienIch.CurrentRow.Index;
                int id = Convert.ToInt16(DataTienIch.Rows[n].Cells[2].Value.ToString());

                var tiennghi = from item in quanLyKhachSan.TienNghis
                          where item.MaTienNghi == id
                          select item;

                TienNghi xoatiennghi = tiennghi.First();
                quanLyKhachSan.TienNghis.Remove(xoatiennghi);
                quanLyKhachSan.SaveChanges();
                DisplayTiennghi();
            }
            if (DataTienIch.Columns[e.ColumnIndex].Name == "suati")
            {
                int n = DataTienIch.CurrentRow.Index;
                int id = Convert.ToInt16(DataTienIch.Rows[n].Cells[2].Value.ToString());
                string tentiennghi = DataTienIch.Rows[n].Cells[3].Value.ToString();

                SuaTienNghi.id = id;
                SuaTienNghi.tentn = tentiennghi;
                SuaTienNghi suaTienNghi = new SuaTienNghi();
                suaTienNghi.ShowDialog();
                DisplayTiennghi();
            }
        }
        private void DisplayTiennghi()
        {
            var tienich = from item in quanLyKhachSan.TienNghis
                          select new
                          {
                              item.MaTienNghi,
                              item.TenTienNghi
                          };
            DataTienIch.DataSource = tienich.ToList();
            DataTienIch.Columns[2].HeaderText = "Mã tiện nghi";
            DataTienIch.Columns[3].HeaderText = "Tên tiện nghi";

        }
        // Quản lý chi tiết tiện nghi
        private void btnQLLoaiTienich_Click(object sender, EventArgs e)
        {
            panelLoaiTienNghi.Show();
            panelTienIch.Hide();
            panelLoaiDichVu.Hide();
            panelDichVu.Hide();
            panelLoaiPhong.Hide();
            panelDatPhong.Hide();
            panelThongTinPhong.Hide();
            panelHoaDon.Hide();
            panelTaiKhoan.Hide();
            panelNhanVien.Hide();
            panelKhachHang.Hide();
            panelTrangChu.Hide();
            panelPhong.Hide();
            sideBarMenu = true;
            sideBar = true;
            timemenuadmin.Start();
            timersidebar.Start();
            DisplayLoaiTienNghi();
        }
        public void DisplayLoaiTienNghi()
        {
            var chitiettienngghi = from item in quanLyKhachSan.ChiTietTienNghis
                                join p in quanLyKhachSan.Phongs
                                on item.MaPhong equals p.MaPhong
                                join tiennghi in quanLyKhachSan.TienNghis
                                on item.MaTienNghi equals tiennghi.MaTienNghi
                                select new { 
                                    item.MaChiTietTienNghi,
                                    item.MaPhong,
                                    item.MaTienNghi,
                                    tiennghi.TenTienNghi,
                                    item.SoLuong
                                };
            DataLoaiTienNghi.DataSource = chitiettienngghi.ToList();
            DataLoaiTienNghi.Columns[2].HeaderText = "Mã chi tiết sản phẩm";
            DataLoaiTienNghi.Columns[3].HeaderText = "Mã phòng";
            DataLoaiTienNghi.Columns[4].HeaderText = "Mã tiện nghi";
            DataLoaiTienNghi.Columns[5].HeaderText = "Tên tiện nghi";
            DataLoaiTienNghi.Columns[6].HeaderText = "Số lượng";
        }
        private void btnThemLoaiTienNghi_Click(object sender, EventArgs e)
        {
            ThemChiTietTienNghi cttn = new ThemChiTietTienNghi();
            cttn.ShowDialog();
            DisplayLoaiTienNghi();
        }

        private void btnTimKiemLoaiTienNghi_Click(object sender, EventArgs e)
        {
            var chitiettienngghi = from item in quanLyKhachSan.ChiTietTienNghis
                                   join p in quanLyKhachSan.Phongs
                                   on item.MaPhong equals p.MaPhong
                                   join tiennghi in quanLyKhachSan.TienNghis
                                   on item.MaTienNghi equals tiennghi.MaTienNghi
                                   where item.MaPhong.Contains(txtTenLoaitienNghi.text)
                                   select new
                                   {
                                       item.MaChiTietTienNghi,
                                       item.MaPhong,
                                       item.MaTienNghi,
                                       tiennghi.TenTienNghi,
                                       item.SoLuong
                                   };
            DataLoaiTienNghi.DataSource = chitiettienngghi.ToList();
            DataLoaiTienNghi.Columns[2].HeaderText = "Mã chi tiết sản phẩm";
            DataLoaiTienNghi.Columns[3].HeaderText = "Mã phòng";
            DataLoaiTienNghi.Columns[4].HeaderText = "Mã tiện nghi";
            DataLoaiTienNghi.Columns[5].HeaderText = "Tên tiện nghi";
            DataLoaiTienNghi.Columns[6].HeaderText = "Số lượng";
        }

        private void DataLoaiTienNghi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataLoaiTienNghi.Columns[e.ColumnIndex].Name == "xoaltn")
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Chắc chắn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No) return;
                int n = DataLoaiTienNghi.CurrentRow.Index;
                int id = Convert.ToInt16(DataLoaiTienNghi.Rows[n].Cells[2].Value.ToString());

                var cttiennghi = from item in quanLyKhachSan.ChiTietTienNghis
                                 where item.MaChiTietTienNghi == id
                                 select item;
                ChiTietTienNghi chiTietTienNghi = cttiennghi.First();
                quanLyKhachSan.ChiTietTienNghis.Remove(chiTietTienNghi);
                quanLyKhachSan.SaveChanges();
                DisplayLoaiTienNghi();
            }
            if (DataLoaiTienNghi.Columns[e.ColumnIndex].Name == "sualtn")
            {
                int n = DataLoaiTienNghi.CurrentRow.Index;
                int id = Convert.ToInt16(DataLoaiTienNghi.Rows[n].Cells[2].Value.ToString());

                string phong = DataLoaiTienNghi.Rows[n].Cells[3].Value.ToString();
                int matiennghi = Convert.ToInt16(DataLoaiTienNghi.Rows[n].Cells[4].Value.ToString());
                string soluong = DataLoaiTienNghi.Rows[n].Cells[6].Value.ToString();

                SuaChiTietTienNghi.id = id;
                SuaChiTietTienNghi.phong = phong;
                SuaChiTietTienNghi.tn = matiennghi;
                SuaChiTietTienNghi.soluong = soluong;
                SuaChiTietTienNghi suaTienNghi = new SuaChiTietTienNghi();
                suaTienNghi.ShowDialog();
                DisplayLoaiTienNghi();
            }
        }
        // Quản lý tài khoản
        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            panelTaiKhoan.Show();
            panelLoaiTienNghi.Hide();
            panelTienIch.Hide();
            panelLoaiDichVu.Hide();
            panelThongTinPhong.Hide();
            panelDatPhong.Hide();
            panelHoaDon.Hide();
            panelDichVu.Hide();
            panelLoaiPhong.Hide();
            panelNhanVien.Hide();
            panelKhachHang.Hide();
            panelTrangChu.Hide();
            panelPhong.Hide();
            sideBarMenu = true;
            sideBar = true;
            timemenuadmin.Start();
            timersidebar.Start();
            DisplayTaiKhoan();
        }
        public void DisplayTaiKhoan()
        {
            var tk = from t in quanLyKhachSan.TaiKhoans
                     join nv in quanLyKhachSan.NhanViens
                     on t.MaNhanVien equals nv.MaNhanVien
                     select new
                     {
                         t.MaTaiKhoan,
                         t.MaNhanVien,
                         nv.TenNhanVien,
                         t.TenTaiKhoan,
                         t.MatKhau,
                         t.CapDo
                     };
            DataTaiKhoan.DataSource = tk.ToList();
            DataTaiKhoan.Columns[2].HeaderText = "Mã tài khoản";
            DataTaiKhoan.Columns[3].HeaderText = "Mã nhân viên";
            DataTaiKhoan.Columns[4].HeaderText = "Tên nhân viên";
            DataTaiKhoan.Columns[5].HeaderText = "Tên tài khoản";
            DataTaiKhoan.Columns[6].HeaderText = "Cấp tài khoản";
        }
        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan themTaiKhoan = new ThemTaiKhoan();
            themTaiKhoan.ShowDialog();
            DisplayTaiKhoan();
        }

        private void btnTimKiemTaiKhoan_Click(object sender, EventArgs e)
        {
            var tk = from t in quanLyKhachSan.TaiKhoans
                     join nv in quanLyKhachSan.NhanViens
                     on t.MaNhanVien equals nv.MaNhanVien
                     where nv.TenNhanVien.Contains(txtTenTKNhanVien.text)
                     select new
                     {
                         t.MaTaiKhoan,
                         t.MaNhanVien,
                         nv.TenNhanVien,
                         t.TenTaiKhoan,
                         t.CapDo
                     };
            DataTaiKhoan.DataSource = tk.ToList();
            DataTaiKhoan.DataSource = tk.ToList();
            DataTaiKhoan.Columns[2].HeaderText = "Mã tài khoản";
            DataTaiKhoan.Columns[3].HeaderText = "Mã nhân viên";
            DataTaiKhoan.Columns[4].HeaderText = "Tên nhân viên";
            DataTaiKhoan.Columns[5].HeaderText = "Tên tài khoản";
            DataTaiKhoan.Columns[6].HeaderText = "Cấp tài khoản";
        }

        private void DataTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataTaiKhoan.Columns[e.ColumnIndex].Name == "xoatk")
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No) return;
                int n = DataTaiKhoan.CurrentRow.Index;
                int id = Convert.ToInt16(DataTaiKhoan.Rows[n].Cells[2].Value.ToString());
                var tk = from item in quanLyKhachSan.TaiKhoans
                         where item.MaTaiKhoan == id
                         select item;

                TaiKhoan xoatk = tk.First();
                quanLyKhachSan.TaiKhoans.Remove(xoatk);
                quanLyKhachSan.SaveChanges();
                DisplayTaiKhoan();
            }
            if(DataTaiKhoan.Columns[e.ColumnIndex].Name == "suatk")
            {
                int n = DataTaiKhoan.CurrentRow.Index;
                int id = Convert.ToInt16(DataTaiKhoan.Rows[n].Cells[2].Value.ToString());
                string tennv = DataTaiKhoan.Rows[n].Cells[4].Value.ToString();
                string tentk = DataTaiKhoan.Rows[n].Cells[5].Value.ToString();
                string mk = DataTaiKhoan.Rows[n].Cells[6].Value.ToString();
                string capdo = DataTaiKhoan.Rows[n].Cells[7].Value.ToString();

                SuaTaiKhoan.id = id;
                SuaTaiKhoan.tennv = tennv;
                SuaTaiKhoan.tentk = tentk;
                SuaTaiKhoan.mk = mk;
                SuaTaiKhoan.capdo = capdo;

                SuaTaiKhoan suaTaiKhoan = new SuaTaiKhoan();
                suaTaiKhoan.ShowDialog();
                DisplayTaiKhoan();
            }
        }
        // Đặt phòng

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            panelDatPhong.Show();
            panelTaiKhoan.Hide();
            panelLoaiTienNghi.Hide();
            panelThongTinPhong.Hide();
            panelTienIch.Hide();
            panelLoaiDichVu.Hide();
            panelDichVu.Hide();
            panelLoaiPhong.Hide();
            panelNhanVien.Hide();
            panelHoaDon.Hide();
            panelKhachHang.Hide();
            panelTrangChu.Hide();
            panelPhong.Hide();
            sideBarMenu = true;
            sideBar = true;
            timemenuadmin.Start();
            timersidebar.Start();
            DisplayDatPhong();
        }
        public void DisplayDatPhong()
        {
            var dp = from item in quanLyKhachSan.DatPhongs
                     join nv in quanLyKhachSan.NhanViens
                     on item.MaNhanVien equals nv.MaNhanVien
                     join kh in quanLyKhachSan.KhachHangs
                     on item.MaKhachHang equals kh.MaKhachHang
                     select new
                     {
                         item.MaDatPhong,
                         item.MaPhong,
                         kh.TenKhachHang,
                         item.NgayThue,
                         nv.TenNhanVien
                     };

            DataDatPhong.DataSource = dp.ToList();
            DataDatPhong.Columns[2].HeaderText = "Mã đặt phòng";
            DataDatPhong.Columns[3].HeaderText = "Số phòng";
            DataDatPhong.Columns[4].HeaderText = "Tên khách hàng";
            DataDatPhong.Columns[5].HeaderText = "Ngày thuê";
            DataDatPhong.Columns[6].HeaderText = "Tên nhân viên";
        }

        private void btnTimKiemTheoTenKhachHang_Click(object sender, EventArgs e)
        {
            var dp = from item in quanLyKhachSan.DatPhongs
                     join nv in quanLyKhachSan.NhanViens
                     on item.MaNhanVien equals nv.MaNhanVien
                     join kh in quanLyKhachSan.KhachHangs
                     on item.MaKhachHang equals kh.MaKhachHang
                     where kh.TenKhachHang.Contains(txtTenKhachHangDatPhong.text)
                     select new
                     {
                         item.MaDatPhong,
                         item.MaPhong,
                         kh.TenKhachHang,
                         item.NgayThue,
                         nv.TenNhanVien
                     };
            DataDatPhong.DataSource = dp.ToList();
            DataDatPhong.Columns[2].HeaderText = "Mã đặt phòng";
            DataDatPhong.Columns[3].HeaderText = "Số phòng";
            DataDatPhong.Columns[4].HeaderText = "Tên khách hàng";
            DataDatPhong.Columns[5].HeaderText = "Ngày thuê";
            DataDatPhong.Columns[6].HeaderText = "Tên nhân viên";
        }

        private void DataDatPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DataDatPhong.Columns[e.ColumnIndex].Name == "xoadp")
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No) return;

                int n = DataDatPhong.CurrentRow.Index;
                int id = Convert.ToInt16(DataDatPhong.Rows[n].Cells[2].Value.ToString());

                var dp = from item in quanLyKhachSan.DatPhongs
                         where item.MaDatPhong == id
                         select item;

                DatPhong xoadp = dp.First();
                quanLyKhachSan.DatPhongs.Remove(xoadp);
                quanLyKhachSan.SaveChanges();
                DisplayDatPhong();
            }
            if (DataDatPhong.Columns[e.ColumnIndex].Name == "chitietdp")
            {
                int n = DataDatPhong.CurrentRow.Index;
                int id = Convert.ToInt16(DataDatPhong.Rows[n].Cells[2].Value.ToString());

                ChiTietDatPhong.id = id;

                ChiTietDatPhong chiTietDatPhong = new ChiTietDatPhong();
                chiTietDatPhong.ShowDialog();
            }
        }
        private void btnThemDatPhong_Click(object sender, EventArgs e)
        {
            ThemDatPhong themDatPhong = new ThemDatPhong();
            themDatPhong.ShowDialog();
            DisplayDatPhong();
        }

        // Hóa đơn
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            panelHoaDon.Show();
            panelDatPhong.Hide();
            panelTaiKhoan.Hide();
            panelLoaiTienNghi.Hide();
            panelTienIch.Hide();
            panelLoaiDichVu.Hide();
            panelDichVu.Hide();
            panelThongTinPhong.Hide();
            panelLoaiPhong.Hide();
            panelNhanVien.Hide();
            panelKhachHang.Hide();
            panelTrangChu.Hide();
            panelPhong.Hide();
            sideBarMenu = true;
            sideBar = true;
            timemenuadmin.Start();
            timersidebar.Start();
            DisplayHoaDon();
        }
        public void DisplayHoaDon()
        {
            var hd = from item in quanLyKhachSan.HoaDons
                     join tk in quanLyKhachSan.TaiKhoans
                     on item.MaTaiKhoan equals tk.MaTaiKhoan
                     join nv in quanLyKhachSan.NhanViens
                     on tk.MaNhanVien equals nv.MaNhanVien
                     join cthd in quanLyKhachSan.ChiTietHoaDons
                     on item.MaHoaDon equals cthd.MaHoaDon
                     join dp in quanLyKhachSan.DatPhongs
                     on cthd.MaDatPhong equals dp.MaDatPhong
                     join kh in quanLyKhachSan.KhachHangs
                     on dp.MaKhachHang equals kh.MaKhachHang
                     join p in quanLyKhachSan.Phongs
                     on dp.MaPhong equals p.MaPhong
                     join lp in quanLyKhachSan.LoaiPhongs
                     on p.MaLoaiPhong equals lp.MaLoaiPhong
                     select new
                     {
                         item.MaHoaDon,
                         item.NgayLap,
                         p.MaPhong,
                         kh.TenKhachHang,
                         cthd.TongTien,
                         nv.TenNhanVien,
                         dp.NgayThue,
                         dp.NgayTra,
                         lp.TenLoaiPhong,
                         lp.GiaNgay
                     };
            DataHoaDon.DataSource = hd.ToList();
            DataHoaDon.Columns[1].HeaderText = "Mã hóa đơn";
            DataHoaDon.Columns[2].HeaderText = "Ngày lập";
            DataHoaDon.Columns[3].HeaderText = "Số phòng";
            DataHoaDon.Columns[4].HeaderText = "Tên khách hàng";
            DataHoaDon.Columns[5].HeaderText = "Tổng tiền";
            DataHoaDon.Columns[6].HeaderText = "Tên nhân viên lập";
            DataHoaDon.Columns[7].HeaderText = "Ngày thuê";
            DataHoaDon.Columns[8].HeaderText = "Ngày trả";
            DataHoaDon.Columns[9].HeaderText = "Loại phòng";
            DataHoaDon.Columns[10].HeaderText = "Giá ngày";
        }

        private void btnTimKiemHoaDonTheoTenKhachHang_Click(object sender, EventArgs e)
        {
            var hd = from item in quanLyKhachSan.HoaDons
                     join tk in quanLyKhachSan.TaiKhoans
                     on item.MaTaiKhoan equals tk.MaTaiKhoan
                     join nv in quanLyKhachSan.NhanViens
                     on tk.MaNhanVien equals nv.MaNhanVien
                     join cthd in quanLyKhachSan.ChiTietHoaDons
                     on item.MaHoaDon equals cthd.MaHoaDon
                     join dp in quanLyKhachSan.DatPhongs
                     on cthd.MaDatPhong equals dp.MaDatPhong
                     join kh in quanLyKhachSan.KhachHangs
                     on dp.MaKhachHang equals kh.MaKhachHang
                     join p in quanLyKhachSan.Phongs
                     on dp.MaPhong equals p.MaPhong
                     join lp in quanLyKhachSan.LoaiPhongs
                     on p.MaLoaiPhong equals lp.MaLoaiPhong
                     where kh.TenKhachHang.Contains(txtHoaDonTenKhachHang.text)
                     select new
                     {
                         item.MaHoaDon,
                         item.NgayLap,
                         p.MaPhong,
                         kh.TenKhachHang,
                         cthd.TongTien,
                         nv.TenNhanVien,
                         dp.NgayThue,
                         dp.NgayTra,
                         lp.TenLoaiPhong,
                         lp.GiaNgay
                     };
            DataHoaDon.DataSource = hd.ToList();
            DataHoaDon.Columns[1].HeaderText = "Mã hóa đơn";
            DataHoaDon.Columns[2].HeaderText = "Ngày lập";
            DataHoaDon.Columns[3].HeaderText = "Số phòng";
            DataHoaDon.Columns[4].HeaderText = "Tên khách hàng";
            DataHoaDon.Columns[5].HeaderText = "Tổng tiền";
            DataHoaDon.Columns[6].HeaderText = "Tên nhân viên lập";
            DataHoaDon.Columns[7].HeaderText = "Ngày thuê";
            DataHoaDon.Columns[8].HeaderText = "Ngày trả";
            DataHoaDon.Columns[9].HeaderText = "Loại phòng";
            DataHoaDon.Columns[10].HeaderText = "Giá ngày";
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
        }

        private void DataHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DataHoaDon.Columns[e.ColumnIndex].Name == "chitiethd")
            {
                int n = DataHoaDon.CurrentRow.Index;
                int id = Convert.ToInt16(DataHoaDon.Rows[n].Cells[1].Value.ToString());
                string ngaylap = DataHoaDon.Rows[n].Cells[2].Value.ToString();
                string maphong = DataHoaDon.Rows[n].Cells[3].Value.ToString();
                string tenkh = DataHoaDon.Rows[n].Cells[4].Value.ToString();
                string tongtien = DataHoaDon.Rows[n].Cells[5].Value.ToString();
                string tennv = DataHoaDon.Rows[n].Cells[6].Value.ToString();
                string ngaythue = DataHoaDon.Rows[n].Cells[7].Value.ToString();
                string ngaytra = DataHoaDon.Rows[n].Cells[8].Value.ToString();
                string loaiphong = DataHoaDon.Rows[n].Cells[9].Value.ToString();
                string giangay = DataHoaDon.Rows[n].Cells[10].Value.ToString();

                ChiTieuPhieuHoaDon.id = id;
                ChiTieuPhieuHoaDon.ngayld = ngaylap;
                ChiTieuPhieuHoaDon.sophong = maphong;
                ChiTieuPhieuHoaDon.tenkh = tenkh;
                ChiTieuPhieuHoaDon.tennv = tennv;
                ChiTieuPhieuHoaDon.ngaythue = Convert.ToDateTime(ngaythue);
                ChiTieuPhieuHoaDon.ngaytra = Convert.ToDateTime(ngaytra);
                ChiTieuPhieuHoaDon.loaiphong = loaiphong;
                ChiTieuPhieuHoaDon.giaphong = giangay;

                ChiTieuPhieuHoaDon chi = new ChiTieuPhieuHoaDon();
                chi.ShowDialog();
            }
        }
        // Phòng
        private void btnPhong_Click(object sender, EventArgs e)
        {
            panelThongTinPhong.Show();
            panelHoaDon.Hide();
            panelDatPhong.Hide();
            panelTaiKhoan.Hide();
            panelLoaiTienNghi.Hide();
            panelTienIch.Hide();
            panelLoaiDichVu.Hide();
            panelDichVu.Hide();
            panelLoaiPhong.Hide();
            panelNhanVien.Hide();
            panelKhachHang.Hide();
            panelTrangChu.Hide();
            panelPhong.Hide();
            sideBarMenu = true;
            sideBar = true;
            timemenuadmin.Start();
            timersidebar.Start();

            var tt = from item in quanLyKhachSan.TrangThais
                     select item;
            cbTrangThai.DataSource = tt.ToList();
            cbTrangThai.DisplayMember = "TenTrangThai";
            cbTrangThai.ValueMember = "MaTrangThai";

            var lp = from item in quanLyKhachSan.LoaiPhongs
                     select item;
            cbLoaiPhong.DataSource = lp.ToList();
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbLoaiPhong.ValueMember = "MaLoaiPhong";

            var tinhtrang = from item in quanLyKhachSan.DonDeps
                     select item;
            cbTinhTrang.DataSource = tinhtrang.ToList();
            cbTinhTrang.DisplayMember = "TenDonDep";
            cbTinhTrang.ValueMember = "MaDonDep";

            DisplayThongTinPhong();
        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ttp = from item in quanLyKhachSan.Phongs
                      join lp in quanLyKhachSan.LoaiPhongs
                      on item.MaLoaiPhong equals lp.MaLoaiPhong
                      join tt in quanLyKhachSan.TrangThais
                      on item.MaTrangThai equals tt.MaTrangThai
                      join dd in quanLyKhachSan.DonDeps
                      on item.MaDonDep equals dd.MaDonDep
                      where tt.TenTrangThai.Contains(cbTrangThai.Text)
                      select new
                      {
                          item.MaPhong,
                          lp.TenLoaiPhong,
                          tt.TenTrangThai,
                          dd.TenDonDep
                      };
            DataThongTinPhong.DataSource = ttp.ToList();
            DataThongTinPhong.Columns[1].HeaderText = "Số phòng";
            DataThongTinPhong.Columns[2].HeaderText = "Loại phòng";
            DataThongTinPhong.Columns[3].HeaderText = "Trạng thái";
            DataThongTinPhong.Columns[4].HeaderText = "Tình trạng";
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ttp = from item in quanLyKhachSan.Phongs
                      join lp in quanLyKhachSan.LoaiPhongs
                      on item.MaLoaiPhong equals lp.MaLoaiPhong
                      join tt in quanLyKhachSan.TrangThais
                      on item.MaTrangThai equals tt.MaTrangThai
                      join dd in quanLyKhachSan.DonDeps
                      on item.MaDonDep equals dd.MaDonDep
                      where lp.TenLoaiPhong.Contains(cbLoaiPhong.Text)
                      select new
                      {
                          item.MaPhong,
                          lp.TenLoaiPhong,
                          tt.TenTrangThai,
                          dd.TenDonDep
                      };
            DataThongTinPhong.DataSource = ttp.ToList();
            DataThongTinPhong.Columns[1].HeaderText = "Số phòng";
            DataThongTinPhong.Columns[2].HeaderText = "Loại phòng";
            DataThongTinPhong.Columns[3].HeaderText = "Trạng thái";
            DataThongTinPhong.Columns[4].HeaderText = "Tình trạng";
        }

        private void cbTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ttp = from item in quanLyKhachSan.Phongs
                      join lp in quanLyKhachSan.LoaiPhongs
                      on item.MaLoaiPhong equals lp.MaLoaiPhong
                      join tt in quanLyKhachSan.TrangThais
                      on item.MaTrangThai equals tt.MaTrangThai
                      join dd in quanLyKhachSan.DonDeps
                      on item.MaDonDep equals dd.MaDonDep
                      where dd.TenDonDep.Contains(cbTinhTrang.Text)
                      select new
                      {
                          item.MaPhong,
                          lp.TenLoaiPhong,
                          tt.TenTrangThai,
                          dd.TenDonDep
                      };
            DataThongTinPhong.DataSource = ttp.ToList();
            DataThongTinPhong.Columns[1].HeaderText = "Số phòng";
            DataThongTinPhong.Columns[2].HeaderText = "Loại phòng";
            DataThongTinPhong.Columns[3].HeaderText = "Trạng thái";
            DataThongTinPhong.Columns[4].HeaderText = "Tình trạng";
        }
        public void DisplayThongTinPhong()
        {
            var ttp = from item in quanLyKhachSan.Phongs
                      join lp in quanLyKhachSan.LoaiPhongs
                      on item.MaLoaiPhong equals lp.MaLoaiPhong
                      join tt in quanLyKhachSan.TrangThais
                      on item.MaTrangThai equals tt.MaTrangThai
                      join dd in quanLyKhachSan.DonDeps
                      on item.MaDonDep equals dd.MaDonDep
                      select new
                      {
                          item.MaPhong,
                          lp.TenLoaiPhong,
                          tt.TenTrangThai,
                          dd.TenDonDep
                      };
            DataThongTinPhong.DataSource = ttp.ToList();
            DataThongTinPhong.Columns[1].HeaderText = "Số phòng";
            DataThongTinPhong.Columns[2].HeaderText = "Loại phòng";
            DataThongTinPhong.Columns[3].HeaderText = "Trạng thái";
            DataThongTinPhong.Columns[4].HeaderText = "Tình trạng";
        }

        private void DataThongTinPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataThongTinPhong.Columns[e.ColumnIndex].Name == "ThongTin")
            {
                int n = DataThongTinPhong.CurrentRow.Index;
                string id = DataThongTinPhong.Rows[n].Cells[1].Value.ToString();
                string trangthai = DataThongTinPhong.Rows[n].Cells[3].Value.ToString();
                if (trangthai.Trim() == "Phòng trống")
                {
                    ThemDatPhong them = new ThemDatPhong();
                    them.ShowDialog();
                    DisplayThongTinPhong();
                }else
                {
                    var dp = from item in quanLyKhachSan.DatPhongs
                             join kh in quanLyKhachSan.KhachHangs
                             on item.MaKhachHang equals kh.MaKhachHang
                             where item.MaPhong == id
                             select new
                             {
                                 kh.TenKhachHang,
                                 item.NgayThue,
                                 item.NgayTra
                             };
                    dataLayThongTin.DataSource = dp.ToList();

                    string tenkh = dataLayThongTin.Rows[0].Cells[0].Value.ToString();
                    string ngaythue = dataLayThongTin.Rows[0].Cells[1].Value.ToString();
                    string ngaytra = dataLayThongTin.Rows[0].Cells[2].Value.ToString();

                    DatDichVu.sophong = id;
                    DatDichVu.tenkh = tenkh;
                    DatDichVu.ngaythue = ngaythue; 
                    DatDichVu.ngaytra = ngaytra;

                    DatDichVu dat = new DatDichVu();
                    dat.ShowDialog();
                    DisplayThongTinPhong();
                }
            }
        }

        private void Dangxuat_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            Close();
            lg.ShowDialog();
        }
    }
}
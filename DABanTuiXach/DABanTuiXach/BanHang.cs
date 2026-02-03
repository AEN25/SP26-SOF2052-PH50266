using DABanTuiXach.DAL;
using DABanTuiXach.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DABanTuiXach
{
	public partial class BanHang : Form
	{
		private HoaDonDAO hoaDonDangBan = null;

		public BanHang()
		{
			InitializeComponent();
		}

		private void btnTaoHoaDon_Click(object sender, EventArgs e)
		{
			hoaDonDangBan = new HoaDonDAO
			{
				NgayLapHoaDon = DateTime.Now,
				TrangThai = false,
				ChiTietList = new List<HoaDonChiTiet>()
			};

			dtgvHoaDon.DataSource = null;
			lblTongTien.Text = "0";
			lblTienThua.Text = "0";
			txtTienKhachDua.Clear();

			MessageBox.Show("Đã tạo hóa đơn mới, sẵn sàng bán hàng!");
		}

		private void dtgvSanPhamChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			if (hoaDonDangBan == null)
			{
				MessageBox.Show("Vui lòng tạo hóa đơn trước");
				return;
			}

			int maSPCT = Convert.ToInt32(
				dtgvSanPhamChiTiet.Rows[e.RowIndex].Cells["MaSanPhamChiTiet"].Value);

			decimal gia = Convert.ToDecimal(
				dtgvSanPhamChiTiet.Rows[e.RowIndex].Cells["DonGia"].Value);

			var ct = hoaDonDangBan.ChiTietList
				.FirstOrDefault(x => x.MaSanPhamChiTiet == maSPCT);

			if (ct == null)
			{
				hoaDonDangBan.ChiTietList.Add(new HoaDonChiTiet
				{
					MaSanPhamChiTiet = maSPCT,
					SoLuong = 1,
					DonGia = gia,
					TrangThai = true
				});
			}
			else
			{
				ct.SoLuong++;
			}

			HienThiHoaDonDangBan();
		}
		private void HienThiHoaDonDangBan()
		{
			if (hoaDonDangBan == null) return;

			dtgvHoaDon.DataSource = null;
			dtgvHoaDon.AutoGenerateColumns = true;
			dtgvHoaDon.DataSource = hoaDonDangBan.ChiTietList.ToList();

			decimal tongTien = hoaDonDangBan.ChiTietList
				.Sum(x => x.SoLuong * x.DonGia);

			hoaDonDangBan.TongTien = tongTien;
			lblTongTien.Text = tongTien.ToString("N0");
		}
		private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
		{
			if (decimal.TryParse(txtTienKhachDua.Text, out decimal tienKhachDua))
			{
				decimal tienThua = tienKhachDua - hoaDonDangBan.TongTien;
				lblTienThua.Text = tienThua.ToString("N0");
			}
		}
		private void btnThanhToan_Click(object sender, EventArgs e)
		{
			if (hoaDonDangBan == null || hoaDonDangBan.ChiTietList.Count == 0)
			{
				MessageBox.Show("Hóa đơn chưa có sản phẩm");
				return;
			}

			hoaDonDangBan.SoDienThoai = txtSoDienThoai.Text;
			hoaDonDangBan.PhuongThucThanhToan = "Tiền mặt";
			hoaDonDangBan.TrangThai = true;
			hoaDonDangBan.MaNhanVien = 1; // demo

			HoaDonDAL.InsertHoaDon(hoaDonDangBan);

			MessageBox.Show("Thanh toán thành công!");

			hoaDonDangBan = null;
			dtgvHoaDon.DataSource = null;
			lblTongTien.Text = "0";
			lblTienThua.Text = "0";
		}
		private void btnHuy_Click(object sender, EventArgs e)
		{
			hoaDonDangBan = null;
			dtgvHoaDon.DataSource = null;
			lblTongTien.Text = "0";
			lblTienThua.Text = "0";
		}

	}
}

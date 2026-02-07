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
		private bool _dangLoadComboHoaDon = false;

		public BanHang()
		{
			InitializeComponent();
			Load += BanHang_Load;
			txtTienKhachDua.TextChanged += txtTienKhachDua_TextChanged_1;
			txtSoDienThoai.TextChanged += txtSoDienThoai_TextChanged;
		}
		private void BanHang_Load(object sender, EventArgs e)
		{
			LoadSanPhamChiTiet();
			ResetHoaDon();
		}
		private void LoadSanPhamChiTiet()
		{
			dtgvSanPhamChiTiet.DataSource = SanPhamChiTietDAL.SelectAll();

			dtgvSanPhamChiTiet.Columns["maSanPhamChiTiet"].HeaderText = "Mã SPCT";
			dtgvSanPhamChiTiet.Columns["tenSanPham"].HeaderText = "Sản phẩm";
			dtgvSanPhamChiTiet.Columns["tenMau"].HeaderText = "Màu";
			dtgvSanPhamChiTiet.Columns["giaSanPham"].HeaderText = "Giá";
			dtgvSanPhamChiTiet.Columns["soLuong"].HeaderText = "Tồn";

			dtgvSanPhamChiTiet.Columns["giaSanPham"]
				.DefaultCellStyle.Format = "N0";

			// Ẩn cột không cần bán
			dtgvSanPhamChiTiet.Columns["maSanPham"].Visible = false;
			dtgvSanPhamChiTiet.Columns["maMauSac"].Visible = false;
			dtgvSanPhamChiTiet.Columns["trangThai"].Visible = false;
		}


		private void btnTaoHoaDon_Click(object sender, EventArgs e)
		{
			if (!ValidateTaoHoaDon()) return;

			hoaDonDangBan = new HoaDonDAO
			{
				TenKhachHang = txtTenKH.Text.Trim(),
				SoDienThoai = txtSoDienThoai.Text.Trim(),
				NgayLapHoaDon = DateTime.Now,
				PhuongThucThanhToan = "Tiền mặt",
				TrangThai = false,
				MaNhanVien = Session.MaNhanVien,
				MaKhachHang = null 
			};


			int maHD = HoaDonDAL.InsertHoaDonCho(hoaDonDangBan);
			hoaDonDangBan.MaHoaDon = maHD;

			_dangLoadComboHoaDon = true;

			// Nếu combo chưa có DataSource thì dùng Items
			if (cbbChonHoaDon.DataSource == null)
			{
				if (!cbbChonHoaDon.Items.Contains(maHD))
					cbbChonHoaDon.Items.Add(maHD);
			}
			else
			{
				// Trường hợp combo đang dùng DataSource
				LoadComboHoaDon();
			}

			cbbChonHoaDon.SelectedItem = maHD;

			_dangLoadComboHoaDon = false;


			dtgvHoaDon.DataSource = null;
			lblTongTien.Text = "0";
			lblTienThua.Text = "0";
			txtTienKhachDua.Clear();

			MessageBox.Show($"Đã tạo hóa đơn #{maHD}");
		}


		private void HienThiHoaDonDangBan()
		{
			dtgvHoaDon.DataSource = null;
			dtgvHoaDon.DataSource = hoaDonDangBan.ChiTietList
				.Select(x => new
				{
					x.MaSanPhamChiTiet,
					x.TenSanPham,
					x.SoLuong,
					DonGia = x.Gia,
					ThanhTien = x.SoLuong * x.Gia
				})
				.ToList();

			int tong = hoaDonDangBan.ChiTietList
				.Sum(x => x.SoLuong * x.Gia);

			hoaDonDangBan.TongTien = tong;
			lblTongTien.Text = tong.ToString("N0");
		}

		private void btnThanhToan_Click(object sender, EventArgs e)
		{

		}
		private void btnHuy_Click(object sender, EventArgs e)
		{

		}
		private void ResetHoaDon()
		{
			hoaDonDangBan = null;
			dtgvHoaDon.DataSource = null;
			lblTongTien.Text = "0";
			lblTienThua.Text = "0";
			txtTienKhachDua.Clear();
		}
		private bool ValidateThanhToan()
		{
			if (hoaDonDangBan == null)
			{
				MessageBox.Show("Chưa có hóa đơn");
				return false;
			}

			if (hoaDonDangBan.ChiTietList.Count == 0)
			{
				MessageBox.Show("Hóa đơn chưa có sản phẩm");
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtTenKH.Text))
			{
				MessageBox.Show("Vui lòng nhập tên khách hàng");
				txtTenKH.Focus();
				return false;
			}

			if (!decimal.TryParse(txtTienKhachDua.Text, out decimal tienKhachDua))
			{
				MessageBox.Show("Tiền khách đưa không hợp lệ");
				txtTienKhachDua.Focus();
				return false;
			}

			if (tienKhachDua < hoaDonDangBan.TongTien)
			{
				MessageBox.Show("Tiền khách đưa không đủ");
				txtTienKhachDua.Focus();
				return false;
			}

			return true;
		}
		private bool ValidateTaoHoaDon()
		{
			if (string.IsNullOrWhiteSpace(txtTenKH.Text))
			{
				MessageBox.Show("Vui lòng nhập tên khách hàng");
				txtTenKH.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
			{
				MessageBox.Show("Vui lòng nhập số điện thoại");
				txtSoDienThoai.Focus();
				return false;
			}

			if (!System.Text.RegularExpressions.Regex.IsMatch(
				txtSoDienThoai.Text.Trim(), @"^0\d{9}$"))
			{
				MessageBox.Show("Số điện thoại không hợp lệ (phải đủ 10 số)");
				txtSoDienThoai.Focus();
				return false;
			}

			return true;
		}
		private void LoadComboHoaDon()
		{
			_dangLoadComboHoaDon = true;

			cbbChonHoaDon.DataSource = HoaDonDAL.SelectHoaDonCho();
			cbbChonHoaDon.DisplayMember = "maHoaDon";
			cbbChonHoaDon.ValueMember = "maHoaDon";

			_dangLoadComboHoaDon = false;
		}
		private void cbbChonHoaDon_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_dangLoadComboHoaDon) return;
			if (cbbChonHoaDon.SelectedValue == null) return;

			if (!int.TryParse(cbbChonHoaDon.SelectedValue.ToString(), out int maHD))
				return;

			hoaDonDangBan = HoaDonDAL.SelectHoaDonById(maHD);
			if (hoaDonDangBan == null) return;

			hoaDonDangBan.ChiTietList =
				HoaDonDAL.SelectHoaDonChiTiet(maHD)
				.AsEnumerable()
				.Select(r => new HoaDonChiTiet
				{
					MaSanPhamChiTiet = r.Field<int>("maSanPhamChiTiet"),
					TenSanPham = r.Field<string>("tenSanPham"),
					SoLuong = r.Field<int>("soLuong"),
					Gia = r.Field<int>("gia"),
					TrangThai = true
				}).ToList();

			HienThiHoaDonDangBan();
		}

		private void btnHuy_Click_1(object sender, EventArgs e)
		{
			if (hoaDonDangBan == null)
			{
				ResetHoaDon();
				return;
			}

			var confirm = MessageBox.Show(
				$"Bạn có chắc muốn hủy hóa đơn #{hoaDonDangBan.MaHoaDon}?",
				"Xác nhận hủy",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning
			);

			if (confirm != DialogResult.Yes) return;

			try
			{
				if (!hoaDonDangBan.TrangThai)
				{
					HoaDonDAL.DeleteHoaDonCho(hoaDonDangBan.MaHoaDon);
				}

				LoadComboHoaDon();
				ResetHoaDon();

				MessageBox.Show("Đã hủy hóa đơn");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi hủy hóa đơn:\n" + ex.Message);
			}
		}

		private void btnThanhToan_Click_1(object sender, EventArgs e)
		{
			if (!ValidateThanhToan()) return;

			var confirm = MessageBox.Show(
				$"Xác nhận thanh toán?\n\nTổng tiền: {hoaDonDangBan.TongTien:N0} đ",
				"Xác nhận",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (confirm != DialogResult.Yes) return;

			try
			{
				// Trừ tồn kho
				foreach (var ct in hoaDonDangBan.ChiTietList)
				{
					SanPhamChiTietDAL.TruSoLuong(
						ct.MaSanPhamChiTiet,
						ct.SoLuong
					);
				}

				
				hoaDonDangBan.TrangThai = true;
				HoaDonDAL.UpdateHoaDon(hoaDonDangBan);

				
				_dangLoadComboHoaDon = true;
				LoadComboHoaDon();
				_dangLoadComboHoaDon = false;

				MessageBox.Show("Thanh toán thành công 🎉");

				LoadSanPhamChiTiet();
				ResetHoaDon();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi thanh toán:\n" + ex.Message);
			}
		}

		private void dtgvSanPhamChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			if (hoaDonDangBan == null)
			{
				MessageBox.Show("Vui lòng tạo hóa đơn trước");
				return;
			}

			var row = dtgvSanPhamChiTiet.Rows[e.RowIndex];

			int maSPCT = Convert.ToInt32(row.Cells["maSanPhamChiTiet"].Value);
			string tenSP = row.Cells["tenSanPham"].Value.ToString();
			int gia = Convert.ToInt32(row.Cells["giaSanPham"].Value);
			int tonKho = Convert.ToInt32(row.Cells["soLuong"].Value);

			
			using (FormSoLuong f = new FormSoLuong(tonKho))
			{
				if (f.ShowDialog() != DialogResult.OK) return;

				int soLuongNhap = f.SoLuongNhap;

				var ct = hoaDonDangBan.ChiTietList
					.FirstOrDefault(x => x.MaSanPhamChiTiet == maSPCT);

				if (ct == null)
				{
					hoaDonDangBan.ChiTietList.Add(new HoaDonChiTiet
					{
						MaSanPhamChiTiet = maSPCT,
						TenSanPham = tenSP,
						SoLuong = soLuongNhap,
						Gia = gia,
						TrangThai = true
					});
				}
				else
				{
					if (ct.SoLuong + soLuongNhap > tonKho)
					{
						MessageBox.Show("Số lượng vượt tồn kho");
						return;
					}

					ct.SoLuong += soLuongNhap;
				}

				HienThiHoaDonDangBan();
			}
		}

		private void lblTienThua_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtTienKhachDua_TextChanged_1(object sender, EventArgs e)
		{
			if (hoaDonDangBan == null)
			{
				lblTienThua.Text = "0";
				return;
			}

			if (!int.TryParse(txtTienKhachDua.Text, out int tienKhachDua))
			{
				lblTienThua.Text = "0";
				return;
			}

			int tienThua = tienKhachDua - hoaDonDangBan.TongTien;

			if (tienThua < 0)
				tienThua = 0;

			lblTienThua.Text = tienThua.ToString("N0");
		}

		private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
		{
			string sdt = txtSoDienThoai.Text.Trim();

			
			if (sdt.Length != 10) return;

			var dt = KhachHangDAL.SelectBySoDienThoai(sdt);

			if (dt.Rows.Count > 0)
			{
				
				txtTenKH.Text = dt.Rows[0]["tenKhachHang"].ToString();
				txtTenKH.ReadOnly = true; 

				if (hoaDonDangBan != null)
				{
					hoaDonDangBan.MaKhachHang =
						Convert.ToInt32(dt.Rows[0]["maKhachHang"]);
				}
			}
			else
			{
				
				txtTenKH.Text = "";
				txtTenKH.ReadOnly = false;

				if (hoaDonDangBan != null)
				{
					hoaDonDangBan.MaKhachHang = null;
				}
			}
		}
	}
}

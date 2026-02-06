using DABanTuiXach.DAL;
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
	public partial class HoaDon : Form
	{
		public HoaDon()
		{
			InitializeComponent();
			this.TopLevel = false;
			this.Dock = DockStyle.Fill;
			this.Padding = new Padding(0);
			this.Margin = new Padding(0);
			this.AutoScaleMode = AutoScaleMode.None;
			HoaDon_Load(null, null);
			dgvHoaDon.SelectionChanged += dgvHoaDon_SelectionChanged;

		}

		private void HoaDon_Load(object sender, EventArgs e)
		{
			dtpTuNgay.Value = DateTime.Today;
			dtpDenNgay.Value = DateTime.Today;
			dgvHoaDon.DataSource = HoaDonDAL.SelectTatCaHoaDonDaThanhToan();
		}
		private void LoadHoaDon()
		{
			dgvHoaDon.DataSource = HoaDonDAL.SelectHoaDonDaThanhToan(
			dtpTuNgay.Value.Date,
			dtpDenNgay.Value.Date.AddDays(1),
			txtTimKiem.Text.Trim()
			);

			dgvHoaDon.Columns["maHoaDon"].HeaderText = "Mã HĐ";
			dgvHoaDon.Columns["ngayLapHoaDon"].HeaderText = "Ngày";
			dgvHoaDon.Columns["tenKhachHang"].HeaderText = "Khách hàng";
			dgvHoaDon.Columns["soDienThoai"].HeaderText = "SĐT";
			dgvHoaDon.Columns["tenNhanVien"].HeaderText = "Nhân viên";
			dgvHoaDon.Columns["tongTien"].HeaderText = "Tổng tiền";
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			LoadHoaDon();
		}

		private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvHoaDon.CurrentRow == null) return;
			if (dgvHoaDon.CurrentRow.IsNewRow) return;

			var row = dgvHoaDon.CurrentRow;

			lblMaHD.Text = row.Cells["maHoaDon"].Value?.ToString();

			lblNgay.Text = row.Cells["ngayLapHoaDon"].Value == DBNull.Value
				? ""
				: Convert.ToDateTime(row.Cells["ngayLapHoaDon"].Value).ToString("dd/MM/yyyy");

			lblKhach.Text = row.Cells["tenKhachHang"].Value?.ToString();
			lblNhanVien.Text = row.Cells["tenNhanVien"].Value?.ToString();

			lblTongTien.Text = row.Cells["tongTien"].Value == DBNull.Value
				? "0"
				: Convert.ToDecimal(row.Cells["tongTien"].Value).ToString("N0");


			LoadChiTietHoaDon(Convert.ToInt32(row.Cells["maHoaDon"].Value));
		}
		private void LoadChiTietHoaDon(int maHoaDon)
		{
			dgvChiTietHoaDon.DataSource = HoaDonDAL.SelectHoaDonChiTiet(maHoaDon);

			dgvChiTietHoaDon.Columns["tenSanPham"].HeaderText = "Sản phẩm";
			dgvChiTietHoaDon.Columns["soLuong"].HeaderText = "SL";
			dgvChiTietHoaDon.Columns["gia"].HeaderText = "Giá";
		}

	}
}

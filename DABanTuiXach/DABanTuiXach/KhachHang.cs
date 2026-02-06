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
	public partial class KhachHang : Form
	{
		

		public KhachHang()
		{
			InitializeComponent();
			KhachHang_Load(null, null);
			ClearForm();
			this.TopLevel = false;
			this.Dock = DockStyle.Fill;
			this.Padding = new Padding(0);
			this.Margin = new Padding(0);
			this.AutoScaleMode = AutoScaleMode.None;
		}
		private void KhachHang_Load(object sender, EventArgs e)
		{
			

			data_viewKH.DataSource = KhachHangDAL.SelectAll();
			data_viewKH.ClearSelection();

			data_viewKH.SelectionChanged -= data_viewKH_SelectionChanged;
			data_viewKH.SelectionChanged += data_viewKH_SelectionChanged;

			ClearForm();

			
		}

		private bool ValidateKhachHang()
		{
			if (string.IsNullOrWhiteSpace(tb_tenKH.Text))
			{
				MessageBox.Show("Tên khách hàng không được để trống");
				return false;
			}

			if (cbb_gioitinhKhachHang.SelectedIndex == -1)
			{
				MessageBox.Show("Vui lòng chọn giới tính");
				return false;
			}

			if (!string.IsNullOrWhiteSpace(tb_sdt.Text) && tb_sdt.Text.Length < 9)
			{
				MessageBox.Show("Số điện thoại không hợp lệ");
				return false;
			}

			return true;
		}

		private void bt_them_Click(object sender, EventArgs e)
		{
			if (!ValidateKhachHang()) return;

			try
			{
				KhachHangDAL.Insert(new KhachHangDAO
				{
					TenKhachHang = tb_tenKH.Text.Trim(),
					GioiTinh = cbb_gioitinhKhachHang.Text == "Nam",
					SoDienThoai = tb_sdt.Text.Trim(),
					Email = tb_email.Text.Trim(),
					DiaChi = tb_diachi.Text.Trim(),
					TrangThai = rb_conhoatdong.Checked
				});

				MessageBox.Show("Thêm khách hàng thành công!");
				data_viewKH.DataSource = KhachHangDAL.SelectAll();
				ClearForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi thêm khách hàng: " + ex.Message);
			}
		}

		private void tb_timkiem_TextChanged(object sender, EventArgs e)
		{
			data_viewKH.DataSource = KhachHangDAL.Search(tb_timkiem.Text.Trim());
		}


		private void bt_sua_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tb_makhachhang.Text))
			{
				MessageBox.Show("Vui lòng chọn khách hàng cần sửa");
				return;
			}

			if (!ValidateKhachHang()) return;

			try
			{
				KhachHangDAL.Update(new KhachHangDAO
				{
					MaKhachHang = int.Parse(tb_makhachhang.Text),
					TenKhachHang = tb_tenKH.Text.Trim(),
					GioiTinh = cbb_gioitinhKhachHang.Text == "Nam",
					SoDienThoai = tb_sdt.Text.Trim(),
					Email = tb_email.Text.Trim(),
					DiaChi = tb_diachi.Text.Trim(),
					TrangThai = rb_conhoatdong.Checked
				});

				MessageBox.Show("Cập nhật thành công!");
				data_viewKH.DataSource = KhachHangDAL.SelectAll();
				ClearForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi cập nhật: " + ex.Message);
			}
		}

		private void bt_reset_Click(object sender, EventArgs e)
		{
			

			ClearForm();
			data_viewKH.ClearSelection();

			
		}
		private void ClearForm()
		{
			tb_makhachhang.Clear();
			tb_tenKH.Clear();
			tb_sdt.Clear();
			tb_email.Clear();
			tb_diachi.Clear();

			cbb_gioitinhKhachHang.SelectedIndex = -1;

			rb_conhoatdong.Checked = true;   // luôn có trạng thái
			rb_ngunghoatdong.Checked = false;
		}

		private void data_viewKH_SelectionChanged(object sender, EventArgs e)
		{
			
			if (data_viewKH.CurrentRow == null) return;
			if (data_viewKH.CurrentRow.IsNewRow) return;

			var row = data_viewKH.CurrentRow;

			tb_makhachhang.Text = row.Cells["maKhachHang"].Value?.ToString();
			tb_tenKH.Text = row.Cells["tenKhachHang"].Value?.ToString();
			tb_sdt.Text = row.Cells["soDienThoai"]?.Value?.ToString() ?? "";
			tb_email.Text = row.Cells["email"]?.Value?.ToString() ?? "";
			tb_diachi.Text = row.Cells["diaChi"]?.Value?.ToString() ?? "";

			if (row.Cells["gioiTinh"].Value != DBNull.Value)
			{
				cbb_gioitinhKhachHang.SelectedItem =
					Convert.ToBoolean(row.Cells["gioiTinh"].Value) ? "Nam" : "Nữ";
			}
			else
			{
				cbb_gioitinhKhachHang.SelectedIndex = -1;
			}

			if (row.Cells["trangThai"].Value != DBNull.Value)
			{
				bool tt = Convert.ToBoolean(row.Cells["trangThai"].Value);
				rb_conhoatdong.Checked = tt;
				rb_ngunghoatdong.Checked = !tt;
			}
		}
	}
}

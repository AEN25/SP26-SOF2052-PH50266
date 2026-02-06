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
	public partial class SanPham : Form
	{
		public SanPham()
		{
			InitializeComponent();
			SanPham_Load(null, null);
			LoadSanPhamChiTiet();
			this.TopLevel = false;
			this.Dock = DockStyle.Fill;
			this.Padding = new Padding(0);
			this.Margin = new Padding(0);
			this.AutoScaleMode = AutoScaleMode.None;
		}

		private void SanPham_Load(object sender, EventArgs e)
		{
			dgvSanPham.DataSource = DAL.SanPhamDAL.SelectAll();
			dgvSanPhamChiTiet.SelectionChanged += dgvSanPhamChiTiet_SelectionChanged;

			dgvSanPham.ClearSelection();
			ClearForm();
			//LoadSanPham();
			LoadComboSanPham();
			LoadComboMauSac();
			LoadSanPhamChiTiet();

		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			DAO.SanPhamDAO sp = new DAO.SanPhamDAO
			{
				TenSanPham = txtTenSanPham.Text,
				Size = txtSize.Text,
				ChatLieu = txtChatLieu.Text,
				KieuDang = txtKieuDang.Text
			};
			DAL.SanPhamDAL.TaoMoi(sp);
			dgvSanPham.DataSource = DAL.SanPhamDAL.SelectAll();
		}

		private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvSanPham.CurrentRow == null) return;
			if (dgvSanPham.CurrentRow.IsNewRow) return;
			if (!dgvSanPham.Focused) return;

			DataGridViewRow row = dgvSanPham.CurrentRow;

			txtMaSanPham.Text = row.Cells["maSanPham"].Value?.ToString();
			txtTenSanPham.Text = row.Cells["tenSanPham"].Value?.ToString();
			txtSize.Text = row.Cells["size"].Value?.ToString();
			txtChatLieu.Text = row.Cells["chatLieu"].Value?.ToString();
			txtKieuDang.Text = row.Cells["kieuDang"].Value?.ToString();
		}

		private void btnThem_Click_1(object sender, EventArgs e)
		{
			SanPhamDAL.TaoMoi(new SanPhamDAO()
			{
				TenSanPham = txtTenSanPham.Text,
				Size = txtSize.Text,
				ChatLieu = txtChatLieu.Text,
				KieuDang = txtKieuDang.Text
			});

			dgvSanPham.DataSource = SanPhamDAL.SelectAll();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtMaSanPham.Text = "";
			txtTenSanPham.Text = "";
			txtSize.Text = "";
			txtChatLieu.Text = "";
			txtKieuDang.Text = "";
		}
		private void ClearForm()
		{
			txtMaSanPham.Text = "";
			txtTenSanPham.Text = "";
			txtSize.Text = "";
			txtChatLieu.Text = "";
			txtKieuDang.Text = "";
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			SanPhamDAL.CapNhat(new SanPhamDAO()
			{
				MaSanPham = int.Parse(txtMaSanPham.Text),
				TenSanPham = txtTenSanPham.Text,
				Size = txtSize.Text,
				ChatLieu = txtChatLieu.Text,
				KieuDang = txtKieuDang.Text
			});

			dgvSanPham.DataSource = SanPhamDAL.SelectAll();
		}
		private void LoadComboSanPham()
		{
			DataTable dt = SanPhamDAL.SelectAll();

			cbbMaSanPham.DataSource = dt;
			cbbMaSanPham.DisplayMember = "maSanPham";
			cbbMaSanPham.ValueMember = "maSanPham";

			cbbMaSanPham.SelectedIndex = -1;
			cbbMaSanPham.SelectedIndexChanged -= cbbMaSanPham_SelectedIndexChanged;
			cbbMaSanPham.SelectedIndexChanged += cbbMaSanPham_SelectedIndexChanged;
		}

		private void LoadComboMauSac()
		{
			cbbMauSac.DataSource = MauSacDAL.SelectAll();
			cbbMauSac.DisplayMember = "tenMau";
			cbbMauSac.ValueMember = "maMauSac";
		}

		private void LoadSanPhamChiTiet()
		{
			dgvSanPhamChiTiet.DataSource = SanPhamChiTietDAL.SelectAll();

			dgvSanPhamChiTiet.Columns["maSanPhamChiTiet"].HeaderText = "Mã SPCT";
			dgvSanPhamChiTiet.Columns["maSanPham"].HeaderText = "Mã Sản Phẩm";
			dgvSanPhamChiTiet.Columns["maMauSac"].HeaderText = "Mã Màu Sắc";
			dgvSanPhamChiTiet.Columns["tenSanPhamChiTiet"].HeaderText = "Tên SPCT";
			dgvSanPhamChiTiet.Columns["tenSanPham"].HeaderText = "Sản phẩm";
			dgvSanPhamChiTiet.Columns["tenMau"].HeaderText = "Màu";
			dgvSanPhamChiTiet.Columns["giaSanPham"].HeaderText = "Giá";
			dgvSanPhamChiTiet.Columns["soLuong"].HeaderText = "Tồn kho";
			dgvSanPhamChiTiet.Columns["trangThai"].HeaderText = "Trạng Thái";

		}
		private bool ValidateSanPhamChiTiet()
		{
			if (string.IsNullOrWhiteSpace(txtTenSanPhamChiTiet.Text))
			{
				MessageBox.Show("Tên sản phẩm chi tiết không được để trống");
				return false;
			}

			if (!int.TryParse(txtGiaSanPham.Text, out int gia) || gia <= 0)
			{
				MessageBox.Show("Giá sản phẩm phải là số > 0");
				return false;
			}

			if (!int.TryParse(txtSoLuong.Text, out int sl) || sl < 0)
			{
				MessageBox.Show("Số lượng phải là số >= 0");
				return false;
			}

			if (cbbMaSanPham.SelectedIndex == -1)
			{
				MessageBox.Show("Vui lòng chọn sản phẩm");
				return false;
			}

			if (cbbMauSac.SelectedIndex == -1)
			{
				MessageBox.Show("Vui lòng chọn màu sắc");
				return false;
			}

			return true;
		}
		private void btnThemSanPhamChiTiet_Click(object sender, EventArgs e)
		{

		}
		private void btnSuaSanPhamChiTiet_Click(object sender, EventArgs e)
		{

		}
		//private void dgvSanPhamChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
		//{
		//	if (e.RowIndex < 0) return;

		//	var row = dgvSanPhamChiTiet.Rows[e.RowIndex];

		//	txtMaSanPhamChiTiet.Text = row.Cells["maSanPhamChiTiet"].Value.ToString();
		//	txtTenSanPhamChiTiet.Text = row.Cells["tenSanPhamChiTiet"].Value.ToString();
		//	txtGiaSanPham.Text = row.Cells["giaSanPham"].Value.ToString();
		//	txtSoLuong.Text = row.Cells["soLuong"].Value.ToString();

		//	bool trangThai = Convert.ToBoolean(row.Cells["trangThai"].Value);
		//	rdbtConHang.Checked = trangThai;
		//	rdbtHetHang.Checked = !trangThai;

		//	cbbMaSanPham.SelectedValue = row.Cells["maSanPham"].Value;
		//	cbbMauSac.SelectedValue = row.Cells["maMauSac"].Value;
		//}
		private void dgvSanPhamChiTiet_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvSanPhamChiTiet.CurrentRow == null) return;
			if (dgvSanPhamChiTiet.CurrentRow.IsNewRow) return;

			var row = dgvSanPhamChiTiet.CurrentRow;

			txtMaSanPhamChiTiet.Text = row.Cells["maSanPhamChiTiet"].Value?.ToString();
			txtTenSanPhamChiTiet.Text = row.Cells["tenSanPhamChiTiet"].Value?.ToString();

			txtGiaSanPham.Text = row.Cells["giaSanPham"].Value == DBNull.Value
				? "0"
				: row.Cells["giaSanPham"].Value.ToString();

			txtSoLuong.Text = row.Cells["soLuong"].Value == DBNull.Value
				? "0"
				: row.Cells["soLuong"].Value.ToString();


			if (row.Cells["maSanPham"].Value != DBNull.Value)
				cbbMaSanPham.SelectedValue = row.Cells["maSanPham"].Value;

			if (row.Cells["maMauSac"].Value != DBNull.Value)
				cbbMauSac.SelectedValue = row.Cells["maMauSac"].Value;


			if (row.Cells["trangThai"].Value != DBNull.Value)
			{
				bool trangThai = Convert.ToBoolean(row.Cells["trangThai"].Value);
				rdbtConHang.Checked = trangThai;
				rdbtHetHang.Checked = !trangThai;
			}
		}
		private void cbbMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbbMaSanPham.SelectedIndex < 0) return;

			if (cbbMaSanPham.SelectedItem is DataRowView row)
			{
				txtTenSanPhamCuaChitTiet.Text = row["tenSanPham"].ToString();
			}
		}

		private void ClearChiTietFields()
		{
			txtMaSanPhamChiTiet.Clear();
			txtTenSanPhamChiTiet.Clear();
			txtGiaSanPham.Clear();
			txtSoLuong.Clear();
			rdbtConHang.Checked = true;
			cbbMaSanPham.SelectedIndex = -1;
			cbbMauSac.SelectedIndex = -1;
		}

		private void btnSuaSanPhamChiTiet_Click_1(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMaSanPhamChiTiet.Text))
			{
				MessageBox.Show("Vui lòng chọn sản phẩm chi tiết cần sửa");
				return;
			}

			if (!ValidateSanPhamChiTiet()) return;

			try
			{
				SanPhamChiTietDAL.Update(new SanPhamChiTiet
				{
					MaSanPhamChiTiet = int.Parse(txtMaSanPhamChiTiet.Text),
					TenSanPhamChiTiet = txtTenSanPhamChiTiet.Text.Trim(),
					GiaSanPham = int.Parse(txtGiaSanPham.Text),
					SoLuong = int.Parse(txtSoLuong.Text),
					TrangThai = rdbtConHang.Checked,
					MaSanPham = (int)cbbMaSanPham.SelectedValue,
					MaMauSac = (int)cbbMauSac.SelectedValue
				});

				MessageBox.Show("Cập nhật thành công!");
				LoadSanPhamChiTiet();
				ClearChiTietFields();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi cập nhật: " + ex.Message);
			}
		}

		private void btnThemSanPhamChiTiet_Click_1(object sender, EventArgs e)
		{
			if (!ValidateSanPhamChiTiet()) return;

			try
			{
				SanPhamChiTietDAL.Insert(new SanPhamChiTiet
				{
					TenSanPhamChiTiet = txtTenSanPhamChiTiet.Text.Trim(),
					GiaSanPham = int.Parse(txtGiaSanPham.Text),
					SoLuong = int.Parse(txtSoLuong.Text),
					TrangThai = rdbtConHang.Checked,
					MaSanPham = (int)cbbMaSanPham.SelectedValue,
					MaMauSac = (int)cbbMauSac.SelectedValue
				});

				MessageBox.Show("Thêm sản phẩm chi tiết thành công!");
				LoadSanPhamChiTiet();
				ClearChiTietFields();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi thêm SPCT: " + ex.Message);
			}
		}

		private void txtCRUDMauSac_Click(object sender, EventArgs e)
		{
			
			using (var frm = new MauSac())
			{
				frm.ShowDialog();
			}

			
			LoadComboMauSac();
		}
	}
}

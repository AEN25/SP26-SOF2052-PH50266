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
	public partial class NhanVien : Form
	{
		public NhanVien()
		{
			InitializeComponent();
			NhanVien_Load(null, null);
		}
		private void NhanVien_Load(object sender, EventArgs e)
		{
			// Load dữ liệu nhân viên vào DataGridView
			dataGridView1.DataSource = DAL.NhanVienDAL.SelectAll();
			dataGridView1.ClearSelection();
			cbGt.Items.Add("Nam");
			cbGt.Items.Add("Nữ");
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtTennv.Text) ||
				string.IsNullOrWhiteSpace(txtTk.Text) ||
				string.IsNullOrWhiteSpace(txtMk.Text) ||
				cbGt.SelectedIndex == -1)
			{
				MessageBox.Show(
					"Vui lòng nhập đầy đủ thông tin bắt buộc!",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

			bool gioiTinh = cbGt.SelectedItem.ToString() == "Nam";

			bool trangThai = rbLam.Checked;
			NhanVienDAO nv = new NhanVienDAO()
			{
				TenNhanVien = txtTennv.Text.Trim(),
				SoDienThoai = txtSdt.Text.Trim(),
				GioiTinh = gioiTinh,
				Email = txtEmail.Text.Trim(),
				DiaChi = txtDiachi.Text.Trim(),
				TaiKhoan = txtTk.Text.Trim(),
				MatKhau = txtMk.Text.Trim(),
				TrangThai = trangThai
			};

			try
			{
				NhanVienDAL.TaoMoi(nv);

				dataGridView1.DataSource = NhanVienDAL.SelectAll();
				dataGridView1.ClearSelection();
				ResetForm();

				MessageBox.Show(
					"Thêm nhân viên thành công!",
					"Thành công",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					"Lỗi khi thêm nhân viên:\n" + ex.Message,
					"Lỗi",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

			txtmaNv.Text = row.Cells["maNhanVien"].Value.ToString();
			txtTennv.Text = row.Cells["tenNhanVien"].Value.ToString();
			txtSdt.Text = row.Cells["soDienThoai"].Value.ToString();
			txtEmail.Text = row.Cells["email"].Value.ToString();
			txtDiachi.Text = row.Cells["diaChi"].Value.ToString();
			txtTk.Text = row.Cells["taikhoan"].Value.ToString();
			txtMk.Text = row.Cells["matkhau"].Value.ToString();

			bool gioiTinh = Convert.ToBoolean(row.Cells["gioiTinh"].Value);

			if (gioiTinh)
			{
				cbGt.SelectedItem = "Nam";
			}
			else
			{
				cbGt.SelectedItem = "Nữ";
			}

			if (row.Cells["trangThai"].Value == DBNull.Value)
			{
				rbLam.Checked = false;
				rbNghilam.Checked = false;
			}
			else
			{
				bool trangThai = Convert.ToBoolean(row.Cells["trangThai"].Value);
				rbLam.Checked = trangThai;
				rbNghilam.Checked = !trangThai;
			}

		}

		private void ResetForm()
		{
			txtmaNv.Clear();
			txtTennv.Clear();
			txtSdt.Clear();
			txtEmail.Clear();
			txtDiachi.Clear();
			txtTk.Clear();
			txtMk.Clear();

			cbGt.SelectedIndex = -1;
			rbLam.Checked = true;
			rbNghilam.Checked = false;
		}

		private void btnLammoi_Click(object sender, EventArgs e)
		{
			txtmaNv.Clear();
			txtTennv.Clear();
			txtSdt.Clear();
			txtEmail.Clear();
			txtDiachi.Clear();
			txtTk.Clear();
			txtMk.Clear();

			cbGt.SelectedIndex = -1;
			rbLam.Checked = true;
			rbNghilam.Checked = false;
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtmaNv.Text))
			{
				MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
				return;
			}

			if (cbGt.SelectedIndex == -1)
			{
				MessageBox.Show("Vui lòng chọn giới tính!");
				return;
			}

			try
			{
				NhanVienDAO nv = new NhanVienDAO()
				{
					MaNhanVien = int.Parse(txtmaNv.Text),
					TenNhanVien = txtTennv.Text.Trim(),
					SoDienThoai = txtSdt.Text.Trim(),
					Email = txtEmail.Text.Trim(),
					DiaChi = txtDiachi.Text.Trim(),
					TaiKhoan = txtTk.Text.Trim(),
					MatKhau = txtMk.Text.Trim(),
					GioiTinh = cbGt.SelectedItem.ToString() == "Nam",
					TrangThai = rbLam.Checked
				};

				NhanVienDAL.CapNhat(nv);

				MessageBox.Show(
					"Cập nhật nhân viên thành công!",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);

				NhanVien_Load(null, null);
				ResetForm();

			}
			catch (Exception ex)
			{
				MessageBox.Show(
					"Lỗi khi sửa nhân viên:\n" + ex.Message,
					"Lỗi",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}
	}
}

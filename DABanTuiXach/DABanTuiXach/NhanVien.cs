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

			dataGridView1.DataSource = DAL.NhanVienDAL.SelectAll();
			dataGridView1.ClearSelection();
			dataGridView1.Columns["maNhanVien"].HeaderText = "Mã NV";
			dataGridView1.Columns["tenNhanVien"].HeaderText = "Tên nhân viên";
			dataGridView1.Columns["soDienThoai"].HeaderText = "SĐT";
			dataGridView1.Columns["email"].HeaderText = "Email";
			dataGridView1.Columns["diaChi"].HeaderText = "Địa chỉ";
			dataGridView1.Columns["gioiTinh"].HeaderText = "Giới tính";
			dataGridView1.Columns["trangThai"].HeaderText = "Trạng thái";
			dataGridView1.Columns["quyen"].HeaderText = "Quyền";


			cbGt.Items.Clear();
			cbGt.Items.Add("Nam");
			cbGt.Items.Add("Nữ");

			cbCv.Items.Clear();
			cbCv.Items.Add("Nhân viên");
			cbCv.Items.Add("Quản lý");


		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtTennv.Text) ||
			   string.IsNullOrWhiteSpace(txtTk.Text) ||
			   string.IsNullOrWhiteSpace(txtMk.Text) ||
			   cbGt.SelectedIndex == -1 ||
			   cbCv.SelectedIndex == -1)
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
				return;
			}

			try
			{
				NhanVienDAO nv = new NhanVienDAO()
				{
					TenNhanVien = txtTennv.Text.Trim(),
					SoDienThoai = txtSdt.Text.Trim(),
					GioiTinh = cbGt.SelectedItem.ToString() == "Nam",
					Email = txtEmail.Text.Trim(),
					DiaChi = txtDiachi.Text.Trim(),
					TaiKhoan = txtTk.Text.Trim(),
					MatKhau = txtMk.Text.Trim(),
					TrangThai = rbLam.Checked,
					Quyen = cbCv.SelectedIndex
				};

				NhanVienDAL.TaoMoi(nv);

				MessageBox.Show("Thêm thành công!");

				NhanVien_Load(null, null);
				ResetForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi thêm:\n" + ex.Message);
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

			txtmaNv.Text = row.Cells["maNhanVien"].Value?.ToString();
			txtTennv.Text = row.Cells["tenNhanVien"].Value?.ToString();
			txtSdt.Text = row.Cells["soDienThoai"].Value?.ToString();
			txtEmail.Text = row.Cells["email"].Value?.ToString();
			txtDiachi.Text = row.Cells["diaChi"].Value?.ToString();
			txtTk.Text = row.Cells["taikhoan"].Value?.ToString();
			txtMk.Text = row.Cells["matkhau"].Value?.ToString();

			if (row.Cells["gioiTinh"].Value != DBNull.Value)
			{
				bool gt = Convert.ToBoolean(row.Cells["gioiTinh"].Value);
				cbGt.SelectedItem = gt ? "Nam" : "Nữ";
			}

			if (row.Cells["trangThai"].Value != DBNull.Value)
			{
				bool tt = Convert.ToBoolean(row.Cells["trangThai"].Value);
				rbLam.Checked = tt;
				rbNghilam.Checked = !tt;
			}

			if (row.Cells["quyen"].Value != DBNull.Value)
			{
				int q = Convert.ToInt32(row.Cells["quyen"].Value);
				cbCv.SelectedIndex = q;
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
			cbCv.SelectedIndex = -1;

			rbLam.Checked = true;
			rbNghilam.Checked = false;
		}

		private void btnLammoi_Click(object sender, EventArgs e)
		{
			ResetForm();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtmaNv.Text))
			{
				MessageBox.Show("Vui lòng chọn nhân viên!");
				return;
			}

			try
			{
				NhanVienDAO nv = new NhanVienDAO()
				{
					MaNhanVien = int.Parse(txtmaNv.Text),
					TenNhanVien = txtTennv.Text.Trim(),
					SoDienThoai = txtSdt.Text.Trim(),
					GioiTinh = cbGt.SelectedItem.ToString() == "Nam",
					Email = txtEmail.Text.Trim(),
					DiaChi = txtDiachi.Text.Trim(),
					TaiKhoan = txtTk.Text.Trim(),
					MatKhau = txtMk.Text.Trim(),
					TrangThai = rbLam.Checked,
					Quyen = cbCv.SelectedIndex
				};

				NhanVienDAL.CapNhat(nv);

				MessageBox.Show("Cập nhật thành công!");

				NhanVien_Load(null, null);
				ResetForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi sửa:\n" + ex.Message);
			}
		}

		
	}
}

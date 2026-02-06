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
	public partial class MauSac : Form
	{
		public MauSac()
		{
			InitializeComponent();
		}

		private void MauSac_Load(object sender, EventArgs e)
		{
			dgvMauSac.DataSource = MauSacDAL.SelectAll();
			dgvMauSac.ClearSelection();
			ClearForm();
		}

		private void dgvMauSac_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvMauSac.CurrentRow == null) return;
			if (dgvMauSac.CurrentRow.IsNewRow) return;

			var row = dgvMauSac.CurrentRow;


			txtMauSac.Text = row.Cells["tenMau"].Value?.ToString();
		}
		//private bool ValidateMauSac()
		//{
		//	if (string.IsNullOrWhiteSpace(txtMauSac.Text))
		//	{
		//		MessageBox.Show("Tên màu không được để trống");
		//		return false;
		//	}
		//	return true;
		//}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMauSac.Text))
			{
				MessageBox.Show("Tên màu không được để trống");
				return;
			}

			DialogResult rs = MessageBox.Show(
				"Bạn có chắc chắn muốn THÊM màu này?",
				"Xác nhận thêm",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (rs != DialogResult.Yes) return;

			try
			{
				MauSacDAL.Insert(new MauSacDAO
				{
					TenMau = txtMauSac.Text.Trim(),

				});

				MessageBox.Show("Thêm màu sắc thành công!");
				dgvMauSac.DataSource = MauSacDAL.SelectAll();
				ClearForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi thêm màu: " + ex.Message);
			}
		}
		private void ClearForm()
		{

			txtMauSac.Clear();
			dgvMauSac.ClearSelection();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMauSac.Text))
			{
				MessageBox.Show("Vui lòng chọn màu cần sửa");
				return;
			}

			DialogResult rs = MessageBox.Show(
				"Bạn có chắc chắn muốn CẬP NHẬT màu này?",
				"Xác nhận sửa",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning
			);

			if (rs != DialogResult.Yes) return;

			try
			{
				MauSacDAL.Update(new MauSacDAO
				{
					
					TenMau = txtMauSac.Text.Trim(),
					
				});

				MessageBox.Show("Cập nhật màu sắc thành công!");
				dgvMauSac.DataSource = MauSacDAL.SelectAll();
				ClearForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi cập nhật: " + ex.Message);
			}
		}
	}
}

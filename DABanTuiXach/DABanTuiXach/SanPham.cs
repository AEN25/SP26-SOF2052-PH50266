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
		}

		private void SanPham_Load(object sender, EventArgs e)
		{
			dgvSanPham.DataSource = DAL.SanPhamDAL.SelectAll();

			dgvSanPham.ClearSelection();
			ClearForm();
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
	}
}

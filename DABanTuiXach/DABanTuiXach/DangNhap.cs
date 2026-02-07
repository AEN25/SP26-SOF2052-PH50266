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
	public partial class DangNhap : Form
	{
		public DangNhap()
		{
			InitializeComponent();
			txtMk.PasswordChar = '*';

		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtTk.Text))
			{
				MessageBox.Show("Vui lòng nhập tài khoản");
				return;
			}

			if (string.IsNullOrWhiteSpace(txtMk.Text))
			{
				MessageBox.Show("Vui lòng nhập mật khẩu");
				return;
			}

			try
			{
				LoginDAO login = new LoginDAO
				{
					TaiKhoan = txtTk.Text.Trim(),
					MatKhau = txtMk.Text.Trim()
				};

				DataTable dt = LoginDAL.DangNhap(login);

				if (dt.Rows.Count > 0)
				{
					string tenNhanVien = dt.Rows[0]["tenNhanVien"].ToString();
					MessageBox.Show("Đăng nhập thành công!");

					Menu menu = new Menu(tenNhanVien);
					menu.Show();

					this.Hide();
				}
				else
				{
					MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi đăng nhập: " + ex.Message);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DABanTuiXach
{
	public partial class Menu : Form
	{
		private Form currentForm = null;
		private Form menu;

		public Menu(string tenNhanVien)
		{
			InitializeComponent();
			lbl_tenhienthi.Text = "Xin chào: " + tenNhanVien;
		}
		private void OpenChildForm(Form childForm)
		{
			if (currentForm != null)
			{
				currentForm.Close();
				currentForm.Dispose();
			}

			currentForm = childForm;

			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			childForm.Padding = new Padding(0);
			childForm.Margin = new Padding(0);

			pn_trangchu.Controls.Clear();
			pn_trangchu.Controls.Add(childForm);

			childForm.Show();
		}
		private void bt_sanphammenu_Click(object sender, EventArgs e)
		{
			lb_trangchu.Text = bt_sanphammenu.Text;
			OpenChildForm(new SanPham());
		}

		private void bt_banhangmenu_Click(object sender, EventArgs e)
		{
			lb_trangchu.Text = bt_banhangmenu.Text;
			OpenChildForm(new BanHang());
		}

		private void bt_hoadonmenu_Click(object sender, EventArgs e)
		{
			lb_trangchu.Text = bt_hoadonmenu.Text;
			OpenChildForm(new HoaDon());
		}

		private void bt_khachhangmenu_Click(object sender, EventArgs e)
		{
			lb_trangchu.Text = bt_khachhangmenu.Text;
			OpenChildForm(new KhachHang());
		}

		private void bt_dangxuatmenu_Click(object sender, EventArgs e)
		{
			lb_trangchu.Text = bt_dangxuatmenu.Text;
			OpenChildForm(new DangNhap());
		}

		private void bt_nhanvienmenu_Click(object sender, EventArgs e)
		{
			lb_trangchu.Text = bt_nhanvienmenu.Text;
			OpenChildForm(new NhanVien());
		}
	}
}

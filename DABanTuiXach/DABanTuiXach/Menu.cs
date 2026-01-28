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
		private Form menu;
		public Menu()
		{
			InitializeComponent();
		}
		private void OpenMenuForm(Form formcon)
		{
			if (menu != null)
			{
				menu.Close();
			}
			menu = formcon;
			formcon.TopLevel = false;
			formcon.FormBorderStyle = FormBorderStyle.None;
			formcon.Dock = DockStyle.Fill;

			pn_trangchu.Controls.Add(formcon);
			pn_trangchu.Tag = formcon;
			formcon.BringToFront();

			formcon.Show();
		}
		private void bt_sanphammenu_Click(object sender, EventArgs e)
		{
			lb_trangchu.Text = bt_sanphammenu.Text;
			OpenMenuForm(new SanPham());
		}
	}
}

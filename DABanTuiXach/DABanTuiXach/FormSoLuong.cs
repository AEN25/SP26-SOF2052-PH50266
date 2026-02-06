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
	public partial class FormSoLuong : Form
	{
		public int SoLuongNhap { get; private set; }
		private int _tonKho;
		public FormSoLuong(int tonKho)
		{
			InitializeComponent();
			_tonKho = tonKho;
		}
		

		private void button1_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(txtSoLuong.Text, out int soLuong))
			{
				MessageBox.Show("Số lượng phải là số", "Lỗi",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (soLuong <= 0)
			{
				MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (soLuong > _tonKho)
			{
				MessageBox.Show($"Số lượng vượt tồn kho ({_tonKho})", "Lỗi",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			SoLuongNhap = soLuong;
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}

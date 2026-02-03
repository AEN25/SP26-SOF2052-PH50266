using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABanTuiXach.DAO
{
	public class HoaDonChiTiet
	{
		public int MaHoaDonChiTiet { get; set; }

		public int MaHoaDon { get; set; }

		public int MaSanPhamChiTiet { get; set; }

		public int SoLuong { get; set; }

		public decimal DonGia { get; set; }

		public bool TrangThai { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABanTuiXach.DAO
{
	public class SanPhamChiTiet
	{
		public int MaSanPhamChiTiet { get; set; }

		public string TenSanPhamChiTiet { get; set; }
		public int GiaSanPham { get; set; }
		public int MaSanPham { get; set; }
		public int MaMauSac { get; set; }
		public bool TrangThai { get; set; }
	}
}

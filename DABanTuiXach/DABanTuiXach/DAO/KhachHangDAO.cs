using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABanTuiXach.DAO
{
	public class KhachHangDAO
	{
		public int MaKhachHang { get; set; }
		public string TenKhachHang { get; set; }
		public bool GioiTinh { get; set; }
		public string SoDienThoai { get; set; }
		public string Email { get; set; }
		public string DiaChi { get; set; }
		public bool TrangThai { get; set; }
	}
}

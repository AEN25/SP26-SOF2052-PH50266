using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABanTuiXach.DAO
{
	public class NhanVienDAO
	{
		public int MaNhanVien { get; set; }

		public string TenNhanVien { get; set; }

		public string SoDienThoai { get; set; }

		public bool GioiTinh { get; set; }

		public string Email { get; set; }
		public int Quyen	 { get; set; }
		public string DiaChi { get; set; }

		public string TaiKhoan { get; set; }

		public string MatKhau { get; set; }

		public bool TrangThai { get; set; }
	}
}

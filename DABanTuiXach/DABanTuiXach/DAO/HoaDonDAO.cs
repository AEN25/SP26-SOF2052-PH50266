using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DABanTuiXach.DAO
{
	public class HoaDonDAO
	{
		public int MaHoaDon { get; set; }
		public string TenKhachHang { get; set; }   // NOT NULL
		public string SoDienThoai { get; set; }
		public DateTime NgayLapHoaDon { get; set; }
		public string PhuongThucThanhToan { get; set; }
		public int TongTien { get; set; }
		public bool TrangThai { get; set; }
		public int? MaKhachHang { get; set; }
		public int? MaNhanVien { get; set; }

		public List<HoaDonChiTiet> ChiTietList { get; set; } = new();


	}
}
   
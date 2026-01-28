using DABanTuiXach.DAO;
using DABanTuiXach.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABanTuiXach.DAL
{
	public static class HoaDonDAL
	{
		public static DataTable SelectAll()
		{
			DBUtil.OpenConnection();
			DataTable dt = DBUtil.ExecuteQueryTable(
				"SELECT * FROM HoaDon",
				null
			);
			DBUtil.CloseConnection();
			return dt;
		}

		public static void TaoMoi(HoaDonDAO hd)
		{
			DBUtil.OpenConnection();
			DBUtil.ExecuteNonQuery(
				@"INSERT INTO HoaDon
                (tenKhachHang, soDienThoai, ngayLapHoaDon, phuongThucThanhToan, TongTien, trangThai, maKhachHang, maNhanVien)
                VALUES (@0, @1, @2, @3, @4, @5, @6, @7)",
				[
					hd.TenKhachHang,
					hd.SoDienThoai,
					hd.NgayLapHoaDon,
					hd.PhuongThucThanhToan,
					hd.TongTien,
					hd.TrangThai ? 1 : 0,
					hd.MaKhachHang,
					hd.MaNhanVien
				]
			);
			DBUtil.CloseConnection();
		}

		public static void CapNhat(HoaDonDAO hd)
		{
			DBUtil.OpenConnection();
			DBUtil.ExecuteNonQuery(
				@"UPDATE HoaDon SET
                    tenKhachHang=@0,
                    soDienThoai=@1,
                    ngayLapHoaDon=@2,
                    phuongThucThanhToan=@3,
                    TongTien=@4,
                    trangThai=@5,
                    maKhachHang=@6,
                    maNhanVien=@7
                  WHERE maHoaDon=@8",
				[
					hd.TenKhachHang,
					hd.SoDienThoai,
					hd.NgayLapHoaDon,
					hd.PhuongThucThanhToan,
					hd.TongTien,
					hd.TrangThai ? 1 : 0,
					hd.MaKhachHang,
					hd.MaNhanVien,
					hd.MaHoaDon
				]
			);
			DBUtil.CloseConnection();
		}

		public static void ThanhToan(int maHoaDon)
		{
			DBUtil.OpenConnection();
			DBUtil.ExecuteNonQuery(
				"UPDATE HoaDon SET trangThai=1 WHERE maHoaDon=@0",
				[maHoaDon]
			);
			DBUtil.CloseConnection();
		}

		public static void Xoa(int maHoaDon)
		{
			DBUtil.OpenConnection();

			DBUtil.ExecuteNonQuery(
				"DELETE FROM HDCT WHERE maHoaDon=@0",
				[maHoaDon]
			);

			DBUtil.ExecuteNonQuery(
				"DELETE FROM HoaDon WHERE maHoaDon=@0",
				[maHoaDon]
			);

			DBUtil.CloseConnection();
		}
	}
}

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
		public static DataTable SelectAllHoaDon()
		{
			DBUtil.OpenConnection();

			DataTable dt = DBUtil.ExecuteQueryTable(
				"SELECT * FROM HoaDon",
				null
			);

			DBUtil.CloseConnection();
			return dt;
		}

		public static DataTable SelectHoaDonChiTiet(int maHoaDon)
		{
			DBUtil.OpenConnection();

			DataTable dt = DBUtil.ExecuteQueryTable(
				"SELECT * FROM HoaDonChiTiet WHERE MaHoaDon=@0",
				new List<object> { maHoaDon }
			);

			DBUtil.CloseConnection();
			return dt;
		}

		
		public static void InsertHoaDon(HoaDonDAO hd)
		{
			DBUtil.OpenConnection();

			if (hd.ChiTietList == null || hd.ChiTietList.Count == 0)
			{
				DBUtil.CloseConnection();
				throw new Exception("Hóa đơn phải có ít nhất 1 sản phẩm.");
			}

			List<object> parameters = new()
			{
				hd.SoDienThoai,
				hd.NgayLapHoaDon,
				hd.PhuongThucThanhToan,
				hd.TongTien,
				hd.TrangThai ? 1 : 0,
				hd.MaKhachHang,
				hd.MaNhanVien
			};

			string sqlCT = "";
			int p = parameters.Count;

			foreach (var ct in hd.ChiTietList)
			{
				sqlCT += $@"
				INSERT INTO HoaDonChiTiet
				(MaHoaDon, MaSanPhamChiTiet, SoLuong, DonGia, TrangThai)
				VALUES (@MaHoaDon, @{p}, @{p + 1}, @{p + 2}, @{p + 3})";

				parameters.Add(ct.MaSanPhamChiTiet);
				parameters.Add(ct.SoLuong);
				parameters.Add(ct.DonGia);
				parameters.Add(ct.TrangThai ? 1 : 0);

				p += 4;
			}

			string sql = $@"
			BEGIN TRY
				BEGIN TRAN

				INSERT INTO HoaDon
				(SoDienThoai, NgayLapHoaDon, PhuongThucThanhToan,
				 TongTien, TrangThai, MaKhachHang, MaNhanVien)
				VALUES (@0,@1,@2,@3,@4,@5,@6)

				DECLARE @MaHoaDon INT = SCOPE_IDENTITY()

				{sqlCT}

				COMMIT
			END TRY
			BEGIN CATCH
				ROLLBACK
				THROW
			END CATCH";

			DBUtil.ExecuteNonQuery(sql, parameters);
			DBUtil.CloseConnection();
		}

		
		public static void UpdateHoaDon(HoaDonDAO hd)
		{
			DBUtil.OpenConnection();

			DBUtil.ExecuteNonQuery(
				@"UPDATE HoaDon SET
					SoDienThoai=@0,
					PhuongThucThanhToan=@1,
					TongTien=@2,
					TrangThai=@3,
					MaKhachHang=@4,
					MaNhanVien=@5
				  WHERE MaHoaDon=@6",
				new List<object>
				{
					hd.SoDienThoai,
					hd.PhuongThucThanhToan,
					hd.TongTien,
					hd.TrangThai ? 1 : 0,
					hd.MaKhachHang,
					hd.MaNhanVien,
					hd.MaHoaDon
				}
			);

			DBUtil.CloseConnection();
		}

		public static void DeleteHoaDon(int maHoaDon)
		{
			DBUtil.OpenConnection();

			DBUtil.ExecuteNonQuery(
				@"
				BEGIN TRY
					BEGIN TRAN
					DELETE FROM HoaDonChiTiet WHERE MaHoaDon=@0
					DELETE FROM HoaDon WHERE MaHoaDon=@0
					COMMIT
				END TRY
				BEGIN CATCH
					ROLLBACK
					THROW
				END CATCH",
				new List<object> { maHoaDon }
			);

			DBUtil.CloseConnection();
		}

		public static void ThanhToanHoaDon(int maHoaDon)
		{
			DBUtil.OpenConnection();

			DBUtil.ExecuteNonQuery(
				"UPDATE HoaDon SET TrangThai=1 WHERE MaHoaDon=@0",
				new List<object> { maHoaDon }
			);

			DBUtil.CloseConnection();
		}
	}
}

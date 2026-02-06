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
				"SELECT * FROM HDCT WHERE MaHoaDon=@0",
				new List<object> { maHoaDon }
			);

			DBUtil.CloseConnection();
			return dt;
		}


		public static void InsertHoaDon(HoaDonDAO hd)
		{
			DBUtil.OpenConnection();

			List<object> param = new()
			{
				hd.TenKhachHang,
				hd.SoDienThoai,
				hd.NgayLapHoaDon,
				hd.PhuongThucThanhToan,
				hd.TongTien,
				hd.TrangThai ? 1 : 0,
				hd.MaKhachHang,
				hd.MaNhanVien
			};

			string sqlCT = "";
			int p = param.Count;

			foreach (var ct in hd.ChiTietList)
			{
				sqlCT += $@"
				INSERT INTO HDCT
				(tenSanPham, soLuong, gia, trangThai, maHoaDon, maSanPhamChiTiet)
				VALUES (@{p}, @{p + 1}, @{p + 2}, @{p + 3}, @MaHoaDon, @{p + 4});";

				param.Add(ct.TenSanPham);
				param.Add(ct.SoLuong);
				param.Add(ct.Gia);
				param.Add(ct.TrangThai ? 1 : 0);
				param.Add(ct.MaSanPhamChiTiet);

				p += 5;
			}

			string sql = $@"
			BEGIN TRY
				BEGIN TRAN

				INSERT INTO HoaDon
				(tenKhachHang, soDienThoai, ngayLapHoaDon, phuongThucThanhToan,
				 TongTien, trangThai, maKhachHang, maNhanVien)
				VALUES (@0,@1,@2,@3,@4,@5,@6,@7)

				DECLARE @MaHoaDon INT = SCOPE_IDENTITY()

				{sqlCT}

				COMMIT
			END TRY
			BEGIN CATCH
				IF @@TRANCOUNT > 0
					ROLLBACK
				RAISERROR (N'Lỗi khi lưu hóa đơn', 16, 1)
			END CATCH";


			DBUtil.ExecuteNonQuery(sql, param);
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

		public static void DeleteHoaDonCho(int maHoaDon)
		{
			DBUtil.OpenConnection();

			DBUtil.ExecuteNonQuery(@"
        DELETE FROM HDCT WHERE maHoaDon = @0;
        DELETE FROM HoaDon WHERE maHoaDon = @0 AND trangThai = 0;",
				new List<object> { maHoaDon });

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
		public static DataTable SelectHoaDonDaThanhToan(
		DateTime tuNgay,
		DateTime denNgay,
		string keyword)
		{
			DBUtil.OpenConnection();

			string sql = @"
			SELECT 
				hd.maHoaDon,
				hd.ngayLapHoaDon,
				hd.tenKhachHang,
				hd.soDienThoai,
				nv.tenNhanVien,
				hd.tongTien
			FROM HoaDon hd
			JOIN NhanVien nv ON hd.maNhanVien = nv.maNhanVien
			WHERE hd.trangThai = 1
			  AND hd.ngayLapHoaDon >= @0
			  AND hd.ngayLapHoaDon < @1
			  AND (
					hd.tenKhachHang LIKE @2
					OR hd.soDienThoai LIKE @2
				  )
			ORDER BY hd.ngayLapHoaDon DESC";

					var dt = DBUtil.ExecuteQueryTable(sql, new List<object>
			{
				tuNgay,
				denNgay,
				"%" + keyword + "%"
			});

			DBUtil.CloseConnection();
			return dt;

		}
		public static DataTable SelectTatCaHoaDonDaThanhToan()
		{
			DBUtil.OpenConnection();

			string sql = @"
			SELECT 
				hd.maHoaDon,
				hd.ngayLapHoaDon,
				hd.tenKhachHang,
				hd.soDienThoai,
				nv.tenNhanVien,
				hd.tongTien
			FROM HoaDon hd
			JOIN NhanVien nv ON hd.maNhanVien = nv.maNhanVien
			WHERE hd.trangThai = 1
			ORDER BY hd.ngayLapHoaDon DESC";

			var dt = DBUtil.ExecuteQueryTable(sql, null);

			DBUtil.CloseConnection();
			return dt;
		}
		public static int InsertHoaDonCho(HoaDonDAO hd)
		{
			DBUtil.OpenConnection();

			string sql = @"
        INSERT INTO HoaDon
        (tenKhachHang, soDienThoai, ngayLapHoaDon, phuongThucThanhToan,
         tongTien, trangThai, maKhachHang, maNhanVien)
        VALUES (@0,@1,@2,@3,@4,@5,@6,@7);

        SELECT SCOPE_IDENTITY();";

			object result = DBUtil.ExecuteScalar(sql, new List<object>
	{
		hd.TenKhachHang,
		hd.SoDienThoai,
		hd.NgayLapHoaDon,
		hd.PhuongThucThanhToan,
		0,              
        0,              
        hd.MaKhachHang,
		hd.MaNhanVien
	});

			DBUtil.CloseConnection();
			return Convert.ToInt32(result);
		}
		public static DataTable SelectHoaDonCho()
		{
			DBUtil.OpenConnection();

			var dt = DBUtil.ExecuteQueryTable(@"
			SELECT maHoaDon
			FROM HoaDon
			WHERE trangThai = 0
			ORDER BY maHoaDon DESC", null);

			DBUtil.CloseConnection();
			return dt;
		}
		public static HoaDonDAO SelectHoaDonById(int maHoaDon)
		{
			DBUtil.OpenConnection();

			DataTable dt = DBUtil.ExecuteQueryTable(@"
			SELECT *
			FROM HoaDon
			WHERE maHoaDon = @0",
				new List<object> { maHoaDon });

			DBUtil.CloseConnection();

			if (dt.Rows.Count == 0)
				return null;

			DataRow r = dt.Rows[0];

			return new HoaDonDAO
			{
				MaHoaDon = Convert.ToInt32(r["maHoaDon"]),
				TenKhachHang = r["tenKhachHang"].ToString(),
				SoDienThoai = r["soDienThoai"].ToString(),
				NgayLapHoaDon = Convert.ToDateTime(r["ngayLapHoaDon"]),
				PhuongThucThanhToan = r["phuongThucThanhToan"].ToString(),
				TongTien = Convert.ToInt32(r["tongTien"]),
				TrangThai = Convert.ToBoolean(r["trangThai"]),
				MaKhachHang = r["maKhachHang"] == DBNull.Value
					? null
					: Convert.ToInt32(r["maKhachHang"]),
				MaNhanVien = Convert.ToInt32(r["maNhanVien"])
			};
		}

	}
}

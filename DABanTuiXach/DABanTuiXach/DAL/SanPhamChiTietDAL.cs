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
	public class SanPhamChiTietDAL
	{
				public static DataTable SelectAll()
				{
					DBUtil.OpenConnection();

					var dt = DBUtil.ExecuteQueryTable(@"
						SELECT 
							spct.maSanPhamChiTiet,
							spct.tenSanPhamChiTiet,
							sp.tenSanPham,
							ms.tenMau,
							spct.giaSanPham,
							spct.soLuong,
							spct.trangThai,
							spct.maSanPham,
							spct.maMauSac
						FROM SanPhamChiTiet spct
						JOIN SanPham sp ON spct.maSanPham = sp.maSanPham
						JOIN MauSac ms ON spct.maMauSac = ms.maMauSac
					", null);

					DBUtil.CloseConnection();
					return dt;
				}

		
		public static DataTable SelectById(int maSPCT)
		{
			DBUtil.OpenConnection();
			DataTable dt = DBUtil.ExecuteQueryTable(
				"SELECT * FROM SanPhamChiTiet WHERE maSanPhamChiTiet=@0",
				new List<object> { maSPCT }
			);
			DBUtil.CloseConnection();
			return dt;
		}

		
		public static void Insert(SanPhamChiTiet spct)
		{
			DBUtil.OpenConnection();

			DBUtil.ExecuteNonQuery(@"
				INSERT INTO SanPhamChiTiet
				(tenSanPhamChiTiet, giaSanPham, soLuong, trangThai, maSanPham, maMauSac)
				VALUES (@0,@1,@2,@3,@4,@5)
			", new List<object>
			{
				spct.TenSanPhamChiTiet,
				spct.GiaSanPham,
				spct.SoLuong,
				spct.TrangThai ? 1 : 0,
				spct.MaSanPham,
				spct.MaMauSac
			});

			DBUtil.CloseConnection();
		}

		
		public static void Update(SanPhamChiTiet spct)
		{
			DBUtil.OpenConnection();

			DBUtil.ExecuteNonQuery(@"
                UPDATE SanPhamChiTiet SET
                    tenSanPhamChiTiet=@0,
                    giaSanPham=@1,
                    soLuong=@2,
                    trangThai=@3,
                    maSanPham=@4,
                    maMauSac=@5
                WHERE maSanPhamChiTiet=@6",
				new List<object>
				{
					spct.TenSanPhamChiTiet,
					spct.GiaSanPham,
					spct.SoLuong,
					spct.TrangThai ? 1 : 0,
					spct.MaSanPham,
					spct.MaMauSac,
					spct.MaSanPhamChiTiet
				});

			DBUtil.CloseConnection();
		}

		
		public static void Delete(int maSPCT)
		{
			DBUtil.OpenConnection();
			DBUtil.ExecuteNonQuery(
				"DELETE FROM SanPhamChiTiet WHERE maSanPhamChiTiet=@0",
				new List<object> { maSPCT }
			);
			DBUtil.CloseConnection();
		}
		public static DataTable SelectAllView()
		{
			DBUtil.OpenConnection();
			DataTable dt = DBUtil.ExecuteQueryTable(
				@"SELECT 
            spct.maSanPhamChiTiet,
            spct.tenSanPhamChiTiet,
            sp.tenSanPham,
            ms.tenMau,
            spct.giaSanPham,
            spct.trangThai,
            spct.maSanPham,
            spct.maMauSac
			FROM SanPhamChiTiet spct
			JOIN sanpham sp ON spct.maSanPham = sp.maSanPham
			JOIN mausac ms ON spct.maMauSac = ms.maMauSac",
				null
			);
			DBUtil.CloseConnection();
			return dt;
		}
		public static void TruSoLuong(int maSPCT, int soLuong)
		{
			DBUtil.OpenConnection();

			DBUtil.ExecuteNonQuery(@"
        UPDATE SanPhamChiTiet
        SET soLuong = soLuong - @1
        WHERE maSanPhamChiTiet = @0",
				new List<object> { maSPCT, soLuong });

			DBUtil.CloseConnection();
		}

	}
}

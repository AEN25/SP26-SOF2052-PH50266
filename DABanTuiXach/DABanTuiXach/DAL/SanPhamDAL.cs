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
	public static class SanPhamDAL
	{
		public static DataTable SelectForCombo()
		{
			DBUtil.OpenConnection();
			DataTable dt = DBUtil.ExecuteQueryTable(
				"SELECT maSanPham, tenSanPham FROM SanPham",
				null
			);
			DBUtil.CloseConnection();
			return dt;
		}

		public static DataTable SelectAll()
		{
			DBUtil.OpenConnection();
			DataTable dt = DBUtil.ExecuteQueryTable(
				"SELECT * FROM SanPham",
				null
			);
			DBUtil.CloseConnection();
			return dt;
		}

		public static void TaoMoi(SanPhamDAO sp)
		{
			DBUtil.OpenConnection();
			DBUtil.ExecuteNonQuery(
				@"INSERT INTO SanPham (tenSanPham, size, chatLieu, kieuDang)
                  VALUES (@0, @1, @2, @3)",
				[
					sp.TenSanPham,
					sp.Size,
					sp.ChatLieu,
					sp.KieuDang
				]
			);
			DBUtil.CloseConnection();
		}

		public static void CapNhat(SanPhamDAO sp)
		{
			DBUtil.OpenConnection();
			DBUtil.ExecuteNonQuery(
				@"UPDATE SanPham SET
                    tenSanPham=@0,
                    size=@1,
                    chatLieu=@2,
                    kieuDang=@3
                  WHERE maSanPham=@4",
				[
					sp.TenSanPham,
					sp.Size,
					sp.ChatLieu,
					sp.KieuDang,
					sp.MaSanPham
				]
			);
			DBUtil.CloseConnection();
		}

		public static void Xoa(int maSanPham)
		{
			DBUtil.OpenConnection();
			DBUtil.ExecuteNonQuery(
				"DELETE FROM SanPham WHERE maSanPham=@0",
				[maSanPham]
			);
			DBUtil.CloseConnection();
		}
		

	}
}

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
	public static class KhachHangDAL
	{
		public static DataTable SelectAll()
		{
			DBUtil.OpenConnection();

			DataTable dt = DBUtil.ExecuteQueryTable(
				"SELECT * FROM KhachHang",
				null
			);

			DBUtil.CloseConnection();
			return dt;
		}

	
		public static DataTable SelectById(int maKhachHang)
		{
			DBUtil.OpenConnection();

			DataTable dt = DBUtil.ExecuteQueryTable(
				"SELECT * FROM KhachHang WHERE maKhachHang=@0",
				new List<object> { maKhachHang }
			);

			DBUtil.CloseConnection();
			return dt;
		}

	
		public static void Insert(KhachHangDAO kh)
		{
			if (string.IsNullOrWhiteSpace(kh.TenKhachHang))
				throw new Exception("Tên khách hàng không được để trống");

			DBUtil.OpenConnection();

			DBUtil.ExecuteNonQuery(
				@"INSERT INTO KhachHang
                  (tenKhachHang, gioiTinh, soDienThoai, email, diaChi, trangThai)
                  VALUES (@0,@1,@2,@3,@4,@5)",
				new List<object>
				{
					kh.TenKhachHang,
					kh.GioiTinh,
					kh.SoDienThoai,
					kh.Email,
					kh.DiaChi,
					kh.TrangThai
				}
			);

			DBUtil.CloseConnection();
		}

		
		public static void Update(KhachHangDAO kh)
		{
			if (kh.MaKhachHang <= 0)
				throw new Exception("Mã khách hàng không hợp lệ");

			DBUtil.OpenConnection();

			DBUtil.ExecuteNonQuery(
				@"UPDATE KhachHang SET
                    tenKhachHang=@0,
                    gioiTinh=@1,
                    soDienThoai=@2,
                    email=@3,
                    diaChi=@4,
                    trangThai=@5
                  WHERE maKhachHang=@6",
				new List<object>
				{
					kh.TenKhachHang,
					kh.GioiTinh,
					kh.SoDienThoai,
					kh.Email,
					kh.DiaChi,
					kh.TrangThai,
					kh.MaKhachHang
				}
			);

			DBUtil.CloseConnection();
		}

		
		public static void Delete(int maKhachHang)
		{
			DBUtil.OpenConnection();

			DBUtil.ExecuteNonQuery(
				"DELETE FROM KhachHang WHERE maKhachHang=@0",
				new List<object> { maKhachHang }
			);

			DBUtil.CloseConnection();
		}


		public static void Disable(int maKhachHang)
		{
			DBUtil.OpenConnection();

			DBUtil.ExecuteNonQuery(
				"UPDATE KhachHang SET trangThai=0 WHERE maKhachHang=@0",
				new List<object> { maKhachHang }
			);

			DBUtil.CloseConnection();
		}

		public static DataTable Search(string keyword)
		{
			DBUtil.OpenConnection();

			DataTable dt = DBUtil.ExecuteQueryTable(
				@"SELECT * FROM KhachHang WHERE
                  tenKhachHang LIKE @0 OR
                  soDienThoai LIKE @0 OR
                  email LIKE @0",
				new List<object> { "%" + keyword + "%" }
			);

			DBUtil.CloseConnection();
			return dt;
		}

		public static DataTable SelectBySoDienThoai(string sdt)
		{
			DBUtil.OpenConnection();

			var dt = DBUtil.ExecuteQueryTable(
				"SELECT maKhachHang, tenKhachHang, soDienThoai FROM KhachHang WHERE soDienThoai = @0",
				new List<object> { sdt }
			);

			DBUtil.CloseConnection();
			return dt;
		}

	}
}

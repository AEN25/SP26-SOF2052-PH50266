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
	public static class NhanVienDAL
	{
		public static DataTable SelectAll()
		{
			DBUtil.OpenConnection();
			DataTable dt = DBUtil.ExecuteQueryTable(
				"SELECT * FROM nhanVien",
				null
			);
			DBUtil.CloseConnection();
			return dt;
		}

		// Thêm nhân viên
		public static void TaoMoi(NhanVienDAO nv)
		{
			DBUtil.OpenConnection();
			DBUtil.ExecuteNonQuery(
				@"INSERT INTO nhanVien
                (tenNhanVien, soDienThoai, gioiTinh, email, diaChi, taikhoan, matkhau, trangThai)
                VALUES (@0, @1, @2, @3, @4, @5, @6, @7)",
				new List<object>
				{
					nv.TenNhanVien,
					nv.SoDienThoai,
					nv.GioiTinh ? 1 : 0,
					nv.Email,
					nv.DiaChi,
					nv.TaiKhoan,
					nv.MatKhau,
					nv.TrangThai ? 1 : 0
				}
			);
			DBUtil.CloseConnection();
		}

		// Cập nhật nhân viên
		public static void CapNhat(NhanVienDAO nv)
		{
			DBUtil.OpenConnection();
			DBUtil.ExecuteNonQuery(
				@"UPDATE nhanVien SET
                    tenNhanVien=@0,
                    soDienThoai=@1,
                    gioiTinh=@2,
                    email=@3,
                    diaChi=@4,
                    taikhoan=@5,
                    matkhau=@6,
                    trangThai=@7
                  WHERE maNhanVien=@8",
				new List<object>
				{
					nv.TenNhanVien,
					nv.SoDienThoai,
					nv.GioiTinh ? 1 : 0,
					nv.Email,
					nv.DiaChi,
					nv.TaiKhoan,
					nv.MatKhau,
					nv.TrangThai ? 1 : 0,
					nv.MaNhanVien
				}
			);
			DBUtil.CloseConnection();
		}

		// Xóa nhân viên
		public static void Xoa(int maNhanVien)
		{
			DBUtil.OpenConnection();
			DBUtil.ExecuteNonQuery(
				"DELETE FROM nhanVien WHERE maNhanVien=@0",
				new List<object> { maNhanVien }
			);
			DBUtil.CloseConnection();
		}

		// Tìm theo mã
		public static DataTable SelectById(int maNhanVien)
		{
			DBUtil.OpenConnection();
			DataTable dt = DBUtil.ExecuteQueryTable(
				"SELECT * FROM nhanVien WHERE maNhanVien=@0",
				new List<object> { maNhanVien }
			);
			DBUtil.CloseConnection();
			return dt;
		}
	}
}

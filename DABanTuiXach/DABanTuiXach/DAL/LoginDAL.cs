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
	public static class LoginDAL
	{
		public static DataTable DangNhap(LoginDAO login)
		{
			DBUtil.OpenConnection();

			string sql = @"
            SELECT *
            FROM nhanVien
            WHERE taikhoan = @0
            AND matkhau = @1
            AND trangThai = 1";

			DataTable dt = DBUtil.ExecuteQueryTable(sql, new List<object>
			{
				login.TaiKhoan,
				login.MatKhau
			});

			DBUtil.CloseConnection();
			return dt;
		}

	}
}

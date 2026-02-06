using DABanTuiXach.DAO;
using DABanTuiXach.Utils;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABanTuiXach.DAL
{
	public static class MauSacDAL
	{
		
		public static DataTable SelectAll()
		{
			DBUtil.OpenConnection();

			DataTable dt = DBUtil.ExecuteQueryTable(
				"SELECT maMauSac, tenMau FROM MauSac",
				null
			);

			DBUtil.CloseConnection();
			return dt;
		}

		public static void Insert(MauSacDAO ms)
		{
			if (string.IsNullOrWhiteSpace(ms.TenMau))
				throw new Exception("Tên màu không được để trống");

			DBUtil.OpenConnection();

			DBUtil.ExecuteNonQuery(
				"INSERT INTO MauSac (tenMau) VALUES (@0)",
				new List<object> { ms.TenMau.Trim() }
			);

			DBUtil.CloseConnection();
		}

		public static void Update(MauSacDAO ms)
		{
			if (ms.MaMauSac <= 0)
				throw new Exception("Mã màu không hợp lệ");

			if (string.IsNullOrWhiteSpace(ms.TenMau))
				throw new Exception("Tên màu không được để trống");

			DBUtil.OpenConnection();

			DBUtil.ExecuteNonQuery(
				"UPDATE MauSac SET tenMau=@0 WHERE maMauSac=@1",
				new List<object>
				{
					ms.TenMau.Trim(),
					ms.MaMauSac
				}
			);

			DBUtil.CloseConnection();
		}

		public static void Delete(int maMauSac)
		{
			DBUtil.OpenConnection();

			DBUtil.ExecuteNonQuery(
				"DELETE FROM MauSac WHERE maMauSac=@0",
				new List<object> { maMauSac }
			);

			DBUtil.CloseConnection();
		}


		public static DataTable Search(string keyword)
		{
			DBUtil.OpenConnection();

			DataTable dt = DBUtil.ExecuteQueryTable(
				"SELECT maMauSac, tenMau FROM MauSac WHERE tenMau LIKE @0",
				new List<object> { "%" + keyword + "%" }
			);

			DBUtil.CloseConnection();
			return dt;
		}
	}
}

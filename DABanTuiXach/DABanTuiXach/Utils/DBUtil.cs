using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABanTuiXach.Utils
{
	internal class DBUtil
	{
		private static readonly string _connectionString = "Server=ANH2005\\SQLEXPRESS;" +
		"Database=Du_An_Mau_PH50266;" +
		"Integrated Security=True;" +
		"TrustServerCertificate=True;";

		private static SqlConnection? _connection = null;

		public static string? OpenConnection()
		{
			try
			{
				if (_connection == null)
				{
					_connection = new SqlConnection(_connectionString);
				}

				if (_connection.State != ConnectionState.Open)
				{
					_connection.Open();
				}

				return null;
			}
			catch (SqlException ex)
			{
				return ex.Message;
			}
		}

		//public static SqlDataReader ExecuteQueryReader(string sql, List<object> parameters)
		//{
		//    SqlCommand command = new(sql, _connection);
		//    if (parameters != null)
		//    {
		//        for (int i = 0; i < parameters.Count; i++)
		//        {
		//            command.Parameters.AddWithValue($"@p{i}", parameters[i] ?? DBNull.Value);
		//        }
		//    }
		//    SqlDataReader reader = command.ExecuteReader();
		//    return reader;
		//}
		public static object ExecuteScalar(string sql, List<object> param)
		{
			using (SqlCommand cmd = new SqlCommand(sql, _connection))
			{
				if (param != null)
				{
					for (int i = 0; i < param.Count; i++)
					{
						cmd.Parameters.AddWithValue($"@{i}", param[i] ?? DBNull.Value);
					}
				}

				return cmd.ExecuteScalar();
			}
		}

		public static DataTable ExecuteQueryTable(string sql, List<object> parameters)
		{
			SqlCommand command = new(sql, _connection);

			if (parameters != null)
			{
				int i = -1;
				parameters.ForEach(prm =>
				{
					i++;
					command.Parameters.AddWithValue($"@{i}", prm ?? DBNull.Value);
				});
			}

			SqlDataAdapter adapter = new(command);
			DataTable dt = new();
			adapter.Fill(dt);

			return dt;
		}

		public static void ExecuteNonQuery(string sql, List<object> parameters)
		{
			if (parameters != null)
			{
				SqlCommand command = new(sql, _connection);
				int i = -1;
				parameters.ForEach((prm) =>
				{
					i++;
					command.Parameters.AddWithValue($"@{i}", prm ?? DBNull.Value);
				});
				command.ExecuteNonQuery();
			}
		}

		public static string? CloseConnection()
		{
			try
			{
				if (_connection != null && _connection.State != ConnectionState.Closed)
				{
					_connection.Close();
				}
				return null;
			}
			catch (SqlException ex)
			{
				return ex.Message;
			}
		}
	}
}

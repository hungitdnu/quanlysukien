using Server.Models;
using Server.Service;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Server
{
	public class SqlService
	{
		private static SqlService instance;
		private SqlService() { }
		private string connectionString = "Data Source=NOI0VOITOXIC\\SQLEXPRESS;Initial Catalog=QuanLySuKien;Integrated Security=True;TrustServerCertificate=True";
		public static SqlService gI()
		{
			if (instance == null) instance = new SqlService();
			return instance;
		}

		public List<User> GetUSers()
		{
			List<User> employees = new List<User>();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM NguoiDung";

				SqlCommand command = new SqlCommand(query, connection);

				try
				{
					connection.Open();
					SqlDataReader reader = command.ExecuteReader();

					while (reader.Read())
					{
						User employee = new User
						{
							fullName = reader["Fullname"].ToString(),
							passWord = reader["Password"].ToString(),
							userName = reader["Username"].ToString(),
							isOnline = false
						};

						employees.Add(employee);
					}

					reader.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
				}
				finally
				{
					connection.Close();
				}
			}

			return employees;
		}
		public List<Event> GetEvents()
		{
			List<Event> events = new List<Event>();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM SuKien";

				SqlCommand command = new SqlCommand(query, connection);

				try
				{
					connection.Open();
					SqlDataReader reader = command.ExecuteReader();

					while (reader.Read())
					{
						Event e = new Event
						{
							ID = int.Parse(reader["ID"].ToString()),
							tenSuKien = reader["TenSuKien"].ToString(),
							_thoiGian = DateTime.Parse(reader["ThoiGian"].ToString()),
							diaDiem = reader["DiaDiem"].ToString(),
							moTa = reader["MoTa"].ToString(),
							nguoiTao = UserService.gI().GetUserByUsername(reader["Owner"].ToString())
						};

						events.Add(e);
					}

					reader.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
				}
				finally
				{
					connection.Close();
				}
			}
			return events;
		}
		public void GetJoinEvent()
		{
			for(int i = 0; i < EventService.gI().events.Count; i++)
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					string query = $"SELECT * FROM ThamGiaSuKien WHERE IDSukien = {EventService.gI().events[i].ID}";

					SqlCommand command = new SqlCommand(query, connection);
					try
					{
						connection.Open();
						SqlDataReader reader = command.ExecuteReader();

						while (reader.Read())
						{
							EventService.gI().events[i].AddUserNoSql(UserService.gI().GetUserByUsername(reader["UsernameNguoiThamGia"].ToString()));
						}

						reader.Close();
					}
					catch (Exception ex)
					{
						Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
					}
					finally
					{
						connection.Close();
					}
				}
			}
		}
		internal List<InviteEvent> GetInvites()
		{
			List<InviteEvent> inviteEvents = new List<InviteEvent>();
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM LoiMoiSuKien";
				SqlCommand command = new SqlCommand(query, connection);
				try
				{
					connection.Open();
					SqlDataReader reader = command.ExecuteReader();
					while (reader.Read())
					{
						InviteEvent e = new InviteEvent
						{
							nguoiMoi = UserService.gI().GetUserByUsername(reader["UsernameNguoiMoi"].ToString()),
							nguoiNhan = UserService.gI().GetUserByUsername(reader["UsernameNguoiNhan"].ToString()),
							suKien = EventService.gI().GetEventInfo(int.Parse(reader["IdSuKien"].ToString()))
						};

						inviteEvents.Add(e);
					}

					reader.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
				}
				finally
				{
					connection.Close();
				}
			}
			return inviteEvents;
		}
		internal List<RequestEvent> GetRequests()
		{
			List<RequestEvent> requestEvents = new List<RequestEvent>();
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM YeuCauSuKien";
				SqlCommand command = new SqlCommand(query, connection);
				try
				{
					connection.Open();
					SqlDataReader reader = command.ExecuteReader();
					while (reader.Read())
					{
						RequestEvent e = new RequestEvent
						{
							nguoiYeuCau = UserService.gI().GetUserByUsername(reader["UsernameYeuCau"].ToString()),
							suKien = EventService.gI().GetEventInfo(int.Parse(reader["IdSuKien"].ToString()))
						};

						requestEvents.Add(e);
					}

					reader.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
				}
				finally
				{
					connection.Close();
				}
			}
			return requestEvents;
		}
		public bool ExecuteQuery(string query)
		{
			using(SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlCommand command = new SqlCommand(query, connection);
				try
				{
					connection.Open();
					command.ExecuteNonQuery();
					return true;
				}
				catch (Exception ex)
				{
					Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
					return false;
				}
				finally
				{
					connection.Close();
				}
			}
		}
	}
}
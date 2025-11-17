using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace academic_system
{
	public class UserRepository : IUserRepository
	{
		private string connStr = "Server=localhost; Database=academic_system; Uid=root; Pwd=;";

		public User GetByLogin(string login)
		{
			using (var conn = new MySqlConnection(connStr)) //connection string
			{
				conn.Open();
				string sql = "SELECT * FROM users WHERE login=@login LIMIT 1";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@login", login); //replacement
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							return new User
							{
								UserId = Convert.ToInt32(reader["user_id"]),
								Login = reader["login"].ToString(),
								Password = reader["password"].ToString(),
								Role = reader["role"].ToString()
							};
						}
					}
				}
			}
			return null;
		}

	 public void Add(User user)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "INSERT INTO users (login, password, role) VALUES (@login, @password, @role)";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@login", user.Login);
					cmd.Parameters.AddWithValue("@password", user.Password);
					cmd.Parameters.AddWithValue("@role", user.Role);
					cmd.ExecuteNonQuery();
				}
			}
		}

		public void Update(User user)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "UPDATE users SET login=@login, password=@password, role=@role WHERE user_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@login", user.Login);
					cmd.Parameters.AddWithValue("@password", user.Password);
					cmd.Parameters.AddWithValue("@role", user.Role);
					cmd.Parameters.AddWithValue("@id", user.UserId);
					cmd.ExecuteNonQuery();
				}
			}
		}

		public void Delete(int userId)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "DELETE FROM users WHERE user_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", userId);
					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}

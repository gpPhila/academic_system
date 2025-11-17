using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace academic_system
{
    public class TeacherRepository : ITeacherRepository
    {
		private string connStr = "Server=localhost; Database=academic_system; Uid=root; Pwd=;";
		public Teacher GetById(int teacherId)
		{
			using (var conn = new MySqlConnection(connStr)) //connection string
			{
				conn.Open();
				string sql = "SELECT * FROM teacher WHERE teacher_id=@id LIMIT 1";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", teacherId); //replacement
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							return new Teacher
							{
								TeacherId = Convert.ToInt32(reader["teacher_id"]),
								UserId = Convert.ToInt32(reader["user_id"]),
								FirstName = reader["first_name"].ToString(),
								LastName = reader["last_name"].ToString()
							};
						}
					}
				}
			}
			return null;
		}
		public Teacher GetByUserId(int userId)
		{
			using (var conn = new MySqlConnection(connStr)) //connection string
			{
				conn.Open();
				string sql = "SELECT * FROM teacher WHERE user_id=@id LIMIT 1";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", userId); //replacement
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							return new Teacher
							{
								TeacherId = Convert.ToInt32(reader["teacher_id"]),
								UserId = Convert.ToInt32(reader["user_id"]),
								FirstName = reader["first_name"].ToString(),
								LastName = reader["last_name"].ToString()
							};
						}
					}
				}
			}
			return null;
		}
		public void Add(Teacher teacher)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "INSERT INTO teacher (user_id, first_name, last_name) VALUES (@userId, @firstName, @lastName)";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@userId", teacher.UserId);
					cmd.Parameters.AddWithValue("@firstName", teacher.FirstName);
					cmd.Parameters.AddWithValue("@lastName", teacher.LastName);
					cmd.ExecuteNonQuery();
				}
			}
		}

		public void Update (Teacher teacher)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "UPDATE teacher SET user_id=@userId, first_name=@firstName, last_name=@lastName WHERE teacher_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@userId", teacher.UserId);
					cmd.Parameters.AddWithValue("@firstName", teacher.FirstName);
					cmd.Parameters.AddWithValue("@lastName", teacher.LastName);
					cmd.Parameters.AddWithValue("@id", teacher.TeacherId);
					cmd.ExecuteNonQuery();
				}
			}
		}

		public void Delete (int teacherId)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "DELETE FROM teacher WHERE teacher_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", teacherId);
					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}

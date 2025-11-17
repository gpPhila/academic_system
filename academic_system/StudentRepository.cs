using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace academic_system
{
	public class StudentRepository : IStudentRepository
	{
		private string connStr = "Server=localhost; Database=academic_system; Uid=root; Pwd=;";
		public Student GetById(int studentId)
		{
			using (var conn = new MySqlConnection(connStr)) //connection string
			{
				conn.Open();
				string sql = "SELECT * FROM student WHERE student_id=@id LIMIT 1";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", studentId); //replacement
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							return new Student
							{
								StudentId = Convert.ToInt32(reader["student_id"]),
								UserId = Convert.ToInt32(reader["user_id"]),
								GroupId = Convert.ToInt32(reader["group_id"]),
								FirstName = reader["first_name"].ToString(),
								LastName = reader["last_name"].ToString()
							};
						}
					}
				}
			}
			return null;
		}
		public Student GetByUserId(int userId)
		{
			using (var conn = new MySqlConnection(connStr)) //connection string
			{
				conn.Open();
				string sql = "SELECT * FROM student WHERE user_id=@id LIMIT 1";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", userId); //replacement
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							return new Student
							{
								StudentId = Convert.ToInt32(reader["student_id"]),
								UserId = Convert.ToInt32(reader["user_id"]),
								GroupId = Convert.ToInt32(reader["group_id"]),
								FirstName = reader["first_name"].ToString(),
								LastName = reader["last_name"].ToString()
							};
						}
					}
				}
			}
			return null;
		}
		public List<Student> GetByGroupId(int groupId)
		{
			List<Student> students = new List<Student>(); //all students belonging to the group in question

			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "SELECT * FROM student WHERE group_id=@id";

				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", groupId);

					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							students.Add(new Student
							{
								StudentId = Convert.ToInt32(reader["student_id"]),
								UserId = Convert.ToInt32(reader["user_id"]),
								GroupId = Convert.ToInt32(reader["group_id"]),
								FirstName = reader["first_name"].ToString(),
								LastName = reader["last_name"].ToString()
							});
						}
					}
				}
			}

			return students;
		}
		public void Add(Student student)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "INSERT INTO student (user_id, group_id, first_name, last_name) VALUES (@userId, @groupId, @firstName, @lastName)";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@userId", student.UserId);
					cmd.Parameters.AddWithValue("@groupId", student.GroupId);
					cmd.Parameters.AddWithValue("@firstName", student.FirstName);
					cmd.Parameters.AddWithValue("@lastName", student.LastName);
					cmd.ExecuteNonQuery();
				}
			}
		}
		public void Update(Student student)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "UPDATE student SET user_id=@userId, group_id=@groupId, first_name=@firstName, last_name=@lastName WHERE student_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@userId", student.UserId);
					cmd.Parameters.AddWithValue("@groupId", student.GroupId);
					cmd.Parameters.AddWithValue("@firstName", student.FirstName);
					cmd.Parameters.AddWithValue("@lastName", student.LastName);
					cmd.Parameters.AddWithValue("@id", student.StudentId);
					cmd.ExecuteNonQuery();
				}
			}
		}
		public void Delete(int studentId)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "DELETE FROM student WHERE student_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", studentId);
					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}

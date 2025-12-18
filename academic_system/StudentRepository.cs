using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace academic_system
{

	/// <summary>
	/// Tvarko studentų duomenis duomenų bazėje.
	/// </summary>
	public class StudentRepository : IStudentRepository
	{
		private string connStr = "Server=localhost; Database=academic_system; Uid=root; Pwd=;";

		/// <summary>
		/// Grąžina studentą pagal studento ID.
		/// </summary>
		public Student GetById(int studentId)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "SELECT * FROM student WHERE student_id=@id LIMIT 1";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", studentId);
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

		/// <summary>
		/// Grąžina studentą pagal naudotojo ID.
		/// </summary>
		public Student GetByUserId(int userId)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "SELECT * FROM student WHERE user_id=@id LIMIT 1";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", userId);
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

		/// <summary>
		/// Grąžina visus studentus pagal grupės ID.
		/// </summary>
		public List<Student> GetByGroupId(int groupId)
		{
			List<Student> students = new List<Student>();

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

		/// <summary>
		/// Grąžina visus studentus.
		/// </summary>
		public List<Student> GetAll()
		{
			List<Student> students = new List<Student>();

			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "SELECT * FROM student";

				using (var cmd = new MySqlCommand(sql, conn))
				{
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

		/// <summary>
		/// Prideda naują studentą į duomenų bazę.
		/// </summary>
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

		/// <summary>
		/// Atnaujina studento duomenis duomenų bazėje.
		/// </summary>
		public void Update(Student student)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "UPDATE student SET group_id=@groupId, first_name=@firstName, last_name=@lastName WHERE student_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@groupId", student.GroupId);
					cmd.Parameters.AddWithValue("@firstName", student.FirstName);
					cmd.Parameters.AddWithValue("@lastName", student.LastName);
					cmd.Parameters.AddWithValue("@id", student.StudentId);
					cmd.ExecuteNonQuery();
				}
			}
		}
		/// <summary>
		/// Ištrina studentą iš duomenų bazės.
		/// </summary>
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

		/// <summary>
		/// Priskiria studentą prie grupės.
		/// </summary>
		public void AssignStudentToGroup(int studentId, int groupId)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "UPDATE student SET group_id = @groupId WHERE student_id = @studentId";

				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@studentId", studentId);
					cmd.Parameters.AddWithValue("@groupId", groupId);
					cmd.ExecuteNonQuery();
				}
			}
		}

		/// <summary>
		/// Grąžina studentų sąrašą pagal grupę lentelės formatu.
		/// </summary>
		public DataTable GetStudentsByGroupId(int groupId)
		{
			var table = new DataTable();

			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();

				using (var cmd = new MySqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"
					SELECT 
                    student_id AS StudentId,
                    CONCAT(first_name, ' ', last_name) AS FullName
					FROM student
					WHERE group_id = @groupId
					";

					cmd.Parameters.AddWithValue("@groupId", groupId);

					using (var adapter = new MySqlDataAdapter(cmd))
					{
						adapter.Fill(table);
					}
				}
			}
			return table;
		}

	}
}

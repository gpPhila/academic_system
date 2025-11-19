using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace academic_system
{
	public class SubjectRepository : ISubjectRepository
	{
		private string connStr = "Server=localhost; Database=academic_system; Uid=root; Pwd=;";
		public Subject GetById(int subjectId)
		{
			using (var conn = new MySqlConnection(connStr)) //connection string
			{
				conn.Open();
				string sql = "SELECT * FROM subject WHERE subject_id=@id LIMIT 1";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", subjectId); //replacement
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							return new Subject
							{
								SubjectId = Convert.ToInt32(reader["subject_id"]),
								TeacherId = Convert.ToInt32(reader["teacher_id"]),
								Name = reader["name_of_subject"].ToString(),
								Description = reader["description"].ToString()
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
		public void Add(Subject subject)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "INSERT INTO subject (subject_id, teacher_id, name_of_subject, description) VALUES (@subjectId, @teacherId, @nameOfSubject, @description)";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@subjectId", subject.SubjectId);
					cmd.Parameters.AddWithValue("@teacherId", subject.TeacherId);
					cmd.Parameters.AddWithValue("@nameOfSubject", subject.Name);
					cmd.Parameters.AddWithValue("@description", subject.Description);
					cmd.ExecuteNonQuery();
				}
			}
		}
		public void Update(Subject subject)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "UPDATE subject SET teacher_id=@teacherId, name_of_subject=@nameOfSubject, description=@description WHERE subject_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@teacherId", subject.TeacherId);
					cmd.Parameters.AddWithValue("@nameOfSubject", subject.Name);
					cmd.Parameters.AddWithValue("@description", subject.Description);
					cmd.Parameters.AddWithValue("@id", subject.SubjectId);
					cmd.ExecuteNonQuery();
				}
			}
		}
		public void Delete(int subjectId)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "DELETE FROM subject WHERE subject_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", subjectId);
					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}

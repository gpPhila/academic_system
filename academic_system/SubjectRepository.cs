using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
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

		public List<Subject> GetAll()
		{
			List <Subject> subjects = new List <Subject> ();

			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "SELECT * FROM subject";

				using (var cmd = new MySqlCommand(sql, conn))
				{
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							subjects.Add(new Subject
							{
								SubjectId = Convert.ToInt32(reader["subject_id"]),
								TeacherId = Convert.ToInt32(reader["teacher_id"]),
								Name = reader["name_of_subject"].ToString(),
								Description = reader["description"].ToString()
							});
						}
					}
				}
			}
		return subjects;
 		}
		public List<Subject> GetByTeacherId(int teacherId)
		{
			List<Subject> subjects = new List<Subject>();

			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "SELECT * FROM subject WHERE teacher_id=@id";

				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", teacherId);

					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							subjects.Add(new Subject
							{
								SubjectId = Convert.ToInt32(reader["subject_id"]),
								TeacherId = Convert.ToInt32(reader["teacher_id"]),
								Name = reader["name_of_subject"].ToString(),
								Description = reader["description"].ToString()
							});
						}
					}
				}
			}
			return subjects;
		}
		public void Add(Subject subject)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "INSERT INTO subject (teacher_id, name_of_subject, description) VALUES (@teacherId, @nameOfSubject, @description)";
				using (var cmd = new MySqlCommand(sql, conn))
				{
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
		public void AssignTeacherToSubject(int subjectId, int teacherId)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "UPDATE subject SET teacher_id = @teacherId WHERE subject_id = @subjectId";

				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@teacherId", teacherId);
					cmd.Parameters.AddWithValue("@subjectId", subjectId);
					cmd.ExecuteNonQuery();
				}
			}
		}

		public DataTable GetSubjectsByGroupAndTeacher(int groupId, int teacherId)
		{
			var table = new DataTable();

			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();

				using (var cmd = new MySqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = @"
					SELECT DISTINCT
                    s.subject_id AS SubjectId,
                    s.name_of_subject AS SubjectName
					FROM `groups` g
					JOIN group_of_subjects gos 
                    ON gos.gos_id = g.gos_id
					JOIN group_of_subjects_subject goss
                    ON goss.gos_id = gos.gos_id
					JOIN subject s
                    ON s.subject_id = goss.subject_id
					WHERE g.group_id = @groupId
					AND s.teacher_id = @teacherId
					";

					cmd.Parameters.AddWithValue("@groupId", groupId);
					cmd.Parameters.AddWithValue("@teacherId", teacherId);

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


using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace academic_system
{
    public class GradeRepository : IGradeRepository
    {
		private string connStr = "Server=localhost; Database=academic_system; Uid=root; Pwd=;";
		public Grade GetById(int gradeId)
        {
			using (var conn = new MySqlConnection(connStr)) //connection string
			{
				conn.Open();
				string sql = "SELECT * FROM grade WHERE grade_id=@id LIMIT 1";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", gradeId); //replacement
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							return new Grade
							{
								GradeId = Convert.ToInt32(reader["grade_id"]),
								StudentId = Convert.ToInt32(reader["student_id"]),
								SubjectId = Convert.ToInt32(reader["subject_id"]),
								TeacherId = Convert.ToInt32(reader["teacher_id"]),
								Value = reader["value"].ToString()
							};
						}
					}
				}
			}
			return null;
        }
		public List<Grade> GetByStudentId(int studentId)
		{
			List<Grade> grades = new List<Grade>();

			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "SELECT * FROM grade WHERE student_id=@id";

				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", studentId);

					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							grades.Add(new Grade
							{
								GradeId = Convert.ToInt32(reader["grade_id"]),
								StudentId = Convert.ToInt32(reader["student_id"]),
								SubjectId = Convert.ToInt32(reader["subject_id"]),
								TeacherId = Convert.ToInt32(reader["teacher_id"]),
								Value = reader["value"].ToString()
							});
						}
					}
				}
			}
			return grades;
		}
		public void Add(Grade grade)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "INSERT INTO grade (student_id, subject_id, teacher_id, value) VALUES (@studentId, @subjectId, @teacherId, @value)";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@studentId", grade.StudentId);
					cmd.Parameters.AddWithValue("@subjectId", grade.SubjectId);
					cmd.Parameters.AddWithValue("@teacherId", grade.TeacherId);
					cmd.Parameters.AddWithValue("@value", grade.Value);
					cmd.ExecuteNonQuery();
				}
			}
		}
		public void Update(Grade grade)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "UPDATE grade SET student_id=@studentId, subject_id=@subjectId, teacher_id=@teacherId, value=@value WHERE grade_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@studentId", grade.StudentId);
					cmd.Parameters.AddWithValue("@subjectId", grade.SubjectId);
					cmd.Parameters.AddWithValue("@teacherId", grade.TeacherId);
					cmd.Parameters.AddWithValue("@value", grade.Value);
					cmd.Parameters.AddWithValue("@id", grade.GradeId);
					cmd.ExecuteNonQuery();
				}
			}
		}
		public void Delete(int gradeId)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "DELETE FROM grade WHERE grade_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", gradeId);
					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace academic_system
{

	/// <summary>
	/// Tvarko pažymių duomenis duomenų bazėje.
	/// </summary>
	public class GradeRepository : IGradeRepository
    {
		private string connStr = "Server=localhost; Database=academic_system; Uid=root; Pwd=;";

		/// <summary>
		/// Grąžina pažymį pagal jo ID.
		/// </summary>
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

		/// <summary>
		/// Grąžina pažymius pagal studentą ir dalyką.
		/// </summary>
		public List<Grade> GetByStudentAndSubject(int studentId, int subjectId)
		{
			List<Grade> grades = new List<Grade>();

			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "SELECT * FROM grade WHERE student_id=@studentId AND subject_id=@subjectId";

					using (var cmd = new MySqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@studentId", studentId);
						cmd.Parameters.AddWithValue("@subjectId", subjectId);

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

		/// <summary>
		/// Grąžina pažymius pagal dėstytoją.
		/// </summary>
		public List<Grade> GetByTeacherId(int teacherId)
		{
			List<Grade> grades = new List<Grade>();

			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "SELECT * FROM grade WHERE teacher_id=@id";

				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", teacherId);

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

		/// <summary>
		/// Prideda naują pažymį prie duomenų bazės.
		/// </summary>
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

		/// <summary>
		/// Atnaujina pažymio duomenis duomenų bazėje.
		/// </summary>
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

		/// <summary>
		/// Ištrina pažymį iš duomenų bazės.
		/// </summary>
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

		/// <summary>
		/// Atnaujina pažymio vertę duomenų bazėje.
		/// </summary>
		public void UpdateValue(int gradeId, string newValue)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "UPDATE `grade` SET `value`=@value WHERE `grade_id`=@gradeId";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@value", newValue);
					cmd.Parameters.AddWithValue("@gradeId", gradeId);
					cmd.ExecuteNonQuery();
				}
			}
		}

		/// <summary>
		/// Grąžina pažymių sąrašą lentelės formatu.
		/// </summary>
		public DataTable GetGrades(int studentId, int subjectId, int teacherId)
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
                    grade_id AS GradeId,
                    value AS Grade
					FROM grade
					WHERE student_id = @studentId
					AND subject_id = @subjectId
					AND teacher_id = @teacherId
					";

					cmd.Parameters.AddWithValue("@studentId", studentId);
					cmd.Parameters.AddWithValue("@subjectId", subjectId);
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

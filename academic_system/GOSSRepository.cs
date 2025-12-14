using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace academic_system
{
	public class GOSSRepository : IGOSSRepository
	{
		private string connStr = "Server=localhost; Database=academic_system; Uid=root; Pwd=;";
		public GOS_Subject GetById(int gossId)
		{
			using (var conn = new MySqlConnection(connStr)) //connection string
			{
				conn.Open();
				string sql = "SELECT * FROM group_of_subjects_subject WHERE goss_id=@id LIMIT 1";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", gossId); //replacement
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							return new GOS_Subject
							{
								GossId = Convert.ToInt32(reader["goss_id"]),
								GosId = Convert.ToInt32(reader["gos_id"]),
								SubjectId = Convert.ToInt32(reader["subject_id"])
							};
						}
					}
				}
			}
			return null;
		}

		public void Add(GOS_Subject goss)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "INSERT INTO group_of_subjects_subject (gos_id, subject_id) VALUES (@gosId, @subjectId)";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@gosId", goss.GosId);
					cmd.Parameters.AddWithValue("@subjectId", goss.SubjectId);
					cmd.ExecuteNonQuery();
				}
			}
		}
		public void Update(GOS_Subject goss)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "UPDATE group_of_subjects_subject SET gos_id=@gosId, subject_id=@subjectId WHERE goss_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@gosId", goss.GosId);
					cmd.Parameters.AddWithValue("@subjectId", goss.SubjectId);
					cmd.Parameters.AddWithValue("@id", goss.GossId);
					cmd.ExecuteNonQuery();
				}
			}
		}
		public void Delete(int GOSSId)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "DELETE FROM group_of_subjects_subject WHERE goss_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", GOSSId);
					cmd.ExecuteNonQuery();
				}
			}
		}
		public List<GOS_Subject> GetAll()
		{
			var result = new List<GOS_Subject>();

			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "SELECT * FROM group_of_subjects_subject";

				using (var cmd = new MySqlCommand(sql, conn))
				{
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							result.Add(new GOS_Subject
							{
								GossId = Convert.ToInt32(reader["goss_id"]),
								GosId = Convert.ToInt32(reader["gos_id"]),
								SubjectId = Convert.ToInt32(reader["subject_id"]),
							});
						}
					}
				}
			}

			return result;
		}
		public List<GOS_Subject> GetByGosId(int gosId)
		{
			var result = new List<GOS_Subject>();
			using (var conn = new MySqlConnection(connStr)) //connection string
			{
				conn.Open();
				string sql = "SELECT * FROM group_of_subjects_subject WHERE gos_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", gosId); //replacement
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							result.Add (new GOS_Subject
							{
								GossId = Convert.ToInt32(reader["goss_id"]),
								GosId = Convert.ToInt32(reader["gos_id"]),
								SubjectId = Convert.ToInt32(reader["subject_id"])
							});
						}
					}
				}
			return result;
			}
		}
		public DataTable GetByGosIdWithSubjectName(int gosId)
		{
			var table = new DataTable();

			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();

				string sql = @"
				SELECT 
				goss.goss_id,
				goss.gos_id,
				goss.subject_id,
				s.name_of_subject AS SubjectName
				FROM group_of_subjects_subject goss
				JOIN subject s ON s.subject_id = goss.subject_id
				WHERE goss.gos_id = @gosId
				";

				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@gosId", gosId);

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

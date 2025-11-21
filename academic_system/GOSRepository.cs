using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace academic_system
{
    public class GOSRepository : IGOSRepository
    {
		private string connStr = "Server=localhost; Database=academic_system; Uid=root; Pwd=;";
		public GroupOfSubjects GetById(int gosId)
		{
			using (var conn = new MySqlConnection(connStr)) //connection string
			{
				conn.Open();
				string sql = "SELECT * FROM group_of_subjects WHERE gos_id=@id LIMIT 1";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", gosId); //replacement
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							return new GroupOfSubjects
							{
								GOSId = Convert.ToInt32(reader["gos_id"]),
								GroupId = Convert.ToInt32(reader["group_id"]),
								SubjectId = Convert.ToInt32(reader["subject_id"]),
							};
						}
					}
				}
			}
			return null;
		}

		public GroupOfSubjects GetByGroupId(int groupId)
		{
			using (var conn = new MySqlConnection(connStr)) //connection string
			{
				conn.Open();
				string sql = "SELECT * FROM group_of_subjects WHERE group_id=@id LIMIT 1";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", groupId); //replacement
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							return new GroupOfSubjects
							{
								GOSId = Convert.ToInt32(reader["gos_id"]),
								GroupId = Convert.ToInt32(reader["group_id"]),
								SubjectId = Convert.ToInt32(reader["subject_id"]),
							};
						}
					}
				}
			}
			return null;
		}
		public void Add(GroupOfSubjects gos)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "INSERT INTO group_of_subjects (group_id, subject_id) VALUES (@groupId, @subjectId)";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@groupId", gos.GroupId);
					cmd.Parameters.AddWithValue("@subjectId", gos.SubjectId);
					cmd.ExecuteNonQuery();
				}
			}
		}
		public void Update(GroupOfSubjects gos)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "UPDATE group_of_subjects SET group_id=@groupId, subject_id=@subjectId WHERE gos_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@groupId", gos.GroupId);
					cmd.Parameters.AddWithValue("@subjectId", gos.SubjectId);
					cmd.Parameters.AddWithValue("@id", gos.GOSId);
					cmd.ExecuteNonQuery();
				}
			}
		}
		public void Delete(int GOSId)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "DELETE FROM group_of_subjects WHERE gos_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", GOSId);
					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}

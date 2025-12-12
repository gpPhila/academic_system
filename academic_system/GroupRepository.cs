using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace academic_system
{
    public class GroupRepository : IGroupRepository
    {
		private string connStr = "Server=localhost; Database=academic_system; Uid=root; Pwd=;";
		public Group GetById(int groupId)
		{
			using (var conn = new MySqlConnection(connStr)) //connection string
			{
				conn.Open();
				string sql = "SELECT * FROM `groups` WHERE group_id=@id LIMIT 1";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", groupId); //replacement
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							return new Group
							{
								GroupId = Convert.ToInt32(reader["group_id"]),
								Name = reader["name"].ToString(),
								GosId = reader["gos_id"] == DBNull.Value ? null
								: (int?)Convert.ToInt32(reader["gos_id"])
							};
						}
					}
				}
			}
			return null;
		}
		public List<Group> GetAll()
		{
			List<Group> groups = new List<Group>();

			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "SELECT * FROM `groups`";

				using (var cmd = new MySqlCommand(sql, conn))
				{
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							groups.Add(new Group
							{
								GroupId = Convert.ToInt32(reader["group_id"]),
								Name = reader["name"].ToString(),
								GosId = reader["gos_id"] == DBNull.Value ? null
								: (int?)Convert.ToInt32(reader["gos_id"])
							});
						}
					}
				}
			}
			return groups;
		}
		public void Add(Group group)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "INSERT INTO `groups` (name, gos_id) VALUES (@name, @gosId)";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@name", group.Name);
					cmd.Parameters.AddWithValue("@gosId", group.GosId.HasValue
						? (object)group.GosId.Value : DBNull.Value);
					cmd.ExecuteNonQuery();
				}
			}
		}
		public void Update(Group group)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "UPDATE `groups` SET name=@name, gos_id=@gosId WHERE group_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@name", group.Name);
					cmd.Parameters.AddWithValue("@gosId", group.GosId.HasValue
						? (object)group.GosId.Value : DBNull.Value);
					cmd.Parameters.AddWithValue("@id", group.GroupId);

					cmd.ExecuteNonQuery();
				}
			}
		}
		public void Delete(int groupId)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "DELETE FROM `groups` WHERE group_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", groupId);
					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}
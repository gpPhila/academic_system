using System;
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
				string sql = "SELECT * FROM groups WHERE group_id=@id LIMIT 1";
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
							};
						}
					}
				}
			}
			return null;
		}
		public void Add(Group group)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "INSERT INTO groups (name) VALUES (@name)";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@name", group.Name);
					cmd.ExecuteNonQuery();
				}
			}
		}
		public void Update(Group group)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "UPDATE groups SET name=@name WHERE group_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@name", group.Name);
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
				string sql = "DELETE FROM groups WHERE group_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", groupId);
					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}

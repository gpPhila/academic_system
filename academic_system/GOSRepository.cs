using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace academic_system
{

	/// <summary>
	/// Tvarko dalykų grupių duomenis duomenų bazėje.
	/// </summary>
	public class GOSRepository : IGOSRepository
	{
		private string connStr = "Server=localhost; Database=academic_system; Uid=root; Pwd=;";

		/// <summary>
		/// Grąžina dalykų grupę pagal jos ID.
		/// </summary>
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
								Name = reader["gos_name"].ToString()
							};
						}
					}
				}
			}
			return null;
		}

		/// <summary>
		/// Prideda naują dalykų grupę prie duomenų bazės.
		/// </summary>
		public void Add(GroupOfSubjects gos)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "INSERT INTO group_of_subjects (gos_name) VALUES (@gosName)";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@gosName", gos.Name);
					cmd.ExecuteNonQuery();
				}
			}
		}

		/// <summary>
		/// Atnaujina dalykų grupės duomenis duomenų bazėje.
		/// </summary>
		public void Update(GroupOfSubjects gos)
		{
			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "UPDATE group_of_subjects SET gos_name=@gosName WHERE gos_id=@id";
				using (var cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@gosName", gos.Name);
					cmd.Parameters.AddWithValue("@id", gos.GOSId);
					cmd.ExecuteNonQuery();
				}
			}
		}

		/// <summary>
		/// Ištrina dalykų grupę iš duomenų bazės.
		/// </summary>
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

		/// <summary>
		/// Grąžina visas dalykų grupes.
		/// </summary>
		public List<GroupOfSubjects> GetAll()
		{
			var result = new List<GroupOfSubjects>();

			using (var conn = new MySqlConnection(connStr))
			{
				conn.Open();
				string sql = "SELECT * FROM group_of_subjects";

				using (var cmd = new MySqlCommand(sql, conn))
				{
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							result.Add(new GroupOfSubjects
							{
								GOSId = Convert.ToInt32(reader["gos_id"]),
								Name = reader["gos_name"].ToString()
							});
						}
					}
				}
			}

			return result;
		}
	}	
}

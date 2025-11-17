using MySql.Data.MySqlClient;

public static class DBConnection
{
	public static MySqlConnection GetConnection()
	{
		string connStr = "Server=localhost; Database=academic_system; Uid=root; Pwd=;";
		return new MySqlConnection(connStr);
	}
}

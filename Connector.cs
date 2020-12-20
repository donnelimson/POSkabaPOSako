using System;
using MySql.Data.MySqlClient;
namespace Connector
{
	public class Connector
	{
		public void ConnectDatabase()
		{
			MySqlConnection connection;
			MySqlCommand command;
			string path = "Data Source=LOCALHOST;Initial Catalog=DCERES;user=root;password=''";
			connection = new MySqlConnection(path);
			connection.Open();

		}
	}
}

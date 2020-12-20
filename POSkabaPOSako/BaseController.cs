using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

public class BaseController:Form
{
	public void ConnectDatabase()
	{
		MySqlConnection connection;
		string path = "Data Source=LOCALHOST;Initial Catalog=pos;user=root;password=''";
		connection = new MySqlConnection(path);
		connection.Open();
	}
	
}

using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace UAS_PV
{
	public class Connection
	{
		// Default_DB db_info = new Default_DB();
		public Default_DB db_info = Default_DB.Instance;
		
		public Connection()
		{
		}
		
		public MySqlConnection getconn()
		{
			MySqlConnection conn = new MySqlConnection("Server = " + db_info.host
			                                          + ";Database = " + db_info.db
			                                          + ";User = " + db_info.usr);
			return conn;
		}
	}
}

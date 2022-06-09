using System;

namespace UAS_PV
{
	public sealed class Default_DB
	{
		
		
		public static Default_DB Instance {
			get {
				return instance;
			}
		}
		
		public string host, db, usr, pass;
		
		private static Default_DB instance = new Default_DB();
		
		private Default_DB()
		{
			host = "localhost";
			db = "uas_pv";
			usr = "root";
			pass = "";
		}
		
		private void edit_db(string h, string d, string u, string p)
		{
			this.host = h;
			this.db = d;
			this.usr = u;
			this.pass = p;
		}
		
	}
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace UAS_PV
{
	public partial class MainForm : Form
	{
		Connection connection = new Connection();
		Edit_Connection edit = new Edit_Connection();
		Dashboard dashboard = new Dashboard();
		Result res = new Result();
		public MainForm()
		{
			InitializeComponent();
		}
		
		
		void ConnectToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (edit.changed)
			{
				connection.db_info.host = edit.host;
				connection.db_info.db = edit.db;
				connection.db_info.usr = edit.usr;
				connection.db_info.pass = edit.pass;
				edit.changed = false;
			}
			
			MySqlConnection conn = connection.getconn();
			try
			{
				conn.Open();
				MessageBox.Show("berhasil");
				
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error" + ex);
			}
			finally
			{
				conn.Close();
			}
		}
		
		void EditToolStripMenuItemClick(object sender, EventArgs e)
		{
			edit.MdiParent = this;
			edit.Show();
			
		}
		
		/* Dashboard */
		void DashboardToolStripMenuItemClick(object sender, EventArgs e)
		{
			dashboard.MdiParent = this;
			dashboard.Show();
		}
		
		void ReadmeToolStripMenuItemClick(object sender, EventArgs e)
		{
			readme read = new readme();
			read.MdiParent = this;
			read.Show();
		}
		
		void ResultToolStripMenuItemClick(object sender, EventArgs e)
		{
			MySqlConnection conn = connection.getconn();
			MySqlCommand cmd;
			cmd = new MySqlCommand("insert into raw values ('" + DateTime.Now + "','"
			                       								+(dashboard.bau) + "','"
														        +int.Parse(dashboard.tds) + "','"
														        +double.Parse(dashboard.raksa) + "','"
														        +double.Parse(dashboard.arsen) + "','"
														        +double.Parse(dashboard.mbas) + "','"
														        +double.Parse(dashboard.kmn) + "','"
														        +int.Parse(dashboard.coliform) + "','"
														        +int.Parse(dashboard.ecoli) + "')", conn);
			cmd.ExecuteNonQuery();
			res.MdiParent = this;
			res.cin(dashboard.bau, 
			        int.Parse(dashboard.tds), 
			        double.Parse(dashboard.raksa), 
			        double.Parse(dashboard.arsen), 
			        double.Parse(dashboard.mbas), 
			        double.Parse(dashboard.kmn),
			        int.Parse(dashboard.coliform), 
			        int.Parse(dashboard.ecoli));
			res.calc();
			res.res();
			res.Show();
		}
		
		void InformationToolStripMenuItemClick(object sender, EventArgs e)
		{
			Information info = new Information();	
			info.Show();
		}
	}
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace UAS_PV
{
	public partial class Information : Form
	{
		DataSet ds;
		MySqlCommand cmd;
		MySqlDataAdapter da;
		Connection connection = new Connection();
		
		public Information()
		{
			InitializeComponent();
		}
		
		public void refs()
		{
			
			MySqlConnection conn = connection.getconn();
			try
			{
				conn.Open();
				cmd = new MySqlCommand("select * from raw", conn);
				ds = new DataSet();
				da = new MySqlDataAdapter(cmd);
				da.Fill(ds, "raw");
				dgs.DataSource = ds;
				dgs.DataMember = "raw";
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
		
		void RefreshClick(object sender, EventArgs e)
		{
			refs();
		}
		
		void DgsCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				form_clean();
				date_in.Text = dgs.Rows[e.RowIndex].Cells[0].Value.ToString();
				bau_in.Text = dgs.Rows[e.RowIndex].Cells[1].Value.ToString();
				tds_in.Text = dgs.Rows[e.RowIndex].Cells[2].Value.ToString();
				raksa_in.Text = dgs.Rows[e.RowIndex].Cells[3].Value.ToString();
				arsen_in.Text = dgs.Rows[e.RowIndex].Cells[4].Value.ToString();
				mbas_in.Text = dgs.Rows[e.RowIndex].Cells[5].Value.ToString();
				kmn_in.Text = dgs.Rows[e.RowIndex].Cells[6].Value.ToString();
				coliform_in.Text = dgs.Rows[e.RowIndex].Cells[7].Value.ToString();
				ecoli_in.Text = dgs.Rows[e.RowIndex].Cells[8].Value.ToString();
			}
		}
		
		void form_clean()
		{
			date_in.Text = "";
			bau_in.Text = "";
			tds_in.Text = "";
			raksa_in.Text = "";
			arsen_in.Text = "";
			mbas_in.Text = "";
			kmn_in.Text = "";
			coliform_in.Text = "";
			ecoli_in.Text = "";
		}
		
		void GoClick(object sender, EventArgs e)
		{
			MySqlConnection conn = connection.getconn();
			try
			{
				conn.Open();
				cmd = new MySqlCommand("select * from raw where date like '%" + search.Text + "%'", conn);
				ds = new DataSet();
				da = new MySqlDataAdapter(cmd);
				da.Fill(ds, "raw");
				dgs.DataSource = ds;
				dgs.DataMember = "raw";
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}			
		}
		
		void ResetClick(object sender, EventArgs e)
		{
			form_clean();
		}
		
		void DeleteClick(object sender, EventArgs e)
		{
			MySqlConnection conn = connection.getconn();
			try
			{
				conn.Open();
				cmd = new MySqlCommand("delete from raw where date =" + date_in.Text + "'", conn);
				cmd.ExecuteNonQuery();
				form_clean();
				refs();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}				
		}
		
		void InsertClick(object sender, EventArgs e)
		{
			MySqlConnection conn = connection.getconn();
			try
			{
				conn.Open();
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
				form_clean();
				refs();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}				
		}
	}
}

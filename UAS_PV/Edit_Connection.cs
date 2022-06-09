using System;
using System.Drawing;
using System.Windows.Forms;

namespace UAS_PV
{
	public partial class Edit_Connection : Form
	{
		public bool changed = false;
		public bool isClosed = false;
		public string host, db, usr, pass;
		public Edit_Connection()
		{
			host = "";
			db = "";
			usr = "";
			pass = "";
			InitializeComponent();
		}
		
		/* submit button */		
		void Button1Click(object sender, EventArgs e)
		{
			host = h.Text;
			db = d.Text;
			usr = u.Text;
			pass = p.Text;
			changed = true;
			isClosed = true;
			this.Close();

		}
		/* reset button */
		void Button2Click(object sender, EventArgs e)
		{
			reset();
		}
		
		void reset()
		{
			h.Text = "";
			d.Text = "";
			u.Text = "";
			p.Text = "";
		}

	}
}

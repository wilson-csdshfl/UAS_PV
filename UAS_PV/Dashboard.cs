using System;
using System.Drawing;
using System.Windows.Forms;

namespace UAS_PV
{
	public partial class Dashboard : Form
	{
		public string bau, tds, raksa, arsen, mbas, kmn, coliform, ecoli;
		public Dashboard()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex != -1
			    || tds_in.Text != ""
			    || raksa_in.Text != ""
			    || arsen_in.Text != ""
			    || mbas_in .Text != ""
			    || kmn_in.Text != ""
			    || coliform_in.Text != ""
			    || ecoli_in.Text != "")
			{
				bau = comboBox1.SelectedItem.ToString();
				tds = tds_in.Text;
				raksa = raksa_in.Text;
				arsen = arsen_in.Text;
				mbas = mbas_in.Text;
				kmn = kmn_in.Text;
				coliform = coliform_in.Text;
				ecoli = ecoli_in.Text;
			}
			else
			{
				MessageBox.Show("Input Not Supported");
			}
			this.Close();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			reset();
		}
		
		void reset()
		{
			comboBox1.SelectedIndex = -1;
			tds_in.Text = "";
			raksa_in.Text = "";
			arsen_in.Text = "";
			mbas_in.Text = "";
			kmn_in.Text = "";
			coliform_in.Text = "";
			ecoli_in.Text = "";
		}
		
	}
}

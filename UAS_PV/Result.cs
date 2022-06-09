using System;
using System.Drawing;
using System.Windows.Forms;

namespace UAS_PV
{
	public partial class Result : Form
	{
		public string bau; 
		public int tds, coliform, ecoli;
		public double raksa, arsen, mbas, kmn;
		
		private bool tof_bau = false, tof_tds = false, tof_coliform = false, tof_ecoli = false, tof_raksa = false, tof_arsen = false, tof_mbas = false, tof_kmn = false;
		public Result()
		{
			InitializeComponent();
			calc();
		}
		
		public void cin(string bau_in, int tds_in, double raksa_in, double arsen_in, double mbas_in, double kmn_in, int coliform_in, int ecoli_in)
		{
			bau = bau_in;
			tds = tds_in;
			raksa = raksa_in;
			arsen = arsen_in;
			mbas = mbas_in;
			kmn = kmn_in;
			coliform = coliform_in;
			ecoli = ecoli_in;
		}
		
		public void calc()
		{
			if (bau == "BERBAU")
			{
				tof_bau = true;
			}
			if (tds >= 5)
			{
				tof_tds = true;
			}
			if (raksa >= 0.001)
			{
				tof_raksa = true;
			}
			if (arsen >= 0.005)
			{
				tof_arsen = true;
			}
			if (mbas >= 0.005)
			{
				tof_mbas = true;
			}
			if (kmn >= 10)
			{
				tof_kmn = true;
			}
			if (coliform >= 50)
			{
				tof_coliform = true;
			}
			if (ecoli > 0)
			{
				tof_ecoli = true;
			}
		}
		public void res()
		{
			if (tof_bau
			    || tof_tds
			    || tof_raksa
			    || tof_arsen
			    || tof_mbas
			    || tof_kmn
			    || tof_coliform
			    || tof_ecoli)
			{
				label13.Text = "AIR TIDAK LAYAK UNTUK DIMINUM";
				label13.ForeColor = Color.Red;
			}
			else
			{
				label13.Text = "AIR LAYAK UNTUK DIMINUM";
				label13.ForeColor = Color.Black;
			}
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: slim
 * Date: 6/9/2022
 * Time: 5:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UAS_PV
{
	partial class Dashboard
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tds_in = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.kmn_in = new System.Windows.Forms.TextBox();
			this.mbas_in = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.arsen_in = new System.Windows.Forms.TextBox();
			this.raksa_in = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.coliform_in = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.ecoli_in = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tds_in);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(345, 84);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "FISIKA";
			// 
			// tds_in
			// 
			this.tds_in.Location = new System.Drawing.Point(181, 49);
			this.tds_in.Name = "tds_in";
			this.tds_in.Size = new System.Drawing.Size(121, 20);
			this.tds_in.TabIndex = 5;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"BERBAU",
									"TIDAK BERBAU"});
			this.comboBox1.Location = new System.Drawing.Point(181, 22);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(90, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "mg/l";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(90, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "-";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(21, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "TDS";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(21, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "BAU";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.groupBox4);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Location = new System.Drawing.Point(12, 102);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(345, 248);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "KIMIA";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.kmn_in);
			this.groupBox4.Controls.Add(this.mbas_in);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Location = new System.Drawing.Point(21, 135);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(301, 100);
			this.groupBox4.TabIndex = 11;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Organik";
			// 
			// kmn_in
			// 
			this.kmn_in.Location = new System.Drawing.Point(162, 48);
			this.kmn_in.Name = "kmn_in";
			this.kmn_in.Size = new System.Drawing.Size(121, 20);
			this.kmn_in.TabIndex = 10;
			// 
			// mbas_in
			// 
			this.mbas_in.Location = new System.Drawing.Point(162, 19);
			this.mbas_in.Name = "mbas_in";
			this.mbas_in.Size = new System.Drawing.Size(121, 20);
			this.mbas_in.TabIndex = 6;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(103, 48);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(85, 23);
			this.label9.TabIndex = 9;
			this.label9.Text = "mg/l";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(103, 25);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(85, 23);
			this.label10.TabIndex = 8;
			this.label10.Text = "mg/l";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(21, 48);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 23);
			this.label11.TabIndex = 7;
			this.label11.Text = "KMnO4";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(21, 25);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(85, 23);
			this.label12.TabIndex = 6;
			this.label12.Text = "MBAS";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.arsen_in);
			this.groupBox3.Controls.Add(this.raksa_in);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Location = new System.Drawing.Point(21, 29);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(301, 100);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "An Organik";
			// 
			// arsen_in
			// 
			this.arsen_in.Location = new System.Drawing.Point(162, 48);
			this.arsen_in.Name = "arsen_in";
			this.arsen_in.Size = new System.Drawing.Size(121, 20);
			this.arsen_in.TabIndex = 10;
			// 
			// raksa_in
			// 
			this.raksa_in.Location = new System.Drawing.Point(162, 19);
			this.raksa_in.Name = "raksa_in";
			this.raksa_in.Size = new System.Drawing.Size(121, 20);
			this.raksa_in.TabIndex = 6;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(103, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 23);
			this.label8.TabIndex = 9;
			this.label8.Text = "mg/l";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(103, 25);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 23);
			this.label7.TabIndex = 8;
			this.label7.Text = "mg/l";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(21, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 23);
			this.label6.TabIndex = 7;
			this.label6.Text = "ARSEN";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(21, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "AIR RAKSA";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.coliform_in);
			this.groupBox5.Controls.Add(this.label17);
			this.groupBox5.Controls.Add(this.ecoli_in);
			this.groupBox5.Controls.Add(this.label14);
			this.groupBox5.Controls.Add(this.label15);
			this.groupBox5.Controls.Add(this.label16);
			this.groupBox5.Location = new System.Drawing.Point(12, 356);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(345, 84);
			this.groupBox5.TabIndex = 6;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "BIOLOGI";
			// 
			// coliform_in
			// 
			this.coliform_in.Location = new System.Drawing.Point(183, 26);
			this.coliform_in.Name = "coliform_in";
			this.coliform_in.Size = new System.Drawing.Size(121, 20);
			this.coliform_in.TabIndex = 7;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(90, 49);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(85, 23);
			this.label17.TabIndex = 6;
			this.label17.Text = "CFU/100ml";
			// 
			// ecoli_in
			// 
			this.ecoli_in.Location = new System.Drawing.Point(183, 49);
			this.ecoli_in.Name = "ecoli_in";
			this.ecoli_in.Size = new System.Drawing.Size(121, 20);
			this.ecoli_in.TabIndex = 5;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(90, 29);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(85, 23);
			this.label14.TabIndex = 2;
			this.label14.Text = "CFU/100ml";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(21, 52);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(85, 23);
			this.label15.TabIndex = 1;
			this.label15.Text = "E. Coli";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(21, 29);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(85, 23);
			this.label16.TabIndex = 0;
			this.label16.Text = "Tot. Coliform";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(193, 465);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "SUBMIT";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(274, 465);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "RESET";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 500);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Dashboard";
			this.Text = "Dashboard";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox ecoli_in;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox coliform_in;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox raksa_in;
		private System.Windows.Forms.TextBox arsen_in;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox mbas_in;
		private System.Windows.Forms.TextBox kmn_in;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox tds_in;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

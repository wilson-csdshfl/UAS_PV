/*
 * Created by SharpDevelop.
 * User: slim
 * Date: 6/9/2022
 * Time: 8:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UAS_PV
{
	partial class Information
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
			this.label_search = new System.Windows.Forms.Label();
			this.go = new System.Windows.Forms.Button();
			this.search = new System.Windows.Forms.TextBox();
			this.edit = new System.Windows.Forms.GroupBox();
			this.ecoli_in = new System.Windows.Forms.TextBox();
			this.coliform_in = new System.Windows.Forms.TextBox();
			this.kmn_in = new System.Windows.Forms.TextBox();
			this.mbas_in = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.arsen_in = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.raksa_in = new System.Windows.Forms.TextBox();
			this.tds_in = new System.Windows.Forms.TextBox();
			this.bau_in = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.date_in = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.update = new System.Windows.Forms.Button();
			this.insert = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.reset = new System.Windows.Forms.Button();
			this.refresh = new System.Windows.Forms.Button();
			this.dgs = new System.Windows.Forms.DataGridView();
			this.edit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgs)).BeginInit();
			this.SuspendLayout();
			// 
			// label_search
			// 
			this.label_search.Location = new System.Drawing.Point(12, 29);
			this.label_search.Name = "label_search";
			this.label_search.Size = new System.Drawing.Size(100, 23);
			this.label_search.TabIndex = 2;
			this.label_search.Text = "Search";
			// 
			// go
			// 
			this.go.Location = new System.Drawing.Point(285, 23);
			this.go.Name = "go";
			this.go.Size = new System.Drawing.Size(75, 23);
			this.go.TabIndex = 5;
			this.go.Text = "GO!";
			this.go.UseVisualStyleBackColor = true;
			this.go.Click += new System.EventHandler(this.GoClick);
			// 
			// search
			// 
			this.search.Location = new System.Drawing.Point(83, 26);
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(196, 20);
			this.search.TabIndex = 4;
			// 
			// edit
			// 
			this.edit.Controls.Add(this.ecoli_in);
			this.edit.Controls.Add(this.coliform_in);
			this.edit.Controls.Add(this.kmn_in);
			this.edit.Controls.Add(this.mbas_in);
			this.edit.Controls.Add(this.label9);
			this.edit.Controls.Add(this.label8);
			this.edit.Controls.Add(this.label7);
			this.edit.Controls.Add(this.label6);
			this.edit.Controls.Add(this.arsen_in);
			this.edit.Controls.Add(this.label5);
			this.edit.Controls.Add(this.raksa_in);
			this.edit.Controls.Add(this.tds_in);
			this.edit.Controls.Add(this.bau_in);
			this.edit.Controls.Add(this.label4);
			this.edit.Controls.Add(this.label3);
			this.edit.Controls.Add(this.label2);
			this.edit.Controls.Add(this.date_in);
			this.edit.Controls.Add(this.label1);
			this.edit.Location = new System.Drawing.Point(12, 72);
			this.edit.Name = "edit";
			this.edit.Size = new System.Drawing.Size(620, 178);
			this.edit.TabIndex = 7;
			this.edit.TabStop = false;
			this.edit.Text = "EDIT";
			// 
			// ecoli_in
			// 
			this.ecoli_in.Location = new System.Drawing.Point(376, 101);
			this.ecoli_in.Name = "ecoli_in";
			this.ecoli_in.Size = new System.Drawing.Size(100, 20);
			this.ecoli_in.TabIndex = 17;
			// 
			// coliform_in
			// 
			this.coliform_in.Location = new System.Drawing.Point(376, 81);
			this.coliform_in.Name = "coliform_in";
			this.coliform_in.Size = new System.Drawing.Size(100, 20);
			this.coliform_in.TabIndex = 16;
			// 
			// kmn_in
			// 
			this.kmn_in.Location = new System.Drawing.Point(376, 58);
			this.kmn_in.Name = "kmn_in";
			this.kmn_in.Size = new System.Drawing.Size(100, 20);
			this.kmn_in.TabIndex = 15;
			// 
			// mbas_in
			// 
			this.mbas_in.Location = new System.Drawing.Point(376, 35);
			this.mbas_in.Name = "mbas_in";
			this.mbas_in.Size = new System.Drawing.Size(100, 20);
			this.mbas_in.TabIndex = 14;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(321, 104);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 13;
			this.label9.Text = "E. Coli";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(321, 81);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 12;
			this.label8.Text = "Coliform";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(321, 61);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "KMN";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(321, 35);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "MBAS";
			// 
			// arsen_in
			// 
			this.arsen_in.Location = new System.Drawing.Point(174, 130);
			this.arsen_in.Name = "arsen_in";
			this.arsen_in.Size = new System.Drawing.Size(100, 20);
			this.arsen_in.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(124, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Arsen";
			// 
			// raksa_in
			// 
			this.raksa_in.Location = new System.Drawing.Point(174, 107);
			this.raksa_in.Name = "raksa_in";
			this.raksa_in.Size = new System.Drawing.Size(100, 20);
			this.raksa_in.TabIndex = 7;
			// 
			// tds_in
			// 
			this.tds_in.Location = new System.Drawing.Point(174, 84);
			this.tds_in.Name = "tds_in";
			this.tds_in.Size = new System.Drawing.Size(100, 20);
			this.tds_in.TabIndex = 6;
			// 
			// bau_in
			// 
			this.bau_in.Location = new System.Drawing.Point(174, 58);
			this.bau_in.Name = "bau_in";
			this.bau_in.Size = new System.Drawing.Size(100, 20);
			this.bau_in.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(124, 107);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Raksa";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(124, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "TDS";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(124, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Bau";
			// 
			// date_in
			// 
			this.date_in.Location = new System.Drawing.Point(174, 32);
			this.date_in.Name = "date_in";
			this.date_in.Size = new System.Drawing.Size(100, 20);
			this.date_in.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(124, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Date";
			// 
			// update
			// 
			this.update.Location = new System.Drawing.Point(93, 496);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(75, 23);
			this.update.TabIndex = 8;
			this.update.Text = "Update";
			this.update.UseVisualStyleBackColor = true;
			// 
			// insert
			// 
			this.insert.Location = new System.Drawing.Point(174, 496);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(75, 23);
			this.insert.TabIndex = 9;
			this.insert.Text = "Insert";
			this.insert.UseVisualStyleBackColor = true;
			this.insert.Click += new System.EventHandler(this.InsertClick);
			// 
			// delete
			// 
			this.delete.Location = new System.Drawing.Point(255, 496);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(75, 23);
			this.delete.TabIndex = 10;
			this.delete.Text = "Delete";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.DeleteClick);
			// 
			// reset
			// 
			this.reset.Location = new System.Drawing.Point(336, 496);
			this.reset.Name = "reset";
			this.reset.Size = new System.Drawing.Size(75, 23);
			this.reset.TabIndex = 11;
			this.reset.Text = "Reset";
			this.reset.UseVisualStyleBackColor = true;
			this.reset.Click += new System.EventHandler(this.ResetClick);
			// 
			// refresh
			// 
			this.refresh.Location = new System.Drawing.Point(12, 496);
			this.refresh.Name = "refresh";
			this.refresh.Size = new System.Drawing.Size(75, 23);
			this.refresh.TabIndex = 12;
			this.refresh.Text = "Refresh";
			this.refresh.UseVisualStyleBackColor = true;
			this.refresh.Click += new System.EventHandler(this.RefreshClick);
			// 
			// dgs
			// 
			this.dgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgs.Location = new System.Drawing.Point(9, 256);
			this.dgs.Name = "dgs";
			this.dgs.Size = new System.Drawing.Size(623, 234);
			this.dgs.TabIndex = 13;
			this.dgs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgsCellContentClick);
			// 
			// Information
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 531);
			this.Controls.Add(this.dgs);
			this.Controls.Add(this.refresh);
			this.Controls.Add(this.reset);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.insert);
			this.Controls.Add(this.update);
			this.Controls.Add(this.edit);
			this.Controls.Add(this.go);
			this.Controls.Add(this.search);
			this.Controls.Add(this.label_search);
			this.Name = "Information";
			this.Text = "Information";
			this.edit.ResumeLayout(false);
			this.edit.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgs)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dgs;
		private System.Windows.Forms.Button refresh;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox bau_in;
		private System.Windows.Forms.TextBox tds_in;
		private System.Windows.Forms.TextBox raksa_in;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox arsen_in;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox mbas_in;
		private System.Windows.Forms.TextBox kmn_in;
		private System.Windows.Forms.TextBox coliform_in;
		private System.Windows.Forms.TextBox ecoli_in;
		private System.Windows.Forms.Button reset;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox date_in;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox edit;
		private System.Windows.Forms.TextBox search;
		private System.Windows.Forms.Button go;
		private System.Windows.Forms.Label label_search;
	}
}

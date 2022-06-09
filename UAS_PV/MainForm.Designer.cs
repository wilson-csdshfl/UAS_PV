/*
 * Created by SharpDevelop.
 * User: slim
 * Date: 6/9/2022
 * Time: 4:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UAS_PV
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.readmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.connectionToolStripMenuItem,
									this.viewToolStripMenuItem,
									this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1214, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// connectionToolStripMenuItem
			// 
			this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.connectToolStripMenuItem,
									this.editToolStripMenuItem});
			this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
			this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
			this.connectionToolStripMenuItem.Text = "Connection";
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.connectToolStripMenuItem.Text = "Connect";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItemClick);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.editToolStripMenuItem.Text = "Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItemClick);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.dashboardToolStripMenuItem,
									this.informationToolStripMenuItem,
									this.rawToolStripMenuItem,
									this.resultToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// dashboardToolStripMenuItem
			// 
			this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
			this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.dashboardToolStripMenuItem.Text = "Dashboard";
			this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.DashboardToolStripMenuItemClick);
			// 
			// informationToolStripMenuItem
			// 
			this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
			this.informationToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.informationToolStripMenuItem.Text = "Information";
			this.informationToolStripMenuItem.Click += new System.EventHandler(this.InformationToolStripMenuItemClick);
			// 
			// rawToolStripMenuItem
			// 
			this.rawToolStripMenuItem.Name = "rawToolStripMenuItem";
			this.rawToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.rawToolStripMenuItem.Text = "Raw";
			// 
			// resultToolStripMenuItem
			// 
			this.resultToolStripMenuItem.Name = "resultToolStripMenuItem";
			this.resultToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.resultToolStripMenuItem.Text = "Result";
			this.resultToolStripMenuItem.Click += new System.EventHandler(this.ResultToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.readmeToolStripMenuItem});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// readmeToolStripMenuItem
			// 
			this.readmeToolStripMenuItem.Name = "readmeToolStripMenuItem";
			this.readmeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.readmeToolStripMenuItem.Text = "Readme";
			this.readmeToolStripMenuItem.Click += new System.EventHandler(this.ReadmeToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1214, 560);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "UAS_PV";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem readmeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rawToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}

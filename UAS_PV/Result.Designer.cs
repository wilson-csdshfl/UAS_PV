/*
 * Created by SharpDevelop.
 * User: slim
 * Date: 6/9/2022
 * Time: 6:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UAS_PV
{
	partial class Result
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
			this.label13 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Red;
			this.label13.Location = new System.Drawing.Point(18, 19);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(479, 60);
			this.label13.TabIndex = 12;
			this.label13.Text = "AIR MINUM TIDAK LAYAK UNTUK DIMINUM";
			// 
			// Result
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(521, 79);
			this.Controls.Add(this.label13);
			this.Name = "Result";
			this.Text = "Result";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label13;
	}
}

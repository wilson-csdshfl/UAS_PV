/*
 * Created by SharpDevelop.
 * User: slim
 * Date: 6/9/2022
 * Time: 4:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UAS_PV
{
	partial class Edit_Connection
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.h = new System.Windows.Forms.TextBox();
			this.u = new System.Windows.Forms.TextBox();
			this.p = new System.Windows.Forms.TextBox();
			this.d = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "DATABASE";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "HOST";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(32, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "USER";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(32, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "PASSWORD";
			// 
			// h
			// 
			this.h.Location = new System.Drawing.Point(149, 31);
			this.h.Name = "h";
			this.h.Size = new System.Drawing.Size(100, 20);
			this.h.TabIndex = 4;
			// 
			// u
			// 
			this.u.Location = new System.Drawing.Point(149, 99);
			this.u.Name = "u";
			this.u.Size = new System.Drawing.Size(100, 20);
			this.u.TabIndex = 5;
			// 
			// p
			// 
			this.p.Location = new System.Drawing.Point(149, 131);
			this.p.Name = "p";
			this.p.Size = new System.Drawing.Size(100, 20);
			this.p.TabIndex = 6;
			// 
			// d
			// 
			this.d.Location = new System.Drawing.Point(149, 65);
			this.d.Name = "d";
			this.d.Size = new System.Drawing.Size(100, 20);
			this.d.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(32, 175);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "SUBMIT";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(174, 175);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 9;
			this.button2.Text = "RESET";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Edit_Connection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 221);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.d);
			this.Controls.Add(this.p);
			this.Controls.Add(this.u);
			this.Controls.Add(this.h);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Edit_Connection";
			this.Text = "Edit_Connection";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox d;
		private System.Windows.Forms.TextBox p;
		private System.Windows.Forms.TextBox u;
		private System.Windows.Forms.TextBox h;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

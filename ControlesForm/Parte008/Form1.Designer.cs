﻿namespace Parte008
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dateTime = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dateTime
			// 
			this.dateTime.CalendarFont = new System.Drawing.Font("MS Outlook", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.dateTime.Location = new System.Drawing.Point(20, 23);
			this.dateTime.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.dateTime.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
			this.dateTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dateTime.Name = "dateTime";
			this.dateTime.Size = new System.Drawing.Size(388, 32);
			this.dateTime.TabIndex = 0;
			this.dateTime.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(484, 398);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(213, 71);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(709, 481);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dateTime);
			this.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTime;
		private System.Windows.Forms.Button button1;
	}
}

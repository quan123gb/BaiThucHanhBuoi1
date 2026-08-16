namespace BaiTapWindowsForm_Bai2
{
	partial class frmBai1
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
			this.label3 = new System.Windows.Forms.Label();
			this.lblThongTin = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(103, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Hiện thị thông tin";
			// 
			// lblThongTin
			// 
			this.lblThongTin.AutoSize = true;
			this.lblThongTin.Location = new System.Drawing.Point(223, 99);
			this.lblThongTin.Name = "lblThongTin";
			this.lblThongTin.Size = new System.Drawing.Size(10, 16);
			this.lblThongTin.TabIndex = 6;
			this.lblThongTin.Text = ".";
			this.lblThongTin.Click += new System.EventHandler(this.lblThongTin_Click);
			// 
			// frmBai1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblThongTin);
			this.Controls.Add(this.label3);
			this.Name = "frmBai1";
			this.Text = "frmBai1";
			this.Load += new System.EventHandler(this.frmBai1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblThongTin;
	}
}
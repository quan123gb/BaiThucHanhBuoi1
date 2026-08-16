namespace BaiTapWindowsForm_Bai4
{
	partial class frmBai3
	{
		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.Label lblHoTen;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.CheckBox chkNam;
		private System.Windows.Forms.Button btnChaoHoi;

		private System.Windows.Forms.Label lblM;
		private System.Windows.Forms.TextBox txtM;
		private System.Windows.Forms.Label lblN;
		private System.Windows.Forms.TextBox txtN;
		private System.Windows.Forms.Button btnUSCLN;
		private System.Windows.Forms.Label lblKetQua;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.lblHoTen = new System.Windows.Forms.Label();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.chkNam = new System.Windows.Forms.CheckBox();
			this.btnChaoHoi = new System.Windows.Forms.Button();

			this.lblM = new System.Windows.Forms.Label();
			this.txtM = new System.Windows.Forms.TextBox();
			this.lblN = new System.Windows.Forms.Label();
			this.txtN = new System.Windows.Forms.TextBox();
			this.btnUSCLN = new System.Windows.Forms.Button();
			this.lblKetQua = new System.Windows.Forms.Label();

			this.SuspendLayout();

			// lblHoTen
			this.lblHoTen.AutoSize = true;
			this.lblHoTen.Location = new System.Drawing.Point(40, 35);
			this.lblHoTen.Name = "lblHoTen";
			this.lblHoTen.Size = new System.Drawing.Size(55, 15);
			this.lblHoTen.TabIndex = 0;
			this.lblHoTen.Text = "Họ tên:";

			// txtHoTen
			this.txtHoTen.Location = new System.Drawing.Point(120, 32);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(220, 23);
			this.txtHoTen.TabIndex = 1;

			// chkNam
			this.chkNam.AutoSize = true;
			this.chkNam.Location = new System.Drawing.Point(120, 70);
			this.chkNam.Name = "chkNam";
			this.chkNam.Size = new System.Drawing.Size(52, 19);
			this.chkNam.TabIndex = 2;
			this.chkNam.Text = "Nam";
			this.chkNam.UseVisualStyleBackColor = true;

			// btnChaoHoi
			this.btnChaoHoi.Location = new System.Drawing.Point(120, 105);
			this.btnChaoHoi.Name = "btnChaoHoi";
			this.btnChaoHoi.Size = new System.Drawing.Size(100, 30);
			this.btnChaoHoi.TabIndex = 3;
			this.btnChaoHoi.Text = "Chào hỏi";
			this.btnChaoHoi.UseVisualStyleBackColor = true;
			this.btnChaoHoi.Click += new System.EventHandler(this.btnChaoHoi_Click);

			// lblM
			this.lblM.AutoSize = true;
			this.lblM.Location = new System.Drawing.Point(40, 175);
			this.lblM.Name = "lblM";
			this.lblM.Size = new System.Drawing.Size(42, 15);
			this.lblM.TabIndex = 4;
			this.lblM.Text = "Số m:";

			// txtM
			this.txtM.Location = new System.Drawing.Point(120, 172);
			this.txtM.Name = "txtM";
			this.txtM.Size = new System.Drawing.Size(220, 23);
			this.txtM.TabIndex = 5;

			// lblN
			this.lblN.AutoSize = true;
			this.lblN.Location = new System.Drawing.Point(40, 215);
			this.lblN.Name = "lblN";
			this.lblN.Size = new System.Drawing.Size(42, 15);
			this.lblN.TabIndex = 6;
			this.lblN.Text = "Số n:";

			// txtN
			this.txtN.Location = new System.Drawing.Point(120, 212);
			this.txtN.Name = "txtN";
			this.txtN.Size = new System.Drawing.Size(220, 23);
			this.txtN.TabIndex = 7;

			// btnUSCLN
			this.btnUSCLN.Location = new System.Drawing.Point(120, 250);
			this.btnUSCLN.Name = "btnUSCLN";
			this.btnUSCLN.Size = new System.Drawing.Size(100, 30);
			this.btnUSCLN.TabIndex = 8;
			this.btnUSCLN.Text = "Tìm USCLN";
			this.btnUSCLN.UseVisualStyleBackColor = true;
			this.btnUSCLN.Click += new System.EventHandler(this.btnUSCLN_Click);

			// lblKetQua
			this.lblKetQua.AutoSize = true;
			this.lblKetQua.Font = new System.Drawing.Font(
				"Microsoft Sans Serif",
				10F,
				System.Drawing.FontStyle.Bold
			);
			this.lblKetQua.Location = new System.Drawing.Point(40, 305);
			this.lblKetQua.Name = "lblKetQua";
			this.lblKetQua.Size = new System.Drawing.Size(70, 17);
			this.lblKetQua.TabIndex = 9;
			this.lblKetQua.Text = "Kết quả:";

			// frmBai3
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 360);

			this.Controls.Add(this.lblKetQua);
			this.Controls.Add(this.btnUSCLN);
			this.Controls.Add(this.txtN);
			this.Controls.Add(this.lblN);
			this.Controls.Add(this.txtM);
			this.Controls.Add(this.lblM);
			this.Controls.Add(this.btnChaoHoi);
			this.Controls.Add(this.chkNam);
			this.Controls.Add(this.txtHoTen);
			this.Controls.Add(this.lblHoTen);

			this.Name = "frmBai3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bài 3";

			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion
	}
}
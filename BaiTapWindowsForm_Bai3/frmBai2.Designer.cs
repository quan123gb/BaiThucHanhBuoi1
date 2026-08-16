namespace BaiTapWindowsForm_Bai3
{
	partial class frmBai2
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdTong = new System.Windows.Forms.RadioButton();
			this.rdGiaiThua = new System.Windows.Forms.RadioButton();
			this.txtSoN = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnKetQua = new System.Windows.Forms.Button();
			this.lblSoTien = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdTong);
			this.groupBox1.Controls.Add(this.rdGiaiThua);
			this.groupBox1.Location = new System.Drawing.Point(310, 127);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(210, 103);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn phép toán";
			// 
			// rdTong
			// 
			this.rdTong.AutoSize = true;
			this.rdTong.Checked = true;
			this.rdTong.Location = new System.Drawing.Point(18, 30);
			this.rdTong.Name = "rdTong";
			this.rdTong.Size = new System.Drawing.Size(161, 20);
			this.rdTong.TabIndex = 1;
			this.rdTong.TabStop = true;
			this.rdTong.Text = "Tính Tổng 1 + 2 + ... +N";
			this.rdTong.UseVisualStyleBackColor = true;
			// 
			// rdGiaiThua
			// 
			this.rdGiaiThua.AutoSize = true;
			this.rdGiaiThua.Location = new System.Drawing.Point(18, 56);
			this.rdGiaiThua.Name = "rdGiaiThua";
			this.rdGiaiThua.Size = new System.Drawing.Size(147, 20);
			this.rdGiaiThua.TabIndex = 0;
			this.rdGiaiThua.Text = "Tính N giai thừa ( N!)";
			this.rdGiaiThua.UseVisualStyleBackColor = true;
			// 
			// txtSoN
			// 
			this.txtSoN.Location = new System.Drawing.Point(389, 62);
			this.txtSoN.Name = "txtSoN";
			this.txtSoN.Size = new System.Drawing.Size(100, 22);
			this.txtSoN.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(213, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "Nhập số nguyên dương N:";
			// 
			// btnKetQua
			// 
			this.btnKetQua.Location = new System.Drawing.Point(340, 274);
			this.btnKetQua.Name = "btnKetQua";
			this.btnKetQua.Size = new System.Drawing.Size(111, 23);
			this.btnKetQua.TabIndex = 15;
			this.btnKetQua.Text = "Xem Kết Quả";
			this.btnKetQua.UseVisualStyleBackColor = true;
			this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
			// 
			// lblSoTien
			// 
			this.lblSoTien.AutoSize = true;
			this.lblSoTien.Location = new System.Drawing.Point(378, 342);
			this.lblSoTien.Name = "lblSoTien";
			this.lblSoTien.Size = new System.Drawing.Size(10, 16);
			this.lblSoTien.TabIndex = 14;
			this.lblSoTien.Text = ".";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(283, 342);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 16);
			this.label3.TabIndex = 13;
			this.label3.Text = "Kết quả là";
			// 
			// frmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtSoN);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnKetQua);
			this.Controls.Add(this.lblSoTien);
			this.Controls.Add(this.label3);
			this.Name = "frmBai2";
			this.Text = "frmBai2";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdTong;
		private System.Windows.Forms.RadioButton rdGiaiThua;
		private System.Windows.Forms.TextBox txtSoN;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnKetQua;
		private System.Windows.Forms.Label lblSoTien;
		private System.Windows.Forms.Label label3;
	}
}
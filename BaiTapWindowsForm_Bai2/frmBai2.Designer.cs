namespace BaiTapWindowsForm_Bai2
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSoThu1 = new System.Windows.Forms.TextBox();
			this.txtSoThu2 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdCong = new System.Windows.Forms.RadioButton();
			this.rdTru = new System.Windows.Forms.RadioButton();
			this.rdNhan = new System.Windows.Forms.RadioButton();
			this.rdChia = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.lblSoTien = new System.Windows.Forms.Label();
			this.btnKetQua = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(106, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số thứ nhất";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(106, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Số thứ hai";
			// 
			// txtSoThu1
			// 
			this.txtSoThu1.Location = new System.Drawing.Point(199, 66);
			this.txtSoThu1.Name = "txtSoThu1";
			this.txtSoThu1.Size = new System.Drawing.Size(100, 22);
			this.txtSoThu1.TabIndex = 2;
			// 
			// txtSoThu2
			// 
			this.txtSoThu2.Location = new System.Drawing.Point(199, 105);
			this.txtSoThu2.Name = "txtSoThu2";
			this.txtSoThu2.Size = new System.Drawing.Size(100, 22);
			this.txtSoThu2.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdChia);
			this.groupBox1.Controls.Add(this.rdNhan);
			this.groupBox1.Controls.Add(this.rdTru);
			this.groupBox1.Controls.Add(this.rdCong);
			this.groupBox1.Location = new System.Drawing.Point(160, 149);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(139, 152);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn phép toán";
			// 
			// rdCong
			// 
			this.rdCong.AutoSize = true;
			this.rdCong.Location = new System.Drawing.Point(18, 30);
			this.rdCong.Name = "rdCong";
			this.rdCong.Size = new System.Drawing.Size(60, 20);
			this.rdCong.TabIndex = 0;
			this.rdCong.Text = "Cộng";
			this.rdCong.UseVisualStyleBackColor = true;
			// 
			// rdTru
			// 
			this.rdTru.AutoSize = true;
			this.rdTru.Checked = true;
			this.rdTru.Location = new System.Drawing.Point(18, 56);
			this.rdTru.Name = "rdTru";
			this.rdTru.Size = new System.Drawing.Size(48, 20);
			this.rdTru.TabIndex = 1;
			this.rdTru.TabStop = true;
			this.rdTru.Text = "Trừ";
			this.rdTru.UseVisualStyleBackColor = true;
			// 
			// rdNhan
			// 
			this.rdNhan.AutoSize = true;
			this.rdNhan.Location = new System.Drawing.Point(18, 82);
			this.rdNhan.Name = "rdNhan";
			this.rdNhan.Size = new System.Drawing.Size(60, 20);
			this.rdNhan.TabIndex = 2;
			this.rdNhan.Text = "Nhân";
			this.rdNhan.UseVisualStyleBackColor = true;
			// 
			// rdChia
			// 
			this.rdChia.AutoSize = true;
			this.rdChia.Location = new System.Drawing.Point(18, 108);
			this.rdChia.Name = "rdChia";
			this.rdChia.Size = new System.Drawing.Size(55, 20);
			this.rdChia.TabIndex = 3;
			this.rdChia.Text = "Chia";
			this.rdChia.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(136, 364);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Kết quả là";
			// 
			// lblSoTien
			// 
			this.lblSoTien.AutoSize = true;
			this.lblSoTien.Location = new System.Drawing.Point(219, 364);
			this.lblSoTien.Name = "lblSoTien";
			this.lblSoTien.Size = new System.Drawing.Size(10, 16);
			this.lblSoTien.TabIndex = 6;
			this.lblSoTien.Text = ".";
			// 
			// btnKetQua
			// 
			this.btnKetQua.Location = new System.Drawing.Point(188, 318);
			this.btnKetQua.Name = "btnKetQua";
			this.btnKetQua.Size = new System.Drawing.Size(111, 23);
			this.btnKetQua.TabIndex = 7;
			this.btnKetQua.Text = "XemKetQua";
			this.btnKetQua.UseVisualStyleBackColor = true;
			this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
			// 
			// frmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnKetQua);
			this.Controls.Add(this.lblSoTien);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtSoThu2);
			this.Controls.Add(this.txtSoThu1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai2";
			this.Text = "frmBai2";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSoThu1;
		private System.Windows.Forms.TextBox txtSoThu2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdChia;
		private System.Windows.Forms.RadioButton rdNhan;
		private System.Windows.Forms.RadioButton rdTru;
		private System.Windows.Forms.RadioButton rdCong;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblSoTien;
		private System.Windows.Forms.Button btnKetQua;
	}
}
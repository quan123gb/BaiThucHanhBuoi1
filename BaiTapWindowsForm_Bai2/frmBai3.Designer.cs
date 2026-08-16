namespace BaiTapWindowsForm_Bai2
{
	partial class frmBai3
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
			this.label3 = new System.Windows.Forms.Label();
			this.txtHo = new System.Windows.Forms.TextBox();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.txtSoN = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdNoiChuoi = new System.Windows.Forms.RadioButton();
			this.rdGiaiThua = new System.Windows.Forms.RadioButton();
			this.btnKetQua = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblKetQua = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(101, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Họ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(101, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(101, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nhập n";
			// 
			// txtHo
			// 
			this.txtHo.Location = new System.Drawing.Point(191, 56);
			this.txtHo.Name = "txtHo";
			this.txtHo.Size = new System.Drawing.Size(100, 22);
			this.txtHo.TabIndex = 3;
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(191, 92);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(100, 22);
			this.txtTen.TabIndex = 4;
			// 
			// txtSoN
			// 
			this.txtSoN.Location = new System.Drawing.Point(191, 130);
			this.txtSoN.Name = "txtSoN";
			this.txtSoN.Size = new System.Drawing.Size(100, 22);
			this.txtSoN.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdGiaiThua);
			this.groupBox1.Controls.Add(this.rdNoiChuoi);
			this.groupBox1.Location = new System.Drawing.Point(117, 170);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(174, 141);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn phương thức";
			// 
			// rdNoiChuoi
			// 
			this.rdNoiChuoi.AutoSize = true;
			this.rdNoiChuoi.Checked = true;
			this.rdNoiChuoi.Location = new System.Drawing.Point(23, 35);
			this.rdNoiChuoi.Name = "rdNoiChuoi";
			this.rdNoiChuoi.Size = new System.Drawing.Size(84, 20);
			this.rdNoiChuoi.TabIndex = 0;
			this.rdNoiChuoi.TabStop = true;
			this.rdNoiChuoi.Text = "Nối chuỗi";
			this.rdNoiChuoi.UseVisualStyleBackColor = true;
			// 
			// rdGiaiThua
			// 
			this.rdGiaiThua.AutoSize = true;
			this.rdGiaiThua.Location = new System.Drawing.Point(23, 84);
			this.rdGiaiThua.Name = "rdGiaiThua";
			this.rdGiaiThua.Size = new System.Drawing.Size(107, 20);
			this.rdGiaiThua.TabIndex = 1;
			this.rdGiaiThua.Text = "Tính giai thừa";
			this.rdGiaiThua.UseVisualStyleBackColor = true;
			// 
			// btnKetQua
			// 
			this.btnKetQua.Location = new System.Drawing.Point(153, 317);
			this.btnKetQua.Name = "btnKetQua";
			this.btnKetQua.Size = new System.Drawing.Size(75, 23);
			this.btnKetQua.TabIndex = 7;
			this.btnKetQua.Text = "Kết Quả";
			this.btnKetQua.UseVisualStyleBackColor = true;
			this.btnKetQua.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(101, 371);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Thông tin kết quả";
			// 
			// lblKetQua
			// 
			this.lblKetQua.AutoSize = true;
			this.lblKetQua.Location = new System.Drawing.Point(221, 371);
			this.lblKetQua.Name = "lblKetQua";
			this.lblKetQua.Size = new System.Drawing.Size(10, 16);
			this.lblKetQua.TabIndex = 9;
			this.lblKetQua.Text = ".";
			// 
			// frmBai3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblKetQua);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnKetQua);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtSoN);
			this.Controls.Add(this.txtTen);
			this.Controls.Add(this.txtHo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai3";
			this.Text = "frmBai3";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtHo;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.TextBox txtSoN;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdGiaiThua;
		private System.Windows.Forms.RadioButton rdNoiChuoi;
		private System.Windows.Forms.Button btnKetQua;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblKetQua;
	}
}
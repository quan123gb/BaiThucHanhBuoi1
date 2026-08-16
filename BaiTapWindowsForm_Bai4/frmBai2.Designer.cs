namespace BaiTapWindowsForm_Bai4
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
			this.label3 = new System.Windows.Forms.Label();
			this.lblXepLoai = new System.Windows.Forms.Label();
			this.btnXepLoai = new System.Windows.Forms.Button();
			this.txtLyThuyet = new System.Windows.Forms.TextBox();
			this.txtThucHanh = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(112, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập điểm lí thuyết";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(112, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nhập điểm thực hành";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(134, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Kết quả xếp loại";
			// 
			// lblXepLoai
			// 
			this.lblXepLoai.AutoSize = true;
			this.lblXepLoai.ForeColor = System.Drawing.Color.Red;
			this.lblXepLoai.Location = new System.Drawing.Point(276, 194);
			this.lblXepLoai.Name = "lblXepLoai";
			this.lblXepLoai.Size = new System.Drawing.Size(14, 16);
			this.lblXepLoai.TabIndex = 3;
			this.lblXepLoai.Text = "0";
			// 
			// btnXepLoai
			// 
			this.btnXepLoai.Location = new System.Drawing.Point(186, 140);
			this.btnXepLoai.Name = "btnXepLoai";
			this.btnXepLoai.Size = new System.Drawing.Size(104, 23);
			this.btnXepLoai.TabIndex = 4;
			this.btnXepLoai.Text = "Xếp Loại";
			this.btnXepLoai.UseVisualStyleBackColor = true;
			this.btnXepLoai.Click += new System.EventHandler(this.btnXepLoai_Click);
			// 
			// txtLyThuyet
			// 
			this.txtLyThuyet.Location = new System.Drawing.Point(249, 49);
			this.txtLyThuyet.Name = "txtLyThuyet";
			this.txtLyThuyet.Size = new System.Drawing.Size(100, 22);
			this.txtLyThuyet.TabIndex = 5;
			// 
			// txtThucHanh
			// 
			this.txtThucHanh.Location = new System.Drawing.Point(250, 88);
			this.txtThucHanh.Name = "txtThucHanh";
			this.txtThucHanh.Size = new System.Drawing.Size(100, 22);
			this.txtThucHanh.TabIndex = 6;
			// 
			// frmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtThucHanh);
			this.Controls.Add(this.txtLyThuyet);
			this.Controls.Add(this.btnXepLoai);
			this.Controls.Add(this.lblXepLoai);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai2";
			this.Text = "frmBai2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblXepLoai;
		private System.Windows.Forms.Button btnXepLoai;
		private System.Windows.Forms.TextBox txtLyThuyet;
		private System.Windows.Forms.TextBox txtThucHanh;
	}
}
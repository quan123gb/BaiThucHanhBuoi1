namespace BaiTapThietKeForm
{
	partial class frmBai4
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnTimSo = new System.Windows.Forms.Button();
			this.txtSo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblKetQua = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(67, 69);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(192, 228);
			this.listBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(365, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nhập số cần tìm:";
			// 
			// btnTimSo
			// 
			this.btnTimSo.Location = new System.Drawing.Point(546, 140);
			this.btnTimSo.Name = "btnTimSo";
			this.btnTimSo.Size = new System.Drawing.Size(75, 23);
			this.btnTimSo.TabIndex = 2;
			this.btnTimSo.Text = "Tìm số";
			this.btnTimSo.UseVisualStyleBackColor = true;
			this.btnTimSo.Click += new System.EventHandler(this.btnTimSo_Click);
			// 
			// txtSo
			// 
			this.txtSo.Location = new System.Drawing.Point(506, 66);
			this.txtSo.Name = "txtSo";
			this.txtSo.Size = new System.Drawing.Size(159, 22);
			this.txtSo.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(363, 197);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Kết quả";
			// 
			// lblKetQua
			// 
			this.lblKetQua.AutoSize = true;
			this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKetQua.ForeColor = System.Drawing.Color.Red;
			this.lblKetQua.Location = new System.Drawing.Point(503, 197);
			this.lblKetQua.Name = "lblKetQua";
			this.lblKetQua.Size = new System.Drawing.Size(17, 25);
			this.lblKetQua.TabIndex = 5;
			this.lblKetQua.Text = ".";
			// 
			// frmBai4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblKetQua);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSo);
			this.Controls.Add(this.btnTimSo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox1);
			this.Name = "frmBai4";
			this.Text = "frmBai4";
			this.Load += new System.EventHandler(this.frmBai4_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnTimSo;
		private System.Windows.Forms.TextBox txtSo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblKetQua;
	}
}
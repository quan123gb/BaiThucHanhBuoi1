using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm_Bai3
{
	public partial class frmBai1 : Form
	{
		public frmBai1()
		{
			InitializeComponent();
		}

		private void lblThongTin_Click(object sender, EventArgs e)
		{
		

		}

		private void frmBai1_Load(object sender, EventArgs e)
		{
			NhanVien hh = new NhanVien(
		"AA11",
		"Nguyễn Văn A",
		new DateTime(2000, 8, 15),
		3.5,
		0.5
	);

			lblThongTin.Text = hh.HienThi();
		}
	}
	
}

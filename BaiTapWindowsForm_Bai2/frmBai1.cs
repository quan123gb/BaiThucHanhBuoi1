using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm_Bai2
{
	public partial class frmBai1 : Form
	{
		public frmBai1()
		{
			InitializeComponent();
		}

	

		private void frmBai1_Load(object sender, EventArgs e)
		{
			ThietBi hh = new ThietBi(
		"HH01",
		"Chuột",
		"Nhật Bản",
		1000000,
		4
		);

			lblThongTin.Text = hh.HienThi();

		}

		private void lblThongTin_Click(object sender, EventArgs e)
		{

		}
	}
}

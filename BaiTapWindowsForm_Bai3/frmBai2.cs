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
	public partial class frmBai2 : Form
	{
		public frmBai2()
		{
			InitializeComponent();
		}

		private void btnKetQua_Click(object sender, EventArgs e)
		{
			int n = int.Parse(txtSoN.Text);
			int ketQua = 0;

			if (rdTong.Checked)
			{
				for (int i = 1; i <= n; i++)
				{
					ketQua = ketQua + i;
				}
			}
			else if (rdGiaiThua.Checked)
			{
				ketQua = 1;

				for (int i = 1; i <= n; i++)
				{
					ketQua = ketQua * i;
				}
			}

			lblSoTien.Text = ketQua.ToString();	
		}
	}
}

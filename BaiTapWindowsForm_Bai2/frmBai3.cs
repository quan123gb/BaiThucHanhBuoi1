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
	public partial class frmBai3 : Form
	{
		public frmBai3()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (rdNoiChuoi.Checked)
			{
				string kq;

				XuLy.NoiChuoi(txtHo.Text, txtTen.Text, out kq);

				lblKetQua.Text = kq;
			}
			else
			{
				int n = int.Parse(txtSoN.Text);

				long kq = XuLy.GiaiThua(n);

				lblKetQua.Text = kq.ToString();
			}
		}
	}
}

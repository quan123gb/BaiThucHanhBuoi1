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
	public partial class frmBai3 : Form
	{
		public frmBai3()
		{
			InitializeComponent();
		}

		private void btnTachChuoi_Click(object sender, EventArgs e)
		{
			string s1;
			string s2;

			XuLy1.TachChuoi(txtHoTen.Text, out s1, out s2);

			txtHo.Text = s1;
			txtTen.Text = s2;
		}

		private void btnKiemTra_Click(object sender, EventArgs e)
		{
			int n1 = int.Parse(txtSon1.Text);
			int n2 = int.Parse(txtSon2.Text);

			bool kq = XuLy1.ThuTu(n1, n2);

			if (kq)
				txtKetQua.Text = "Hai số là số nguyên liên tiếp";
			else
				txtKetQua.Text = "Hai số không phải là số nguyên liên tiếp";
		}
	}
}

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
	public partial class frmBai2 : Form
	{
		public frmBai2()
		{
			InitializeComponent();
		}

		private void btnKetQua_Click(object sender, EventArgs e)
		{
			double soThuNhat = double.Parse(txtSoThu1.Text);
			double soThuHai = double.Parse(txtSoThu2.Text);
			double ketQua = 0;

			if (rdCong.Checked)
			{
				ketQua = soThuNhat + soThuHai;
			}
			else if (rdTru.Checked)
			{
				ketQua = soThuNhat - soThuHai;
			}
			else if (rdNhan.Checked)
			{
				ketQua = soThuNhat * soThuHai;
			}
			else if (rdChia.Checked)
			{
				ketQua = soThuNhat / soThuHai;
			}

			lblSoTien.Text = ketQua.ToString();
		}
	}
}

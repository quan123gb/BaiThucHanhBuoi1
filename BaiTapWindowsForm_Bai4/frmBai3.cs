using System;
using System.Windows.Forms;

namespace BaiTapWindowsForm_Bai4
{
	public partial class frmBai3 : Form
	{
		public frmBai3()
		{
			InitializeComponent();
		}

		// Xử lý nút Chào hỏi
		private void btnChaoHoi_Click(object sender, EventArgs e)
		{
			string hoten = txtHoTen.Text;
			bool gioitinh = chkNam.Checked;

			XuLy.ChaoHoi(hoten, gioitinh);
		}

		// Xử lý nút Tìm USCLN
		private void btnUSCLN_Click(object sender, EventArgs e)
		{
			int m = int.Parse(txtM.Text);
			int n = int.Parse(txtN.Text);

			int ketQua = XuLy.USCLN(m, n);

			lblKetQua.Text = "Kết quả: USCLN = " + ketQua;
		}
	}
}
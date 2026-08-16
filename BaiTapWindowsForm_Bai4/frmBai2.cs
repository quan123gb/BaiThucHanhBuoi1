using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm_Bai4
{
	public partial class frmBai2 : Form
	{
		public frmBai2()
		{
			InitializeComponent();
		}

		private void btnXepLoai_Click(object sender, EventArgs e)
		{
			double diemLyThuyet = double.Parse(txtLyThuyet.Text);
			double diemThucHanh = double.Parse(txtThucHanh.Text);

			double diemTrungBinh = (diemLyThuyet + diemThucHanh) / 2;

			string xepLoai;

			if (diemLyThuyet < 5 || diemThucHanh < 5)
			{
				xepLoai = "Yếu";
			}
			else if (diemTrungBinh < 7)
			{
				xepLoai = "Trung bình";
			}
			else if (diemTrungBinh < 8)
			{
				xepLoai = "Khá";
			}
			else if (diemTrungBinh < 9)
			{
				xepLoai = "Giỏi";
			}
			else
			{
				xepLoai = "Xuất sắc";
			}

			lblXepLoai.Text = "Kết quả xếp loại: " + xepLoai;
		}
	}
}

using System;
using System.Windows.Forms;

namespace BaiTapWindowsForm_Bai4
{
	public class XuLy
	{
		// Hàm chào hỏi
		public static void ChaoHoi(string hoten, bool gioitinh)
		{
			if (gioitinh == true)
			{
				MessageBox.Show("Chào Ông " + hoten);
			}
			else
			{
				MessageBox.Show("Chào Bà " + hoten);
			}
		}

		// Hàm tìm ước số chung lớn nhất
		public static int USCLN(int m, int n)
		{
			while (n != 0)
			{
				int tam = m % n;
				m = n;
				n = tam;
			}

			return m;
		}
	}
}
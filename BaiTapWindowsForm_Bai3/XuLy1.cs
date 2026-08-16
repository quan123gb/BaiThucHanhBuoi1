using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm_Bai3
{
	internal class XuLy1
	{
		public static void TachChuoi(string hoten, out string s1, out string s2)
		{
			hoten = hoten.Trim();

			int viTri = hoten.LastIndexOf(' ');

			if (viTri == -1)
			{
				s1 = hoten;
				s2 = "";
			}
			else
			{
				s1 = hoten.Substring(0, viTri);
				s2 = hoten.Substring(viTri + 1);
			}
		}

		// Kiểm tra n1 và n2 có phải 2 số nguyên liên tiếp
		public static bool ThuTu(int n1, int n2)
		{
			if (n2 == n1 + 1)
				return true;
			else
				return false;
		}
	}
}


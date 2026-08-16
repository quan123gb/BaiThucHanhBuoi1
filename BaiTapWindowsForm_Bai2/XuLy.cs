using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm_Bai2
{
	internal class XuLy
	{
		public static void NoiChuoi(string ho, string ten, out string s)
		{
			s = ho + " " + ten;
		}

		// Hàm tính giai thừa
		public static long GiaiThua(int n)
		{
			long gt = 1;

			for (int i = 1; i <= n; i++)
			{
				gt = gt * i;
			}

			return gt;
		}
	}
}

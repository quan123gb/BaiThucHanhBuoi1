using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm_Bai2
{
	internal class ThietBi
	{
		private int endl;

		public string MaThietBi {  get; set; }
		public string TenThietBi { get; set; }
		public string NuocSanXuat { get; set; }
		public double  DonGia { get; set; }
		public int SoLuong { get; set; }
		public ThietBi(string ma, string ten, string nuoc, double gia, int sl)
		{
			MaThietBi = ma;
			TenThietBi = ten;
			NuocSanXuat = nuoc;
			DonGia = gia;
			SoLuong = sl;
		}
		public double ThanhTien()
		{
			return DonGia * SoLuong;
		}
		public string HienThi()
		{
			return "Mã thiết bị: " + MaThietBi +
				   "\nTên thiết bị: " + TenThietBi +
				   "\nNước sản xuất: " + NuocSanXuat +
				   "\nĐơn giá: " + DonGia +
				   "\nSố lượng: " + SoLuong +
				   "\nThành tiền: " + ThanhTien();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm_Bai3
{
	internal class NhanVien
	{
		// Các thuộc tính
		public string MaNV { get; set; }
		public string HoTen { get; set; }
		public DateTime NgaySinh { get; set; }
		public double HeSoLuong { get; set; }
		public double HeSoPhuCap { get; set; }

		public NhanVien(string maNV, string hoTen, DateTime ngaySinh,
						double heSoLuong, double heSoPhuCap)
		{
			MaNV = maNV;
			HoTen = hoTen;
			NgaySinh = ngaySinh;
			HeSoLuong = heSoLuong;
			HeSoPhuCap = heSoPhuCap;
		}
		public double TongLuong()
		{
			return (HeSoLuong + HeSoPhuCap) * 1150000;
		}
		public string HienThi()
		{
			return "Mã nhân viên: " + MaNV +
				   "\nHọ tên: " + HoTen +
				   "\nNgày sinh: " + NgaySinh.ToString("dd/MM/yyyy") +
				   "\nHệ số lương: " + HeSoLuong +
				   "\nHệ số phụ cấp: " + HeSoPhuCap +
				   "\nTổng lương: " + TongLuong().ToString("N0");
		}
	}
}

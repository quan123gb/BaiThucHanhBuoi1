using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm_Bai4
{

	public class SanPham
	{
		// Các thuộc tính
		public string MaSanPham { get; set; }
		public string TenSanPham { get; set; }
		public string LoaiSanPham { get; set; }
		public DateTime NgaySanXuat { get; set; }

		// Hàm khởi tạo không tham số
		public SanPham()
		{
		}

		// Phương thức lấy năm hết hạn
		public int NamHetHan()
		{
			return NgaySanXuat.Year + 3;
		}

		// Phương thức hiển thị thông tin
		public string HienThi()
		{
			return "Mã sản phẩm: " + MaSanPham +
				   "\r\nTên sản phẩm: " + TenSanPham +
				   "\r\nLoại sản phẩm: " + LoaiSanPham +
				   "\r\nNgày sản xuất: " + NgaySanXuat.ToString("dd/MM/yyyy") +
				   "\r\nNăm hết hạn: " + NamHetHan();
		}
	}

}

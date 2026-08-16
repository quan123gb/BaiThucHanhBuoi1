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
	public partial class frmBai1 : Form
	{
		public frmBai1()
		{
			InitializeComponent();
		}

		private void frmBai1_Load(object sender, EventArgs e)
		{
			SanPham sp = new SanPham();

			sp.MaSanPham = "SP01";
			sp.TenSanPham = "Sữa Vinamilk";
			sp.LoaiSanPham = "Thực phẩm";
			sp.NgaySanXuat = new DateTime(2026, 8, 16);

			// Hiển thị thông tin sản phẩm
			lblThongTin.Text = sp.HienThi();
		}
	}
}

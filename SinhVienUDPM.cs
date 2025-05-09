using System;
namespace th1
{
	internal class SinhVienUDPM : SinhVienFPOL
	{
		private int _chuyenNganhHep;
		public int chuyenNganhHep {
			get { return _chuyenNganhHep; }
			set { _chuyenNganhHep = value; }
		}
		public SinhVienUDPM(int maSV, string hoTen, int chuyenNganh, int chuyenNganhHep)
			: base(maSV, hoTen, chuyenNganh)
		{
			this.chuyenNganhHep = chuyenNganhHep;
		}
		public void inThongTin() {
			base.inThongTin();
			Console.WriteLine(",Chuyen nganh hep:{0}", this.chuyenNganhHep);
		}
	}
}


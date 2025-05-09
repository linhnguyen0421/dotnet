using System;
namespace th1
{
	internal class SinhVienFPOL
	{
		public int _maSV;
		public int maSV {
			get { return _maSV; }
			set { _maSV = value; }
		}
		private string _hoTen;
		public string hoTen
		{
			get { return _hoTen; }
			set { _hoTen = value; }
		}
		private int _chuyenNganh;
		public int chuyenNganh{
			get { return _chuyenNganh; }
			set { _chuyenNganh = value; }
		}
		//in thong tin tung sv
		public void inThongTin()
		{
			Console.WriteLine("Ma SV:{0},Ho ten:{1}, Chuyen nganh:{2}",this.maSV,this.hoTen,this.chuyenNganh);
		}
		//contructer co tham so
		public SinhVienFPOL() { }
		public SinhVienFPOL(int maSV,string hoTen,int chuyenNganh) {
			this.maSV = maSV;
			this.hoTen = hoTen;
			this.chuyenNganh = chuyenNganh;
		}
	}
}


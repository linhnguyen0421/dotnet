using System;
using System.Collections.Generic;

namespace th1
{
	internal class QLSV
	{
		List<SinhVienFPOL> dssv = new List<SinhVienFPOL>();
		public void nhapDSSV()
		{
			int ma;
			string hoten;
			int chuyennganh;
			string chon;
			do
			{
				Console.Write("Ma sv:");//nhap ma
				ma = int.Parse(Console.ReadLine());
				//ma = layMa();
				Console.Write("Ho ten:");
				hoten = Console.ReadLine();
                Console.Write("Chuyen nganh:");
                chuyennganh = int.Parse(Console.ReadLine());
                SinhVienFPOL sv = new SinhVienFPOL(ma, hoten, chuyennganh);
				dssv.Add(sv);
				Console.Write("Ban muon tiep tuc(y/n)?");
				chon = Console.ReadLine();
			} while (chon == "y");
		}
		public void xuat() {
			Console.WriteLine("Danh sach sinh vien :");
			foreach (SinhVienFPOL s in dssv)
				s.inThongTin();
		}
        public void timSV(int ma)
        {
            bool timThay = false;
            foreach (SinhVienFPOL sv in dssv)
            {
                if (sv.maSV == ma)
                {
                    sv.inThongTin();
                    timThay = true;
                    // Nếu mã sinh viên là duy nhất, bạn có thể dùng break để dừng vòng lặp
                    break;
                }
            }
            if (!timThay)
            {
                Console.WriteLine("Khong tim thay sinh vien voi ma: " + ma);
            }
        }

        public void xoaSV(int ma)
        {
            bool thay = false;
            // Duyệt ngược để tránh vấn đề với chỉ số khi xóa
            for (int i = dssv.Count - 1; i >= 0; i--)
            {
                if (dssv[i].maSV == ma)
                {
                    thay = true;
                    dssv.RemoveAt(i);
                }
            }
            if (!thay)
                Console.WriteLine("Khong tim thay");
            else
            {
                Console.WriteLine("Danh sach sinh vien sau xoa:");
                xuat();
            }
        }

        //them
        //public int layMa() {
        //	int ma = 0;
        //	if (dssv.Count == 0) ma = 1;
        //	else ma = dssv.Count + 1;
        //	return ma;
        //}
        // Sắp xếp danh sách sinh viên theo mã
        public void sapXepTheoMa()
        {
            dssv.Sort((sv1, sv2) => sv1.maSV.CompareTo(sv2.maSV));
            Console.WriteLine("Danh sach sau khi sap xep theo ma:");
            xuat();
        }

        // Sửa thông tin sinh viên theo mã
        public void suaSV(int ma)
        {
            bool thay = false;
            foreach (SinhVienFPOL sv in dssv)
            {
                if (sv.maSV == ma)
                {
                    Console.Write("Nhap ten moi: ");
                    sv.hoTen = Console.ReadLine();
                    Console.Write("Nhap chuyen nganh moi: ");
                    sv.chuyenNganh = int.Parse(Console.ReadLine());
                    thay = true;
                    break;
                }
            }
            if (thay)
            {
                Console.WriteLine("Da cap nhat thong tin sinh vien.");
                xuat();
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien can sua.");
            }
        }

    }
}


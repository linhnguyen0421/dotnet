using System;
using th1;

class Program
{
    static void Main(string[] args)
    {
        QLSV ql = new QLSV();
        do { 
        int chon;
        Console.WriteLine("MENU chuong trinh:");
        Console.WriteLine("0. Thoat ");
        Console.WriteLine("1. Nhap DSSV");
        Console.WriteLine("2. Xuat DSSV");
        Console.WriteLine("3. Tim DSSV");
        Console.WriteLine("4. Xoa DSSV");
        Console.WriteLine("5. Sap xep DSSV theo ma");
        Console.WriteLine("6. Sua thong tin sinh vien");
        Console.WriteLine("Moi ban nhap lua chon");
        chon = int.Parse(Console.ReadLine());
        switch (chon)
            {
                case 0:
                    return;
                case 1:
                    ql.nhapDSSV();
                    break;
                case 2:
                    ql.xuat();
                    break;
                case 3:
                    int maTim;
                    Console.Write("Nhap ma sinh vien can tim: ");
                    maTim = int.Parse(Console.ReadLine());
                    ql.timSV(maTim);
                    break;
                case 4:
                    int maxoa;
                    Console.WriteLine("ma can xoa:");
                    maxoa = int.Parse(Console.ReadLine());
                    ql.xoaSV(maxoa);
                    break;
                case 5:
                    ql.sapXepTheoMa();
                    break;
                case 6:
                    int maSua;
                    Console.Write("Nhap ma sinh vien can sua: ");
                    maSua = int.Parse(Console.ReadLine());
                    ql.suaSV(maSua);
                    break;
                default:
                    Console.WriteLine("Ban nhap sai");
                    break;
            }
        } while (true);
    }
}
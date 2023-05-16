using System;

public class Program
{
    public static void Main()
    {
        ChuyenDoiTienTe();
    }

    private static void HienThiLoiChao() 
    {
        Console.WriteLine("Enter your name: ");

        string yourName = Console.ReadLine();

        Console.WriteLine("Xin Chao: " + yourName);
    }

    private static void ChuyenDoiTienTe()
    {
        Console.WriteLine("Nhap So USD can chuyen doi: ");
        string usdInput = Console.ReadLine();

        if (int.TryParse(usdInput, out int usd))
        {
            int tiGiaQuyDoi = 23000;
            int tienQuyDoi = usd * tiGiaQuyDoi;
            Console.WriteLine("So Tien Quy doi la: " + tienQuyDoi);
        }
        else
        {
            Console.WriteLine("Nhap vao mot so USD hop le.");
        }
    }
}
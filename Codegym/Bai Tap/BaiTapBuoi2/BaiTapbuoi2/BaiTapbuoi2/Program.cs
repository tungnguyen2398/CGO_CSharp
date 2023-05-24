namespace BaiTapbuoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChuyenChuThanhSo();
        }

        static void ChuyenChuThanhSo() 
        {
            {
               
                Console.Write("Nhap so: ");
                string input = Console.ReadLine();
                int dodai = input.Length;   // <=3
                if (dodai == 3)
                {
                    int hangtram = int.Parse(input.Substring(0, 1));
                    switch (hangtram)
                    {
                        case 1: Console.Write("Mot tram "); break;
                        case 2: Console.Write("Hai tram "); break;
                            //.... tuong tu cho toi so 9
                    }
                    int hangchuc = int.Parse(input.Substring(1, 1));
                    switch (hangchuc)
                    {
                        case 0: Console.Write(""); break;
                        case 1: Console.Write("muoi "); break;
                        case 2: Console.Write("hai muoi "); break;
                            //.... tuong tu cho toi so 9
                    }
                    int donvi = int.Parse(input.Substring(2, 1));
                    switch (donvi)
                    {
                        case 0: Console.Write(""); break;
                        case 1: Console.Write("mot"); break;
                        case 2: Console.Write("hai"); break;
                            //.... tuong tu cho toi so 9
                    }
                }
                if (dodai == 2)
                {
                    int hangchuc = int.Parse(input.Substring(0, 1));
                    switch (hangchuc)
                    {
                        case 1: Console.Write("muoi "); break;
                        case 2: Console.Write("hai muoi "); break;
                            //.... tuong tu cho toi so 9
                    }
                    int donvi = int.Parse(input.Substring(1, 1));
                    switch (donvi)
                    {
                        case 0: Console.Write(""); break;
                        case 1: Console.Write("mot"); break;
                        case 2: Console.Write("hai"); break;
                            //.... tuong tu cho toi so 9
                    }
                }
                if (dodai == 1)
                {
                    int donvi = int.Parse(input.Substring(0, 1));
                    switch (donvi)
                    {
                        case 0: Console.Write(""); break;
                        case 1: Console.Write("mot"); break;
                        case 2: Console.Write("hai"); break;
                            //.... tuong tu cho toi so 9
                    }
                }
                Console.ReadKey();
            }

        }
    }
}
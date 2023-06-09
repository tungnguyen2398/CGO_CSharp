namespace DemKyTuXuatHien
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Nhap vao mot so can xoa khoi mang:");
            int num = int.Parse(Console.ReadLine());
            bool found = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    found = true;
                    for (int j = i; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    Array.Resize(ref arr, arr.Length - 1);
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Da xoa phan tu {0} khoi mang.", num);
                Console.WriteLine("Mang sau khi xoa:");
                foreach (int item in arr)
                {
                    Console.Write("{0} ", item);
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay phan tu {0} trong mang.", num);
            }

            Console.ReadLine();
        }
    }
}
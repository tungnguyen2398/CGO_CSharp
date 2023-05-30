using System;

class Program
{
    static void Main()
    {
        //ThemPhanTu();
        //TimSoLonNhat();
        TinhTong();
    }

    private static void ThemPhanTu()
    {
        Console.WriteLine("Nhập số phần tử của mảng:");
        int N = int.Parse(Console.ReadLine());

        int[] arr = new int[N];

        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Phần tử thứ {i}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Nhập giá trị cần chèn:");
        int value = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập vị trí cần chèn:");
        int position = int.Parse(Console.ReadLine());

        if (position < 0 || position > N)
        {
            Console.WriteLine("Vị trí không hợp lệ!");
        }
        else
        {
            Array.Resize(ref arr, N + 1);

            for (int i = N; i > position; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[position] = value;

            Console.WriteLine("Mảng sau khi chèn:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }


    private static void TimSoLonNhat()
    {
        Console.WriteLine("Nhập số hàng của ma trận:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập số cột của ma trận:");
        int columns = int.Parse(Console.ReadLine());

        double[,] matrix = new double[rows, columns];

        Console.WriteLine("Nhập các phần tử của ma trận:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Phần tử [{i}, {j}]: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double maxValue = double.MinValue;
        int maxRow = 0;
        int maxColumn = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] > maxValue)
                {
                    maxValue = matrix[i, j];
                    maxRow = i;
                    maxColumn = j;
                }
            }
        }

        Console.WriteLine($"Giá trị lớn nhất: {maxValue}");
        Console.WriteLine($"Tọa độ: [{maxRow}, {maxColumn}]");
    }

    private static void TinhTong()
    {
        Console.WriteLine("Nhập kích thước của ma trận vuông:");
        int size = int.Parse(Console.ReadLine());

        double[,] matrix = new double[size, size];

        Console.WriteLine("Nhập các phần tử của ma trận:");

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"Phần tử [{i}, {j}]: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double sum = 0;

        for (int i = 0; i < size; i++)
        {
            sum += matrix[i, i];
        }

        Console.WriteLine($"Tổng của các số trên đường chéo chính: {sum}");
    }
}
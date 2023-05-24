namespace BaiTapBuoi3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HienThi();
        }

        static void HienThi() 
        {
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle");
            Console.WriteLine("3. Print isosceles triangle");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else if (choice == 2) 
            {
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine() ;
                }
            }

            else if(choice == 3)
            {
                for (int i = 7; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine() ;
                }
            }
            else
            {
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
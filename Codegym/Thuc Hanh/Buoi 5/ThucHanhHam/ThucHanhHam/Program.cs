namespace ThucHanhHam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Chuyen F thanh C");
            Console.WriteLine("2.Chuyen C thanh F");

            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap gia tri can chuyen: ");
            
            double value = int.Parse(Console.ReadLine());

            if(choice == 2 )
            {
                Console.Write((9.0 / 5) * value + 32);
            } else if (choice == 1 )
            {
                Console.Write((5.0 / 9) * (value - 32));
            }
            Console.ReadKey();
        }
    }
}
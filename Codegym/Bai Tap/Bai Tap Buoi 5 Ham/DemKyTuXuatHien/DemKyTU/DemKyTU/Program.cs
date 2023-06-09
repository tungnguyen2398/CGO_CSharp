namespace DemKyTU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot chuoi:");
            string inputString = Console.ReadLine();
            Console.WriteLine("Nhap vao mot ky tu can dem so lan xuat hien:");
            char inputChar = char.Parse(Console.ReadLine());

            int count = 0;
            foreach (char c in inputString)
            {
                if (c == inputChar)
                {
                    count++;
                }
            }

            Console.WriteLine("So lan xuat hien cua ky tu {0} trong chuoi '{1}' la {2}.", inputChar, inputString, count);
            Console.ReadLine();
        }
    }
}
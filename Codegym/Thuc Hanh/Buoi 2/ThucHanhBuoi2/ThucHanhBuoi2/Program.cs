namespace ThucHanhBuoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            num();
        }

        static void PhuongTrinhBacNhat()
        {
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                double solution = -b / a;
                Console.Write("The solution is: {0}!", solution);
            }
            else
            {
                if (b == 0)
                {
                    Console.Write("The solution is all x!");
                }
                else
                {
                    Console.Write("Nod solution!");
                }
            }
        }

        static void TinhCanNang()
        {
            double height;
            double weight;
            Console.WriteLine("Please enter a height");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your weight");
            weight = float.Parse(Console.ReadLine());
            double bmi = weight / Math.Pow(height, 2);
            bmi = Math.Round(bmi, 1);

            Console.Write("BMI: " + bmi);

            if (bmi < 18)
                Console.WriteLine(" Underweight");
            else if (bmi < 25.0)
                Console.WriteLine(" Normal");
            else if (bmi < 30.0)
                Console.WriteLine(" Overweight");
            else
                Console.WriteLine(" Obese");
        }

        static void num()
        {
            Console.WriteLine("Nhap 1 so bat ky lon hon 3");
            int num = int.Parse(Console.ReadLine());

            while (num <= 3)
            {
                Console.Write("so vua nhap nho hon 3");
                num = int.Parse(Console.ReadLine());
            }
            Console.Write(num);
        }
    }
}
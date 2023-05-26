using System.Security.Cryptography.X509Certificates;

namespace SnakeGame
{
    internal class Program
    {
        public Random random = new Random();
        public ConsoleKeyInfo keypress = new ConsoleKeyInfo();
        int score, headX, headY, fruitX, fruitY, nTail;
        int[] TailX = new int[100];
        int[] TailY = new int[100];
        bool gameOver, reset, isprinted, horizontal, vertical;
        const int height = 20;
        const int width = 60;
        const int panel = 10;
        string dir, pre_dir;

        static void Main(string[] args)
        {

        }


        static void ShowBanner()
        {
            Console.SetWindowSize(width, height + panel);
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("PRESS ENTER TO START!");

            keypress = Console.ReadKey();
        }

        static void Setup()
        {

        }

        static void randomQua()
        {

        }

        static void Update()
        {

        }

        static void CheckInput()
        {

        }

        static void Logic()
        {

        }

        static void Render()
        {

        }

        static void Lose()
        {

        }     
    };
};
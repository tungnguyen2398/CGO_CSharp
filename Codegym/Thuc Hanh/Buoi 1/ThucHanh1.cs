﻿using System;

namespace UsingOperator
{
    class Program
    {
        static void Main(string[] args)
        {

            SuDungToanTu();
        }

        private static void HienNgayGio()
        {
            DateTime localDate = DateTime.Now;
            System.Console.WriteLine("Datetime Now is :" + localDate);
            Console.ReadKey();
        }

        private static void SuDungToanTu() 
        {
            float width;
            float height; Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine("Area is: " + area);
            Console.ReadKey();
        }
    }
}
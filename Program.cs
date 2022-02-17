﻿using System;

namespace linesProblemfinal
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Co-ordinates of 1st Line");
            double line1Length = Main2();
            Console.WriteLine("Enter Co-ordinates of 2nd Line");
            double line2Length = Main2();
            int result = line1Length.CompareTo(line2Length);

            switch (result)
            {
                case 0:
                    Console.WriteLine("Two lines are equal");
                    break;
                case 1:
                    Console.WriteLine("Line 1 is greater than Line 2");
                    break;
                default:
                    Console.WriteLine("Line 2 is greater than Line 1");
                    break;
            }
        }
        public static double Main2()
        {
            Console.Write("Value of the X1:");
            double valueOfX1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Value of the X2:");
            double valueOfY1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Value of the Y1:");
            double valueOfX2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Value of the Y2:");
            double valueOfY2 = Convert.ToDouble(Console.ReadLine());
            double lengthOfALine =Math.Pow(Math.Pow(valueOfX2 - valueOfY1, 2) + Math.Pow(valueOfX2 + valueOfY1, 2),0.5);
            return lengthOfALine;
            
            //Console.WriteLine(lengthOfALine);

        }
    }
}

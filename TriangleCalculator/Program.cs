using System;

namespace TriangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the three sides of the triangle:");
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double side3 = double.Parse(Console.ReadLine());

            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                double perimeter = side1 + side2 + side3;
                double p = perimeter / 2;
                double area = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));

                Console.WriteLine("The perimeter of the triangle is " + perimeter);
                Console.WriteLine("The area of the triangle is " + area);
            }
            else
            {
                Console.WriteLine("The input lengths do not form a triangle.");
            }

            Console.ReadLine();
        }
    }
}

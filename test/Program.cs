using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1, operand2, result = 0;
            char op;

            Console.Write("Enter the first operand: ");
            operand1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the operator (+, -, *, /): ");
            op = char.Parse(Console.ReadLine());

            Console.Write("Enter the second operand: ");
            operand2 = double.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    result = operand1 + operand2;
                    break;
                case '-':
                    result = operand1 - operand2;
                    break;
                case '*':
                    result = operand1 * operand2;
                    break;
                case '/':
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Error: division by zero");
                        return;
                    }
                    result = operand1 / operand2;
                    break;
                default:
                    Console.WriteLine("Error: invalid operator");
                    return;
            }

            Console.WriteLine($"{operand1} {op} {operand2} = {result}");
        }
    }
}
using System;
namespace dxs
{
    class Dxs
    {
        static void Main()
        {
            double x, y;
            Console.WriteLine("请输入X的值：");
            x = Convert.ToDouble(Console.ReadLine());
            y = 3 * x * x * x * x - 2 * x * x * x - x * x + 10;
            Console.WriteLine("{0:f1}", y);
        }
    }
}
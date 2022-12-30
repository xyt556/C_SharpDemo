using System;
namespace cal
{
    class Cal
    {
        static void Main(string[] args)
        {
            //while 语句实现
            double e = 1.0;
            double u = 1.0;
            int n = 1;
            while (u >= 1.0E-20)
            {
                u = u / n;
                e = e + u;
                n = n + 1;
            }
            Console.WriteLine("while 语句实现的结果：");
            Console.WriteLine("e = {0} ( n = {1} )", e, n);

            //do-while 语句实现
            e = 1.0;
            u = 1.0;
            n = 1;
            do
            {
                u = u / n;
                e = e + u;
                n = n + 1;
            } while (u >= 1.0E-20);
            Console.WriteLine("do while 语句实现的结果：");
            Console.WriteLine("e = {0} ( n = {1} )", e, n);
        }
    }
}
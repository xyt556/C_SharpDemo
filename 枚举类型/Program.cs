using System;

namespace test
{
    public enum TimeofDay  //枚举类型定义
    {
        Morning=1,
        Afternoon,
        Evening
    }
    struct A  //结构类型定义
    {
        public int x;  //不能直接对其进行赋值
        public int y;
        public static string str = null;  //静态变量可以初始化
        public A(int x, int y)//带参数的构造函数
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("x= {0},y={1},str={2}", x, y, str);
        }
    }
    class Pro
    {
        static void WriteGreeting(TimeofDay timeofDay)  //静态方法
        {
            switch (timeofDay)
            {
                case TimeofDay.Morning:
                    Console.WriteLine("Good Morning!");
                    break;
                case TimeofDay.Afternoon:
                    Console.WriteLine("Good Afternoon!");
                    break;
                case TimeofDay.Evening:
                    Console.WriteLine("Good Evening!");
                    break;
            }
        }
        static void Main(string[] args)
        {
            WriteGreeting(TimeofDay.Morning);
            WriteGreeting(TimeofDay.Afternoon);
            WriteGreeting(TimeofDay.Evening);
            int i;
            i = 2;
            Console.WriteLine(i++);
            Console.WriteLine(i);
            Console.WriteLine(++i);
        }
    }
}
using System;
namespace test
{
    public enum TimeofDay  //枚举类型定义
    {
        Morning=1,
        Afternoon,
        Evening
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
        }
    }
}
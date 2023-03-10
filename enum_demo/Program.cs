using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_demo
{
    public class Program
    {
        enum DaysOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public enum TimeofDay //枚举类型定义 06：	
        {

            Morning = 1,
            Afternoon,
            Evening
        }
        static void WriteGreeting(TimeofDay timeofDay)  //静态方法
        {
            switch (timeofDay)
            {
                case TimeofDay.Morning:
                    Console.WriteLine("Hi, goodmorning"); break;
                case TimeofDay.Afternoon: 
                    Console.WriteLine("Hi, goodafternoon"); break;
                case TimeofDay.Evening: 
                    Console.WriteLine("Hi, goodevening"); break;
            }
        }
        public static void Main()
        {
            // 使用枚举类型变量DaysOfWeek
            DaysOfWeek today = DaysOfWeek.Wednesday;
            Console.WriteLine("Today is {0}", today);
            // 枚举类型变量可以转换为整数
            int dayNumber = (int)today;
            Console.WriteLine("The day number for {0} is {1}", today, dayNumber);
            // 使用枚举类型变量timeofDay
            WriteGreeting(TimeofDay.Morning);
            WriteGreeting(TimeofDay.Evening);
            WriteGreeting(TimeofDay.Afternoon);

        }
    }
}




// 使用枚举类型的值作为 switch 语句的条件
//switch (today)
//{
//    case DaysOfWeek.Monday:
//        Console.WriteLine("Today is Monday");
//        break;
//    case DaysOfWeek.Tuesday:
//        Console.WriteLine("Today is Tuesday");
//        break;
//    case DaysOfWeek.Wednesday:
//        Console.WriteLine("Today is Wednesday");
//        break;
//    case DaysOfWeek.Thursday:
//        Console.WriteLine("Today is Thursday");
//        break;
//    case DaysOfWeek.Friday:
//        Console.WriteLine("Today is Friday");
//        break;
//    case DaysOfWeek.Saturday:
//        Console.WriteLine("Today is Saturday");
//        break;
//    case DaysOfWeek.Sunday:
//        Console.WriteLine("Today is Sunday");
//        break;
//    default:
//        Console.WriteLine("Invalid day");
//        break;
//}
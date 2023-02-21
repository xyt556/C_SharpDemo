using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_demo
{
    // 定义一个Person类
    public class Person
    {
        // 成员变量
        private string name;
        private int age;

        // 构造函数
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // 成员方法
        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {name}, and I'm {age} years old.");
            Console.ReadKey();
        }
    }

    // 测试程序
    class Program
    {
        static void Main(string[] args)
        {
            // 创建Person对象
            Person p1 = new Person("Tom", 20);
            Person p2 = new Person("xyt", 30);

            // 调用Person对象的SayHello方法
            p1.SayHello();
            p2.SayHello();
        }
    }
}

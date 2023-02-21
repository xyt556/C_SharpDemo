using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_demo
{
    struct Person
    {
        public string Name;
        public int Age;
        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", Name, Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 创建一个 Person 实例
            Person person = new Person();
            person.Name = "Alice";
            person.Age = 30;
            // 调用实例方法
            person.Display();
            // 修改实例字段的值
            person.Age = 31;
            // 调用实例方法
            person.Display();
        }
    }
}

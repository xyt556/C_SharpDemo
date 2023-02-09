using System;
namespace IO
{
    class Pro
    {
        static void Main(string[] args)
        {
            char ch;
            int x;
            x = Console.Read();//读取字符，返回字符的Unicode编码值给变量x
            ch = Convert.ToChar(x);//将Unicode编码转换成对应字符给变量ch
            Console.WriteLine("The char is:{0}", ch);
            char c = 'c';
            int d = 10;
            Console.Write(true);//使用重载方式1输出bool型值
            Console.Write(c);//使用重载方式2输出字符
            Console.Write(d);//使用重载方式6输出int型值
            Console.Write("Hello world!");//输出重载方式10输出字符串
            Console.Write("{0:x}",d);//将d值按照十六进制形式输出，输出： a
            //
            
            Console.WriteLine(true);//输出bool型值后回车换行
            Console.WriteLine(c);//输出字符后回车换行
            Console.WriteLine(d);//输出int型值后回车换行
            Console.WriteLine("Hello world!");//输出字符串后回车换行
            Console.WriteLine("{0:x}", d);//将d值按十六进制输出后回车换行   Console.WriteLine();//输出一个空行

        }
    }
}
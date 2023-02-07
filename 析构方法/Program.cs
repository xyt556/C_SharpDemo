namespace ConsoleApplication11
{
    public class A
    {
        int x = 2;
        public A(int b)
        {
            x = b;
            Console.WriteLine("构造方法被调用{0}", x);
        }
        ~A()
        {
            Console.WriteLine("析构方法被调用{0}", x);
        }
    }
    class Pro
    {
        static void Main(string[] args)
        {
            A x = new A(3);
            A y = new A(5);
            string s1,s2,result;//定义三个变量
            s1 = Console.ReadLine();//输入第一个字符串给s1
            s2 = Console.ReadLine();//输入第二个字符串给s2
            result = s1 + " "+s2;//对两个字符串进行首尾相接后给result
            Console.WriteLine("{0}+{1}={2}",s1,s2,result);//输出
        }
    }
}

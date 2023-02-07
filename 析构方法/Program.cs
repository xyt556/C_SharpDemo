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
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(Math.PI);
            Console.WriteLine("13==oxD:{0}",int.Equals(13,0xD));
        }
    }
}

namespace xyt
{
    class pro
    {
        static void Main(string[] args)
        {
            //int? i;
            //double? d1 = 3.14;
            //bool? flag = null;
            //char? letter = 'a';
            //使用可空类型变量时，C#提供了两/*种方法测试变量值是否为null以避免变量的错误引用。
            //方法1
            int? num = null;
            if (num.HasValue == true)
            {
                Console.WriteLine("num = " + num.Value);

            }
            else
            {
                Console.WriteLine("num = null");
            }
            //方法2
            int? y = 10;
            if (y !=null)
            {
                Console.WriteLine("y = " + y.Value);

            }
            else
            {
                Console.WriteLine("y = null");
            }
        }
    }
        
}
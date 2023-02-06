class BaseClass
{
    private static int CallCounter;
    static BaseClass()
    {
        CallCounter = 2;
        Console.WriteLine("Static CallCounter{0}", CallCounter);
    }
    public BaseClass()
    {
        CallCounter++;
        Console.WriteLine(" CallCounter{0}", CallCounter);
    }
    static void Main(string[] args)
    {
        BaseClass b1 = new BaseClass();
        BaseClass b2 = new BaseClass();
        BaseClass b3 = new BaseClass();
    }
}
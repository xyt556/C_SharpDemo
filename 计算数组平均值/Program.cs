class Program
{
    static double average(params int[] arr)
    {
        double answer = 0.0;
        foreach (int x in arr)
            answer += x;
        return answer / arr.Length;
    }
    public static void Main()
    {
        int[] a = { 1, 2, 3, 6, 7 };
        Console.WriteLine("{0}", average(a)); //数组a作实参
        Console.WriteLine("{0}", average(1, 2, 3)); //3整数作实参
        Console.WriteLine("{0}", average(1, 1, 3, 5, 7));//5整数作实参
    }
}

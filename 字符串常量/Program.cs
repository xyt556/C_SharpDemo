using System;
class StringExample
{
    static void Main()
    {
        Console.WriteLine("hello, world!");
        Console.WriteLine("Hello \u000A world!");
        Console.WriteLine(@"Hello \u000A world!");
        Console.WriteLine("Joe said \t\"Hello\"\n to me");
        Console.WriteLine(@"Joe said \t""Hello""\n to me");
    }
}
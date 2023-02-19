using System;

class Program
{
    static void Main()
    {
        Console.Write("请输入一个正整数：");
        int n = int.Parse(Console.ReadLine());
        string result = CalculateFactorial(n);
        Console.WriteLine("{0}! = {1}", n, result);
        int zeroCount = CountTrailingZeros(result);
        Console.WriteLine("{0}! 的末尾0的个数为：{1}", n, zeroCount);
    }

    // 计算阶乘
    static string CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return "1";
        }

        string result = "1";
        for (int i = 2; i <= n; i++)
        {
            result = Multiply(result, i.ToString());
        }

        return result;
    }

    // 字符串相乘
    static string Multiply(string num1, string num2)
    {
        int len1 = num1.Length;
        int len2 = num2.Length;
        int len = len1 + len2;
        int[] tmp = new int[len];

        for (int i = len1 - 1; i >= 0; i--)
        {
            int carry = 0;
            for (int j = len2 - 1; j >= 0; j--)
            {
                int val = (num1[i] - '0') * (num2[j] - '0') + carry + tmp[i + j + 1];
                tmp[i + j + 1] = val % 10;
                carry = val / 10;
            }
            tmp[i] += carry;
        }

        string result = "";
        int index = 0;
        while (index < len - 1 && tmp[index] == 0)
        {
            index++;
        }
        for (int i = index; i < len; i++)
        {
            result += tmp[i];
        }

        return result;
    }

    // 统计末尾0的个数
    static int CountTrailingZeros(string num)
    {
        int count = 0;
        for (int i = num.Length - 1; i >= 0; i--)
        {
            if (num[i] == '0')
            {
                count++;
            }
            else
            {
                break;
            }
        }
        return count;
    }
}

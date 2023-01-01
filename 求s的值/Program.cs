/*Title: 求s的值
Description: 求s = 1 + 1 / ! + 1 / 3! + 1 / 4! + …，要求累加的最后一项小于0 .00001。结果小数点后面保留6位小数。
Input: 无输入
Output: 输出s的值
sample_input:
sample_output:
1.7188
分析本题的数列会发现：
（1）首项的值为1；
（）其后每一项的值都是前一项的值除以当前项数。
*/
using System;
class pro
{
    static void Main()
    {
        double sum = 1, e = 1, cnt = 1;//第一项作为循环初始状态
        Console.WriteLine("While 循环实现：");
        while (e >= 0.00001)
        {
            cnt++;
            e = e / cnt;
            sum = sum + e;
        }
        Console.WriteLine("{0:f6}", sum);
        Console.WriteLine("For 循环实现：");
        sum = 0; e = 1;
        for (int i = 1; i <= 10; i++)
        {
            e = e / i;
            sum = sum + e;
        }
        Console.WriteLine("{0:f6}", sum);

    }
}
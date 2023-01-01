/*Title: 截钢管
Description: 有一根长为n米的钢管（n >= 44），要将它截取成两种规格的短钢管，规格的长度分别为17米和7米，每种至少一段，问分割成7米多少段？分割成17米多少段？剩余的残料为多少？（要求残料最少）
Input: 输入n的值（n为正整数）
Output: 输出7米钢管的根数、17米钢管的根数、残料为多少。
sample_input:
100
sample_output:
3 1 2

本题借助循环结构进行各种方案枚举，挑选剩余最少的方案。*/

using System;
class pro
{
    static void Main()
    {
        int n, x = 0,x1 = 0, y = 0,y1 = 0,z = 16;//x为17米的段数，y为27米的段数，z为剩余的长度
        n = Convert.ToInt32(Console.ReadLine());
        //使用两层for循环枚举出所有的截钢管方案
        for (x = 1; x <= n / 17; x++)
            for (y = 1; y <= (n - 17 * x) / 27; y++)
            {
                if (z > n - 17 * x - 27 * y)
                {
                    x1 = x; y1 = y; z = n - 17 * x - 27 * y;//记录更好方案
                }
            }
        Console.WriteLine("27米钢管的根数：{0}\n17米钢管的根数：{1}\n残料为：{2}", y1, x1, z);
    }
}
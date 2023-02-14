using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入杨辉三角形的行数：");
            int n = int.Parse(Console.ReadLine());
            int[][] pascalTriangle = new int[n][];

            for (int i = 0; i < n; i++)
            {
                pascalTriangle[i] = new int[i + 1];
                pascalTriangle[i][0] = 1;
                pascalTriangle[i][i] = 1;
                for (int j = 1; j < i; j++)
                {
                    pascalTriangle[i][j] = pascalTriangle[i - 1][j - 1] + pascalTriangle[i - 1][j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(pascalTriangle[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

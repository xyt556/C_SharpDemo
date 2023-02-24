using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 杨辉三角1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numRows = 10; // 杨辉三角的行数
            int[][] triangle = new int[numRows][];

            // 初始化交错数组，每行的长度为行数
            for (int i = 0; i < numRows; i++)
            {
                triangle[i] = new int[i + 1];
            }

            // 计算杨辉三角每个位置的值
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        triangle[i][j] = 1;
                    }
                    else
                    {
                        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                    }
                }
            }

            // 输出杨辉三角
            for (int i = 0; i < numRows; i++)
            {
                // 计算每行前面的空格数量
                int numSpaces = numRows - i - 1;

                // 输出空格
                for (int j = 0; j < numSpaces; j++)
                {
                    Console.Write(" ");
                }

                // 输出每行的数字
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(triangle[i][j] + " ");
                }

                Console.WriteLine();
            }

        }
    }
}

using System;
namespace yh
{
    class Yh
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入行数");
            int rows = int.Parse(Console.ReadLine());
            //初始化二维数组
            int[][] nums = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                nums[i] = new int[i + 1];
            }
            //边界赋值
            for (int i = 0; i < rows; i++)
            {
                nums[i][0] = 1;
                nums[i][i] = 1;
            }
            //中心值赋值
            for (int i = 2; i < rows; i++) //控制行数
            {
                for (int j = 1; j < i; j++) //控制列数
                {
                    nums[i][j] = nums[i - 1][j] + nums[i - 1][j - 1]; //每一列的值等于上一行的列+上一行的列-1的值
                }
            }
            //输出
            for (int i = 0; i < rows; i++)
            {
                //打印空格
                for (int k = 0; k < rows - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(nums[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}

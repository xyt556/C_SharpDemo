using System;
namespace cal
{
    class Program
    {
        const int M = 3, N = 4; //定义常量
        static void Main(string[] args)
        {
            int[,] a = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int[,] b = new int[,] { { 1, 4, 7, 10 }, { 2, 5, 8, 11 }, { 3, 6, 9, 12 } };
            int[,] c = new int[M, N]; //创建M行N列二维数组c
                                      //矩阵求和
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    c[i, j] = a[i, j] + b[i, j];
            //按M行N列输出矩阵a,每个数据占4位宽度
            Console.WriteLine("矩阵a是：");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write("{0,4}", a[i, j]);
                Console.WriteLine();
            }
            //按M行N列输出矩阵b,每个数据占4位宽度
            Console.WriteLine("矩阵b是：");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                    Console.Write("{0,4}", b[i, j]);
                Console.WriteLine();
            }
            //按M行N列输出矩阵c,每个数据占4位宽度
            Console.WriteLine("结果矩阵是：");
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                    Console.Write("{0,4}", c[i, j]);
                Console.WriteLine();
            }
        }
    }
}
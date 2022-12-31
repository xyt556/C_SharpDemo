/*
Title: 作业问题
Description: 小霖原计划每天写M小时作业，N天可以完成。现在由于有其他安排，需要将作业提前X天完成，请问她每天写Y小时作业可以完成么？
Input: 输入M,N,X,Y四个正整数
Output: 输出“yes”或“no”，分别代表能够完成或不能够完成
sample_input:
3 15 5 4
sample_output:
no*/
using System;
class pro
{
    static void Main()
    {
        string[] st = Console.ReadLine().Split(' ');
        int M, N, X, Y;
        M = Convert.ToInt32(st[0]);
        N = Convert.ToInt32(st[1]);
        X = Convert.ToInt32(st[2]);
        Y = Convert.ToInt32(st[3]);
        if (M * N <= Y * (N - X)) Console.WriteLine("yes");
        else Console.WriteLine("no");
    }
}

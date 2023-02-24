using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    internal class Program
    {
        static void PrintArr(int[] arr)
        {
            foreach (int x in arr) Console.Write("{0} ", x);
            Console.WriteLine();
        }

        static void Reverse(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
        static void Reverse1(int[] arr)
        {
            int len = arr.Length;   //求数组的长度  for (int i = 0; i < len / 2; i++)
            for (int i = 0; i < len / 2; i++)
            { 
                int temp;
                temp = arr[i];
                arr[i] = arr[len - i - 1];
                arr[len - i - 1] = temp;
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("数组初值：");
            PrintArr(arr); 
            Reverse1(arr);
            Console.WriteLine("逆置后的数组值：");
            PrintArr(arr);

        }
    }
}

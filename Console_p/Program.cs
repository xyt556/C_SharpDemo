using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_p
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("参数个数：{0}", args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
            }
        }
    }

}

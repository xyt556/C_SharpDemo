using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcd
{
    internal class Pro
    {
        public int gcd(int m, int n) //使用欧几里德算法求最大公约数
        {
            int r;
            while (n != 0)
            { //欧几里德算法，原理是：
                r = m % n; //r为m/n的余数
                m = n; //则gcd(m,n)=gcd(n,r)=...
                n = r; //r=0时n即是gcd
            }
            return m;
        }
        public int lcm(int m, int n)//使用枚举法求最小公倍数
        {
            for (int i = m > n ? m : n; i <= m * n; i++)
                if (i % m == 0 && i % n == 0) return i;
            return m * n;

        }
    }
}


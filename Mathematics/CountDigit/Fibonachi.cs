using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class Fibonachi
    {
        public int fibo1(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }           
            return fibo1(n - 1) + fibo1(n - 2);
        }

        public int fibo2(int n)
        {
            int[] f = new int[n + 1];
            f[0] = 0;
            f[1] = 1;
            for(int i = 2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }
            Console.WriteLine("time complexity and space compelxity is @(n) ");
            return f[n];
        }

        public int fibo3(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            int a = 0;
            int b = 1;
            int c = 0;
            for(int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine("time complexity is @(n) and space compelxity @(1)");
            return c;

        }
    }
}

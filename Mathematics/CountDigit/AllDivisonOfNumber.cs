using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class AllDivisonOfNumber
    {
        public void alldivisor1(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void alldivisor2(int n)
        {
            for (int i = 1; i*i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    if (i != n / i)
                    {
                        Console.WriteLine(n / i);
                    }
                }
                
            }
        }

        public void alldivisor3(int n)
        {
            int i = 0;
            for ( i = 1; i * i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for (; i>= 1; i--)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(n/i);
                }
            }
        }
    }
}

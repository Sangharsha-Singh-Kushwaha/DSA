using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class PrimeFactor
    {
        public void primefactor1(int n)
        {
            if (n <= 1)
            {
                return;
            }
            for(int i = 2; i*i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i);
                    n = n / i;
                }
                
            }
            if (n > 1)
            {
                Console.WriteLine(n);
            }
        }

        public void primefactor2(int n)
        {
            if (n <= 1)
            {
                return;
            }
            while (n % 2 == 0)
            {
                Console.WriteLine(2);
                n = n / 2;
            }
            while (n % 3 == 0)
            {
                Console.WriteLine(3);
                n = n / 3;
            }
            for (int i = 5; i * i <= n; i=i+6)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i);
                    n = n / i;
                }
                while (n % i + 2 == 0)
                {
                    Console.WriteLine(i);
                    n = n / i;
                }

            }
            if (n > 3)
            {
                Console.WriteLine(n);
            }
        }
    }
}

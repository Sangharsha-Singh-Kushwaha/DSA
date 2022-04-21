using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class Factorial
    {
        public int factorial(int n)
        {
            int fact = 1;
            for(int i = 2; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("time complexity is O(n) and space complexity is tehta(1)");
            return fact;
        }

        public int factorialRecursion(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * factorialRecursion(n - 1);
        }

        public int TrailingZeroInFactorial(int n)
        {
            long  fact = 1;
            int Count = 0;
            for (int i = 2; i <= n; i++)
            {
                fact = fact * i;
            }
            while (fact % 10 == 0)
            {
                Count++;
                fact = fact / 10;
            }
            Console.WriteLine("time complexity is O(n) and space complexity is tehta(1)");
            return Count;
        }

        public int CountTrailingZero(int n)
        {
            int Count = 0;
            for (int i = 5; i <= n; i=i*5)
            {
                Count = Count + n / i;
            }
            Console.WriteLine("time complexity is O(log^n) and space complexity is tehta(1)");
            return Count;
        }
    }
}

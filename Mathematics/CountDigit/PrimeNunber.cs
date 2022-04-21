using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class PrimeNunber
    {
        public bool IsPrime1(int n)
        {
            if (n == 1)
            {
                return false;
            }
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            Console.WriteLine("TC is O(n)");
            return true;
        }

        public bool IsPrime2(int n)
        {
            if (n == 1)
            {
                return false;
            }
            for (int i = 2; i*i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            Console.WriteLine("TC is O(n^1/2)");
            return true;
        }

        public bool IsPrime3(int n)
        {
            if (n == 1)
            {
                return false;
            }
            if(n==2 || n == 3)
            {
                return true;
            }
            if(n%2==0 || n % 3 == 0)
            {
                return false;
            }
            for(int i = 5; i*i < n; i = i + 6)
            {
                if(n%i==0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }
            Console.WriteLine("TC is less than 3 times of O(n^1/2)");
            return true;
        }
    }
}

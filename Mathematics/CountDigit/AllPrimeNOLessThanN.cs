using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class AllPrimeNOLessThanN
    {
        public bool IsPrime(int n)
        {
            if (n == 1)
            {
                return false;
            }
            if (n == 2 || n == 3)
            {
                return true;
            }
            if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            for (int i = 5; i * i < n; i = i + 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public void AllPrineNumber(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }


        public void SieveOfEratosthenes(int n)
        {
            bool[] prime = new bool[n + 1];
            for (int m = 2; m <= n; m++)
                prime[m] = true;

            for (int i = 2; i * i <= n; i++)
            {

                if (prime[i])
                {
                    for (int j =2*i; j <= n; j +=i)
                        prime[j] = false;
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (prime[i])
                    Console.Write(i + " ");
            }
        }

        public void SieveOfEratosthenesIMPORTANT(int n)
        {
            bool[] prime = new bool[n + 1];
            for (int m = 2; m <= n; m++)
                prime[m] = true;

            for (int i = 2; i<= n; i++)
            {

                if (prime[i])
                {
                    Console.Write(i + " ");
                    for (int j = i * i; j <= n; j += i)
                        prime[j] = false;
                }
            }
        }
    }
}

	




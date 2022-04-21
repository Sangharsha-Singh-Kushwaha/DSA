using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class GCD
    {
        public int gcd(int n1,int n2)
        {
            int least =Math.Min(n1, n2);
            while (least > 0)
            {
                if(n1%least==0 && n2 % least == 0)
                {
                    break;
                }
                least--;
            }
            Console.WriteLine("T.C is O(min(n1,n2)) and S.C is @(1)");
            return least;
        }

        public int gcdByEuclideanAlgo(int n1, int n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            return gcdByEuclideanAlgo(n2, n1 % n2);
        }
    }
}

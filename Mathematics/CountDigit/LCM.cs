using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class LCM
    {
        public int lcm1(int n1,int n2)
        {
            int max = Math.Max(n1, n2);
            while (true)
            {
                if(max%n1==0 && max%n2 == 0)
                {
                    break;
                }
                max++;
            }
            Console.WriteLine("T.C is O(n1*n2- max(n1,n2)) and S.C is 1");
            return max;
        }

        public int lcm2(int n1, int n2)
        {
            int gcd(int a, int b)
            {
                if (b == 0)
                {
                    return a;
                }
                return gcd(b, a % b);
            }
            Console.WriteLine("T.C is O(log(min(a,b)) and S.C is o(n)");
            return ((n1 * n2) / gcd(n1,n2));
        }
    }
}

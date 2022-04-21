using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class Power
    {
        public int power1(int n1,int n2)
        {
            int res = 1;
            if (n2 == 0)
            {
                return 1;
            }
            if (n2 == 1)
            {
                return n1;
            }
            for (int i=1;i<=n2;i++)
            {
                res = res * n1;
            }
            return res;
        }

        public int power2(int n1, int n2)
        {
            
            if (n2 == 0)
            {
                return 1;
            }
            if (n2 == 1)
            {
                return n1;
            }
            int temp = power2(n1, n2 / 2);
            temp = temp * temp;
            if (n2 % 2 == 0)
            {
                return temp;
            }
            else
            {
                return temp * 3;
            }
        }

        public int power3(int n1, int n2)
        {
            int res = 1;
            while (n2 > 0)
            {
                if (n2 % 2 != 0)
                {
                    res = res * n1;
                }
                n1 = n1 * n1;
                n2 = n2 / 2;
            }
            return res;
        }

       


    }
}

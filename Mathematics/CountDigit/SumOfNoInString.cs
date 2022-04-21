using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class SumOfNoInString
    {
        public long solve(string A)
        {
            long sum = 0;
            char[] delimiterChars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string[] a = A.Split(delimiterChars);
            int l = a.Length;
            for (int i = 0; i < l; i++)
            {
                if (a[i].Length > 0)
                {
                    long n = (long)(Convert.ToInt32(a[i]));
                    sum = sum + n;
                }
            }
          return sum;
        }
    }
}

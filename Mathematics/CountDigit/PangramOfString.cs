using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class PangramOfString
    {
        public int solve(List<string> A)
        {

            int sum = 0;
            List<char> l = new List<char>();
            foreach(string s in A)
            {
                s.ToLower();
                
                char[] spliter = { ',' };
                string []ss=s.Split(spliter);
                for (int i = 0; i < ss.Length; i++)
                {
                    string temp = ss[i];
                    for (int j = 0; j < temp.Length; j++)
                    {
                        char charat = temp[temp.Length - 1 - j];
                        if (!l.Contains(charat))
                        {
                            l.Add(charat);
                        }
                    }
                    
                    
                }
            }
            if (l.Count == 26)
            {
                return sum=1;
            }
            return sum ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge223
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(garland("programmer"));
            Console.WriteLine(garland("alfalfa"));

            Console.WriteLine(chain("onion", 3));
            Console.ReadKey();
        }

        static int garland(string s)
        {
            int degree = 0;

            for (int i = 1; i < s.Length; i++) {
                var start = s.Substring(0, i);
                var end = s.Substring(s.Length - i, i);

                if (start == end) 
                    degree = i;                
            }

            return degree;
        }

        static string chain(string s, int times)
        {
            StringBuilder sb = new StringBuilder(s);
            int degree = garland(s);

            for (int i = 0; i < times; i++) {
                sb.Append(s.Substring(degree));
            }

            return sb.ToString();
        }
    }
}

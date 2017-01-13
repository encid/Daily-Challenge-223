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

            Console.ReadKey();
        }

        static int garland(string input)
        {
            int degree = 0;

            for (int i = 1; i < input.Length; i++) {
                var start = input.Substring(0, i);
                var end = input.Substring(input.Length - i, i);

                if (start == end) 
                    degree = i;                
            }

            return degree;
        }
    }
}

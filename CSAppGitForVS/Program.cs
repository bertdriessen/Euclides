using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAppGitForVS
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Call recursive method with two parameters.
            //
            //int count = 0;
            //int total = Recursive(5, ref count);
            //
            // Write the result from the method calls and also the call count.
            //
            //Console.WriteLine(total);
            //Console.WriteLine(count);


            // bereken grootste gemene deler
            var deler = ggd(22, 8);
            Console.WriteLine("Groote gemene deler {0}", deler);
        }

        static int Recursive(int value, ref int count)
        {
            count++;
            if (value >= 10)
            {
                // throw new Exception("End");
                return value;
            }
            return Recursive(value + 1, ref count);
        }

        private static int ggd(int a, int b)
        {
            if (a == b)
                return a;
            else
                if (a < b)
                    return ggd(a, b - a);
                else
                    return ggd(a - b, b);
        }
    }
}

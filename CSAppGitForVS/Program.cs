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
            // bereken grootste gemene deler
            var deler = ggd(22, 8);
            Console.WriteLine("Groote gemene deler {0}", deler);
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

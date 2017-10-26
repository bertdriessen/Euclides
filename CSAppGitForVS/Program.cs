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
            Console.WriteLine("voer getal 1 in ");
            string line1 = Console.ReadLine();
            int value1;
            if (int.TryParse(line1, out value1)) // Try to parse the string as an integer
            {
                //Console.WriteLine(value1);
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }
            Console.WriteLine("voer getal 2 in ");
            string line2 = Console.ReadLine();
            int value2;
            if (int.TryParse(line2, out value2)) // Try to parse the string as an integer
            {
                //Console.WriteLine(value2);
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }

            // bereken grootste gemene deler
            var deler = ggd(value1, value2);
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

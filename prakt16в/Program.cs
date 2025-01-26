using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt16в
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int f = 0; f < 6; f++)
            {
                for (int s = 0; s <= f; s++)
                {
                    Console.Write("5 ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

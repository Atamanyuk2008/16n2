using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt16г
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;


            for (int r = rows; r >= 1; r--)
            {

                for (int w = 0; w < r; w++)
                {

                    Console.Write("1 ");
                }


                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}

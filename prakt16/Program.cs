using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Printline1();

            Console.WriteLine();
            Printline2();

            Console.WriteLine();
            Printline3();

            Console.WriteLine();
            Printline4();
            Console.Read();
        }
        static void Printline1()
        {
            for (int a = 1; a <= 10; a++)
            {
                Console.Write(a + "\t");
            }
            Console.WriteLine();
        }
        static void Printline2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
        static void Printline3()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
        static void Printline4()
        {
            for (int k = 1; k <= 10; k++)
            {
                Console.Write(k + "\t");
            }
            Console.WriteLine();
        }
    }

}
 

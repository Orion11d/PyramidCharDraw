using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            PyramidDraw(size);
            Console.ReadKey(true);
        }

        static void PyramidDraw(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = i; j <= x; j++)
                {
                    Console.Write(" ");
                }
                for (int z = 1; z <= 2*i - 1; z++)
                {
                    Console.Write("*" + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

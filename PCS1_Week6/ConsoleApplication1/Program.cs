using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_2

{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            Console.WriteLine("Hello. This program will calculate \"X to the power of Y\".\n");

            do
            {
                Console.Write("Please enter X: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nPlease enter Y: ");
                y = Convert.ToInt32(Console.ReadLine());

            } while (x < 0 || y < 0);

            Console.WriteLine("\nI am calculating the power!\n");

            for (int i = 1; i < y; i++)
            {
                Console.WriteLine("{0} to the power of {1} is {3}", x, i, Math.Pow(x, i));
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

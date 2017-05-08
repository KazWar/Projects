using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 1;
            int choice = 1;
            List<int> list = new List<int>();


            list.Add(time + choice);
            Console.WriteLine("{0}", list.Average());

            list.Min();



            string roomNo;

        Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}

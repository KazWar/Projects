using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = new List<int>();

            Console.Write("How many multiples of 10 do you want?: ");
            var amount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= amount; i++)
            {
                listOfIntegers.Add(10*i);
            }

            Console.Write("\nPlease enter an option number.\n 1 : for no sort \n 2 : for regular sort \n 3 : for reverse sort \n 4 : to clear the list \n");
            var optionNumber = Convert.ToInt32(Console.ReadLine());

            switch (optionNumber)
            {

                case 1:
                    break;
                case 2:
                    listOfIntegers.Sort();
                    break;
                case 3:
                    listOfIntegers.Reverse();
                    break;
                case 4:
                    listOfIntegers.Clear();
                    break;
                default:
                    break;
            }

            if (listOfIntegers.Count() != 0)
            {
                foreach (var number in listOfIntegers)
                {
                    Console.WriteLine(number.ToString());
                }
            }
            else
            {
                Console.WriteLine("There are no elements in this list!");
            }

            Console.WriteLine("\nPress any key to exit ...");
            Console.ReadKey();
        }
    }
}

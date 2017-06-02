using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static List<object> listOfClientAccounts = new List<object> {
            new ClientAccount("Mary","Jane"),
            new ClientAccount("Bob","Henrikson"),
            new ClientAccount("Henrico","Donato", "La"),
            new ClientAccount("Harry","Hamun", "Ho")
        };

        static int choice;
        static void Main(string[] args)
        {
            bool IsValidated = false;

            Console.WriteLine("Bank Application");
            Console.WriteLine("\nList of availible accounts:");
            MethodController.showListOfAccounts(listOfClientAccounts);

            do
            {
                Console.Write("\nWhich account do you want to select?: ");

                //Implement Key press detection
                choice = Convert.ToInt32(Console.ReadLine());
                MethodController.Validate(choice, listOfClientAccounts, IsValidated);

                
            } while (IsValidated == false);

            MethodController.ShowClientOverview(listOfClientAccounts.ElementAtOrDefault(listOfClientAccounts.FindIndex(a => a.ClientNumber == choice)));
            Console.ReadLine();
        }
    }
}

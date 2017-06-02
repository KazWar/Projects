using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class MethodController
    {
        public static void Deposit(decimal amount, BankAccount bankAccount)
        {
            bankAccount.Balance += amount;
        }

        public static void Withdraw(decimal amount, BankAccount bankAccount)
        {
            bankAccount.Balance -= amount;
        }

      

        public static void showListOfAccounts(List<object> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void ShowClientOverview(ClientAccount chosenBankAccount)
        {
            Console.WriteLine("Client Name: ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void Validate(int choice, dynamic targetList, bool IsValidated)
        {
            if (Convert.ToBoolean(targetList.Exists() == true))
            {
                IsValidated = true;
            }
            else
            {
                Console.WriteLine("\nPlease enter a valid account number from the list below.");
                MethodController.showListOfAccounts(targetList);
            }
        }
    }
}

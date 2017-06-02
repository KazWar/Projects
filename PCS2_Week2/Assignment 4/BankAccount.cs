using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class BankAccount
    {
        private int BaseAccountNumber = 10000;
        public int AccountNumber { get; set; }
        public int ClientNumber { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(int clientNumber)
        {
            AccountNumber = BaseAccountNumber;
            ClientNumber = clientNumber;
            BaseAccountNumber++;
        }

        public override string ToString()
        {
            return String.Format("Account no: {0}", AccountNumber);
        }

    }
}
   

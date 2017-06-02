using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class ClientAccount
    {
        private int BaseClientAccountNumber = 20000;

        public int Number { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string FullName {
            get
            {
                return String.Concat(this.FirstName,  " " , this.MiddleName, " ", this.LastName);
            }
        }

        public ClientAccount(string firstName, string lastName, string midName = "")
        {
            Number = BaseClientAccountNumber;
            FirstName = firstName;
            MiddleName = midName;
            LastName = lastName;
            BaseClientAccountNumber++;
        }


        public override string ToString()
        {
            return String.Format("Account number: {0} | Owner: {1} ", Number, FullName);
        }

    }
}

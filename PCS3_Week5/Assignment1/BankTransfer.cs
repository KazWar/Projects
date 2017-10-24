using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    /// <summary>
    /// If your object has some cleanup/closing code, which HAS to be executed always,
    /// whether there was an exception or not - such as closing files, database connections,
    /// disconnecting sockets, writing logs, printing output - always make it implement IDisposable 
    /// and use it with 'using' pattern. In this case, all your cleanup code has to be contained
    /// inside Dispose method. 
    /// </summary>
    public class BankTransfer : IDisposable
    {
        private List<string> Operations = new List<string>();

        public void Dispose()
        {
            WriteAuditTrail();
        }

        public void Transfer(string from, string to, decimal amount)
        {
            // get cash from source
            // add case to target
            // write audit entries
            Operations.Add(String.Format("{0} transferred from {1} to {2}", amount, from, to));
        }

        public void WriteAuditTrail()
        {
            // save operations to audit file
            // clean
            Operations.Clear();
        }
    }

    public class Banker
    {
        public void DoBankingStuff_Paranoid()
        {
            BankTransfer transfer = null;
            try
            {
                transfer = new BankTransfer();
                transfer.Transfer("1", "2", 340);
                transfer.Transfer("2", "3", 1000);
            }
            catch (Exception e)
            {
               // log exception etc.
            }
            finally
            {
                if (transfer != null)
                {
                    transfer.WriteAuditTrail();
                }
            }
        }


        public void DoBankingStuff()
        {
            using (var transfer = new BankTransfer())
            {
                transfer.Transfer("1", "2", 340);
                transfer.Transfer("2", "3", 1000);
            }
        }
    }
}

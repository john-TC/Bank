using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class Account
    {
        public int AccountNo { get; set; }
        public double Balance { get; set; }

        public string BalSummary
        {
            get
            {
                return $"{AccountNo}: {Balance.ToString("c")}";
            }
        }

        public void Deposit(double val)
        {

        }

        public void Withdrawl(double val)
        {

        }

        public int IncrementAcct()
        {
            return AccountNo += 1;
        }
    }
}

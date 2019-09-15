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
        public double OverdraftTotal { get; set; }
        public double OverdraftRemaining { get; set; }

        public string BalSummary
        {
            get
            {
                return
                    $"No: {AccountNo} -" +
                    $"Bal: {Balance.ToString("c")}," +
                    $"Overdraft Total: {OverdraftTotal}," +
                    $"Overdraft Remaining: {OverdraftRemaining}";
            }
        }
        public void Deposit(double val)
        {
            Balance += val;
        }
        public bool Withdrawl(double val)
        {
            if (Balance + OverdraftTotal - val < 0)
            {
                return false;
            }
            else
            {
                Balance -= val;
                return true;
            }
        }
        public int IncrementAcct()
        {
            return AccountNo += 1;
        }
        public void AddOverdraft(double val)
        {
            OverdraftTotal = val;
        }
        public void DeleteOverdraft()
        {
            OverdraftTotal = 0;
        }
    }
}

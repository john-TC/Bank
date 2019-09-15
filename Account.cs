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
                    $"Overdraft Total: {OverdraftTotal.ToString("c")}," +
                    $"Overdraft Remaining: {OverdraftRemaining.ToString("c")}";
            }
        }
        public void Deposit(double val)
        {
            if (Balance < 0 && Balance >= OverdraftTotal * -1)
            {
                Balance += val;
                OverdraftRemaining = Balance + OverdraftTotal;
            }
            else
            {
                OverdraftRemaining = OverdraftTotal;
                Balance += val;
            }
        }
        public void Withdrawl(double val)
        {
            if (Balance + OverdraftTotal - val >= 0)
            {
                if (Balance - val < 0 && Balance - val >= OverdraftTotal * -1)
                {
                    Balance -= val;
                    OverdraftRemaining = Balance + OverdraftTotal;
                }
                else
                {
                    OverdraftRemaining = OverdraftTotal;
                    Balance -= val;
                }
            }
        }
        public int IncrementAcct()
        {
            return AccountNo += 1;
        }
        public void AddOverdraft(double val)
        {
            OverdraftTotal = val;
            OverdraftRemaining = OverdraftTotal;
        }
        public void DeleteOverdraft()
        {
            OverdraftTotal = 0;
        }
    }
}

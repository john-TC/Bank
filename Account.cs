﻿using System;
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
        public string ErrorMessage { get; private set; }

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
                if (Balance > 0)
                {
                    OverdraftRemaining = OverdraftTotal;
                }
                else
                {
                    OverdraftRemaining = Balance + OverdraftTotal;
                }
            }
            else
            {
                Balance += val;
            }
        }
        public bool Withdrawl(double val)
        {
            bool success = true;
            if (Balance + OverdraftTotal - val >= 0)
            {
                if (Balance - val < 0 && Balance - val >= OverdraftTotal * -1)
                {
                    Balance -= val;
                    OverdraftRemaining = Balance + OverdraftTotal;
                }
                else
                {
                    Balance -= val;
                }
            }
            else
            {
                ErrorMessage = "Withrawl limit reached.";
                success = false;
            }
            return success;
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
            OverdraftRemaining = 0;
        }
    }
}

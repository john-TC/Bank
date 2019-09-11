using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BankingApp
{
    public partial class frmAcct : Form
    {
        const int INITIAL_ACCT_NO = 100;
        BindingList<Account> acctList = new BindingList<Account>();

        public frmAcct()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Account newAccount = new Account()
            {
                AccountNo = acctList.Count != 0 ? acctList[acctList.Count - 1].AccountNo + 1 : INITIAL_ACCT_NO,
                Balance = double.Parse(txtBal.Text)
            };

            acctList.Add(newAccount);
            listAccounts.DataSource = acctList;
            listAccounts.DisplayMember = "BalSummary";
            //For future use with CSV file
            listAccounts.ValueMember = "AccountNo";
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        { 
            acctList[listAccounts.SelectedIndex].Deposit(double.Parse(txtAmount.Text));

            listAccounts.DataSource = null;
            listAccounts.DataSource = acctList;
            listAccounts.DisplayMember = "BalSummary";
            //For future use with CSV file
            listAccounts.ValueMember = "AccountNo";
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            //acctList[listAccounts.SelectedIndex].w
        }
    }
}

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
        List<Account> acct = new List<Account>();

        public frmAcct()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Account newAccount = new Account() {
                AccountNo = INITIAL_ACCT_NO,
                Balance = double.Parse(txtBal.Text)
            };
            acct.Add(newAccount);

            listAccounts.DataSource = acct;
            listAccounts.DisplayMember = "BalSummary";

        }
        
    }
}

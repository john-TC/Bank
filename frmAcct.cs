﻿using System;
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
        private void RefreshList()
        {
            listAccounts.DataSource = null;
            listAccounts.DataSource = acctList;
            listAccounts.DisplayMember = "BalSummary";
            //For future use with CSV file
            listAccounts.ValueMember = "AccountNo";
        }
        private void ClearError()
        {
            lblErrors.Text = "";
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            ClearError();
            try
            {
                if (double.Parse(txtBal.Text) < 0)
                {
                    lblErrors.Text = "Value cannot be less than 0.";
                }
                else
                {
                    Account newAccount = new Account()
                    {
                        AccountNo = acctList.Count != 0 ? acctList[acctList.Count - 1].AccountNo + 1 : INITIAL_ACCT_NO,
                        Balance = double.Parse(txtBal.Text)
                    };
                    acctList.Add(newAccount);
                    RefreshList();
                }
            }
            catch (System.FormatException)
            {
                lblErrors.Text = "Enter a valid number.";
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ClearError();
                acctList.Remove(acctList[listAccounts.SelectedIndex]);
                RefreshList();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                lblErrors.Text = "Please select an item.";
            }
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            ClearError();
            try
            {
                if (double.Parse(txtAmount.Text) < 0)
                {
                    lblErrors.Text = "Value cannot be less than 0.";
                }
                else
                {
                    acctList[listAccounts.SelectedIndex].Deposit(double.Parse(txtAmount.Text));
                    RefreshList();
                }
            }
            catch (System.FormatException)
            {
                lblErrors.Text = "Enter a valid number.";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                lblErrors.Text = "Please select an item.";
            }
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            ClearError();
            try
            {
                if (double.Parse(txtAmount.Text) < 0)
                {
                    lblErrors.Text = "Value cannot be less than 0.";
                }
                else
                {
                    if (!acctList[listAccounts.SelectedIndex].Withdrawl(double.Parse(txtAmount.Text)))
                    {
                        lblErrors.Text = acctList[listAccounts.SelectedIndex].ErrorMessage;
                    }
                    else
                    {
                        acctList[listAccounts.SelectedIndex].Withdrawl(double.Parse(txtAmount.Text));
                        RefreshList();
                    }
                }
            }
            catch (System.FormatException)
            {
                lblErrors.Text = "Enter a valid number.";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                lblErrors.Text = "Please select an item.";
            }
        }
        private void btnCreateOverdraft_Click(object sender, EventArgs e)
        {
            ClearError();
            try
            {
                if (double.Parse(txtOverdraft.Text) < 0)
                {
                    lblErrors.Text = "Value cannot be less than 0.";
                }
                else
                {
                    acctList[listAccounts.SelectedIndex].AddOverdraft(double.Parse(txtOverdraft.Text));
                    RefreshList();
                }
            }
            catch (System.FormatException)
            {
                lblErrors.Text = "Enter a valid number.";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                lblErrors.Text = "Please select an item.";
            }
        }
        private void BtnDeleteOverdraft_Click(object sender, EventArgs e)
        {
            ClearError();
            try
            {
                acctList[listAccounts.SelectedIndex].DeleteOverdraft();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                lblErrors.Text = "Please select an item.";
            }
            RefreshList();
        }
    }
}

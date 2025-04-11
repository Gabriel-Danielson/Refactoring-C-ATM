using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    
    public partial class frmActions : Form
    {

        //Properties
        private int CustomerNumber;
        private int FirstAccountNumber;
        private int SecondAccountNumber;
        private decimal FirstAccountBalance;
        private decimal SecondAccountBalance;
        private string Action;
        private string ReceivingAccount;

        //Constructor
        public frmActions(int customerNumber, int firstAccountNumber, int secondAccountNumber, decimal firstAccountBalance, decimal secondAccountBalance, string action, string receivingAccount)
        {
            InitializeComponent();
            CustomerNumber = customerNumber;
            FirstAccountNumber = firstAccountNumber;
            SecondAccountNumber = secondAccountNumber;
            FirstAccountBalance = firstAccountBalance;
            SecondAccountBalance = secondAccountBalance;
            Action = action;
            ReceivingAccount = receivingAccount;

            lbl_ActionsCustomerDisplay.Text = "Customer #: " + CustomerNumber;

            lbl_ActionsAccountDisplay.Text = "Account #: " + FirstAccountNumber;

            lbl_ActionsBalanceDisplay.Text = "Balance: $" + FirstAccountBalance.ToString("N2");

        }

        //Formats string for banking information display
        private void frmActions_Shown(object sender, EventArgs e)
        {
            string prompt = "How much do you want to ";

            if (Action == "Deposit")
            {
                prompt += "deposit into";
            }
            else if (Action == "Withdraw")
            {
                prompt += "withdraw from";
            }
            else if (Action == "Transfer")
            {
                prompt += "transfer from";
            }

            if (ReceivingAccount == "Checkings")
            {
                prompt += " your Checkings account?";
            }
            else if (ReceivingAccount == "Savings")
            {
                prompt += " your Savings account?";
            }

            lbl_UserPrompt.Text = prompt;
        }

        //Button to confirm bank account action
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            //Validation
            try
            {
                if (Action == "Deposit")
                {
                    if (txb_AmountMoving.Text == "")
                    {
                        MessageBox.Show("Please enter an amount to deposit.");
                    }
                    //Check if input is a valid decimal for money
                    else if (Convert.ToDecimal(txb_AmountMoving.Text) < 0.01m ||
                        Decimal.Round(Convert.ToDecimal(txb_AmountMoving.Text), 2) != Convert.ToDecimal(txb_AmountMoving.Text))
                    {
                        MessageBox.Show("Please enter a valid amount to deposit.");
                    }
                    else
                    {
                        decimal amountMoneyDepositing = Convert.ToDecimal(txb_AmountMoving.Text);
                        SQLHelper.DepositToAccount(FirstAccountNumber, FirstAccountBalance, amountMoneyDepositing);

                        this.Hide();
                        frmBanking fm = new frmBanking(CustomerNumber.ToString());
                        fm.Show();
                    }
                }
                else if (Action == "Withdraw")
                {
                    if (txb_AmountMoving.Text == "")
                    {
                        MessageBox.Show("Please enter an amount to withdraw.");
                    }
                    //Check if account will br overdrawn
                    else if (Convert.ToDecimal(txb_AmountMoving.Text) > FirstAccountBalance)
                    {
                        //Checks if there is enough money in both accounts to withdraw
                        if (ReceivingAccount == "Checkings" && Convert.ToDecimal(txb_AmountMoving.Text)
                            <= FirstAccountBalance + SecondAccountBalance)
                        {
                            //Overdraw feature
                            MessageBox.Show("Insufficient funds to withdraw. Using funds from Savings.");
                            decimal amountMoneyWithdrawing = Convert.ToDecimal(txb_AmountMoving.Text);
                            decimal amountRemoveSavings = amountMoneyWithdrawing - FirstAccountBalance;
                            decimal amountRemoveCheckings = amountMoneyWithdrawing - amountRemoveSavings;

                            SQLHelper.WithdrawFromAccount(FirstAccountNumber, FirstAccountBalance, amountRemoveCheckings);
                            SQLHelper.WithdrawFromAccount(SecondAccountNumber, SecondAccountBalance, amountRemoveSavings);

                            this.Hide();
                            frmBanking fm = new frmBanking(CustomerNumber.ToString());
                            fm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Insufficient funds to withdraw.");
                        }    
                    }
                    //Check if input is a valid decimal for money
                    else if (Convert.ToDecimal(txb_AmountMoving.Text) < 0.01m ||
                        Decimal.Round(Convert.ToDecimal(txb_AmountMoving.Text), 2) != Convert.ToDecimal(txb_AmountMoving.Text))
                    {
                        MessageBox.Show("Please enter a valid amount to withdraw.");
                    }
                    else
                    {
                        decimal amountMoneyWithdrawing = Convert.ToDecimal(txb_AmountMoving.Text);
                        SQLHelper.WithdrawFromAccount(FirstAccountNumber, FirstAccountBalance, amountMoneyWithdrawing);

                        this.Hide();
                        frmBanking fm = new frmBanking(CustomerNumber.ToString());
                        fm.Show();
                    }
                }
                else if (Action == "Transfer")
                {
                    if (txb_AmountMoving.Text == "")
                    {
                        MessageBox.Show("Please enter an amount to transfer.");
                    }
                    else if (Convert.ToDecimal(txb_AmountMoving.Text) > FirstAccountBalance)
                    //Check if account will br overdrawn
                    {
                        MessageBox.Show("Insufficient funds to transfer.");
                    }
                    //Check if input is a valid decimal for money
                    else if (Convert.ToDecimal(txb_AmountMoving.Text) < 0.01m ||
                        Decimal.Round(Convert.ToDecimal(txb_AmountMoving.Text), 2) != Convert.ToDecimal(txb_AmountMoving.Text))
                    {
                        MessageBox.Show("Please enter a valid amount to transfer.");
                    }
                    else
                    {
                        decimal amountMoneyTransferring = Convert.ToDecimal(txb_AmountMoving.Text);
                        //Account money is withdrawn from
                        SQLHelper.WithdrawFromAccount(FirstAccountNumber, FirstAccountBalance, amountMoneyTransferring);
                        //Account money is deposited into
                        SQLHelper.DepositToAccount(SecondAccountNumber, SecondAccountBalance, amountMoneyTransferring);

                        this.Hide();
                        frmBanking fm = new frmBanking(CustomerNumber.ToString());
                        fm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Button to cancel bank account action and return user to banking screen
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBanking fm = new frmBanking(CustomerNumber.ToString());
            fm.Show();
        }
    }
}
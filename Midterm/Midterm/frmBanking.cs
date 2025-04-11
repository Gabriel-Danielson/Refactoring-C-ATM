using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{

    public partial class frmBanking : Form
    {

        //Properties
        private string CustomerNumber;

        //Constructor
        public frmBanking(string customerNumber)
        {
            InitializeComponent();
            CustomerNumber = customerNumber;
            lbl_CustomerDisplay.Text = "Customer #: " + CustomerNumber;
        }

        //Button to logout and return to login screen
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin fl = new frmLogin();
            fl.Show();
        }


        //Gets variables needed to properly display banking information
        private void frmBanking_Shown(object sender, EventArgs e)
        {
           Customer customer = SQLHelper.GetCustomerInfo(CustomerNumber);

           Checkings checkingsAccount = SQLHelper.GetCheckingsAccount(customer.Checkings_Account_Number);
            Savings savingsAccount = SQLHelper.GetSavingsAccount(customer.Savings_Account_Number);

            lbl_CheckingsAccountLabel.Text = "Checkings Account (#" + checkingsAccount.Account_Number + ")";
            lbl_SavingsAccountLabel.Text = "Savings Account (#" + savingsAccount.Account_Number + ")";

            lbl_CheckingsBalanceDisplay.Text = "Balance: $" + checkingsAccount.Balance.ToString("N2");
            lbl_SavingsBalanceDisplay.Text = "Balance: $" + savingsAccount.Balance.ToString("N2");
        }

        //Button to deposit money into the checkings account
        private void btn_CheckingsDeposit_Click(object sender, EventArgs e)
        {
            //Declares what action is being taken to follow the correct change to the account
            string action = "Deposit";
            string receiving = "Checkings";

            Customer customer = SQLHelper.GetCustomerInfo(CustomerNumber);
            Checkings checkingsAccount = SQLHelper.GetCheckingsAccount(customer.Checkings_Account_Number);
            Savings savingsAccount = SQLHelper.GetSavingsAccount(customer.Savings_Account_Number);

            frmActions fm = new frmActions(customer.Customer_Number, customer.Checkings_Account_Number, customer.Savings_Account_Number, checkingsAccount.Balance, savingsAccount.Balance, action, receiving);
            this.Hide();
            fm.Show();
        }


        //Button to deposit money into the savings account
        private void btn_SavingsDeposit_Click(object sender, EventArgs e)
        {
            //Declares what action is being taken to follow the correct change to the account
            string action = "Deposit";
            string receiving = "Savings";

            Customer customer = SQLHelper.GetCustomerInfo(CustomerNumber);
            Savings savingsAccount = SQLHelper.GetSavingsAccount(customer.Savings_Account_Number);
            Checkings checkingsAccount = SQLHelper.GetCheckingsAccount(customer.Checkings_Account_Number);

            frmActions fm = new frmActions(customer.Customer_Number, customer.Savings_Account_Number, customer.Checkings_Account_Number, savingsAccount.Balance, checkingsAccount.Balance, action, receiving);
            this.Hide();
            fm.Show();
        }

        //Button to withdraw money from the checkings account
        private void btn_CheckingsWithdraw_Click(object sender, EventArgs e)
        {
            //Declares what action is being taken to follow the correct change to the account
            string action = "Withdraw";
            string receiving = "Checkings";

            Customer customer = SQLHelper.GetCustomerInfo(CustomerNumber);
            Checkings checkingsAccount = SQLHelper.GetCheckingsAccount(customer.Checkings_Account_Number);
            Savings savingsAccount = SQLHelper.GetSavingsAccount(customer.Savings_Account_Number);

            frmActions fm = new frmActions(customer.Customer_Number, customer.Checkings_Account_Number, customer.Savings_Account_Number, checkingsAccount.Balance, savingsAccount.Balance, action, receiving);
            this.Hide();
            fm.Show();
        }

        //Button to withdraw money from the savings account
        private void btn_SavingsWithdraw_Click(object sender, EventArgs e)
        {
            //Declares what action is being taken to follow the correct change to the account
            string action = "Withdraw";
            string receiving = "Savings";

            Customer customer = SQLHelper.GetCustomerInfo(CustomerNumber);
            Savings savingsAccount = SQLHelper.GetSavingsAccount(customer.Savings_Account_Number);
            Checkings checkingsAccount = SQLHelper.GetCheckingsAccount(customer.Checkings_Account_Number);

            frmActions fm = new frmActions(customer.Customer_Number, customer.Savings_Account_Number, customer.Checkings_Account_Number, savingsAccount.Balance, checkingsAccount.Balance, action, receiving);
            this.Hide();
            fm.Show();
        }

        //Button to transfer money from the checkings account
        private void btn_CheckingsTransfer_Click(object sender, EventArgs e)
        {
            //Declares what action is being taken to follow the correct change to the account
            string action = "Transfer";
            string receiving = "Checkings";

            Customer customer = SQLHelper.GetCustomerInfo(CustomerNumber);
            Checkings checkingsAccount = SQLHelper.GetCheckingsAccount(customer.Checkings_Account_Number);
            Savings savingsAccount = SQLHelper.GetSavingsAccount(customer.Savings_Account_Number);

            frmActions fm = new frmActions(customer.Customer_Number, customer.Checkings_Account_Number, customer.Savings_Account_Number, checkingsAccount.Balance, savingsAccount.Balance, action, receiving);
            this.Hide();
            fm.Show();
        }

        //Button to transfer money from the savings account
        private void btn_SavingsTransfer_Click(object sender, EventArgs e)
        {
            //Declares what action is being taken to follow the correct change to the account
            string action = "Transfer";
            string receiving = "Savings";

            Customer customer = SQLHelper.GetCustomerInfo(CustomerNumber);
            Savings savingsAccount = SQLHelper.GetSavingsAccount(customer.Savings_Account_Number);
            Checkings checkingsAccount = SQLHelper.GetCheckingsAccount(customer.Checkings_Account_Number);

            frmActions fm = new frmActions(customer.Customer_Number, customer.Savings_Account_Number, customer.Checkings_Account_Number, savingsAccount.Balance, checkingsAccount.Balance, action, receiving);
            this.Hide();
            fm.Show();
        }
    }
}

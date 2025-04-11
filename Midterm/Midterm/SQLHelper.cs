using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{

    internal class SQLHelper
    {

        /// <summary>Gets information to verify whether account login attempt was correct.</summary>
        /// <param name="inputtedCustomerNumber">User input for Customer Account Number</param>
        /// <param name="inputtedPIN">User input for Account PIN</param>
        /// <returns>an Dataset containing correct account details</returns>
        public static DataSet LoginToAccount(string inputtedCustomerNumber, string inputtedPIN)
        {
            string customerNumberAttempt = inputtedCustomerNumber;
            string pinAttempt = inputtedPIN;

            try
            {
                SqlConnection cnn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\12316\OneDrive - West Shore Community College\Programming II\Midterm\Midterm\CustomerDatabase.mdf"";Integrated Security = True; Connect Timeout = 30");
                cnn.Open();

                string sql = "SELECT * from tbl_Customers WHERE Customer_Number=@id and PIN=@pin";
                SqlCommand command = new SqlCommand(sql, cnn);
                command.Parameters.AddWithValue("@id", customerNumberAttempt);
                command.Parameters.AddWithValue("@pin", pinAttempt);
                SqlDataAdapter adapt = new SqlDataAdapter(command);
            
                DataSet loginDataSet = new DataSet();
                adapt.Fill(loginDataSet);
            
                command.Dispose();
                cnn.Close();
                return loginDataSet;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return new DataSet();
            }
        }

        /// <summary>Gets information about customer from a database.</summary>
        /// <param name="customerAccountNumber">Customer accound ID</param>
        /// <returns>an object containing all of the customer's info</returns>
        public static Customer GetCustomerInfo(string customerAccountNumber)
        {
            string customerNumber = customerAccountNumber;

            try
            {   SqlConnection cnn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\12316\OneDrive - West Shore Community College\Programming II\Midterm\Midterm\CustomerDatabase.mdf""; Integrated Security = True; Connect Timeout = 30");
                cnn.Open();

                string sql = "SELECT * FROM tbl_Customers WHERE Customer_Number = @CustomerAccountNumber";
                SqlCommand command = new SqlCommand(sql, cnn);
                command.Parameters.AddWithValue("@CustomerAccountNumber", customerNumber);
                SqlDataReader dataReader = command.ExecuteReader();


                Customer customer = null;

                while (dataReader.Read())
                {
                    customer = new Customer()
                    {
                        Customer_Number = (int)dataReader["Customer_Number"],
                        PIN = (int)dataReader["PIN"],
                        Checkings_Account_Number = (int)dataReader["Checkings_Account_Number"],
                        Savings_Account_Number = (int)dataReader["Savings_Account_Number"]
                    };
                }

                command.Dispose();
                cnn.Close();
                return customer;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return new Customer();
            }
        }

        /// <summary> Gets information about customer's checkings account from a database.</summary>
        /// <param name="checkingsAccountNumber">Checkings accound ID</param>
        /// <returns>an object containing all of the checkings account's info</returns>
        public static Checkings GetCheckingsAccount(int checkingsAccountNumber)
        {
            int checkingsNumber = checkingsAccountNumber;

            try
            {    SqlConnection cnn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\12316\OneDrive - West Shore Community College\Programming II\Midterm\Midterm\CustomerDatabase.mdf""; Integrated Security = True; Connect Timeout = 30");
                cnn.Open();

                string sql = "SELECT * FROM tbl_Account WHERE Account_Number = @CheckingsAccountNumber";
                SqlCommand command = new SqlCommand(sql, cnn);
                command.Parameters.AddWithValue("@CheckingsAccountNumber", checkingsNumber);
                SqlDataReader dataReader = command.ExecuteReader();

                Checkings checkingsAccount = null;

                while (dataReader.Read())
                {
                    checkingsAccount = new Checkings()
                    {
                        Checkings_Account_Number = (int)dataReader["Account_Number"],
                        Balance = (decimal)dataReader["Balance"]
                    };
                }

                command.Dispose();
                cnn.Close();
                return checkingsAccount;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return new Checkings();
            }
        }

        /// <summary> Gets information about customer's savings account from a database.</summary>
        /// <param name="savingsAccountNumber">Savings accound ID</param>
        /// <returns>an object containing all of the savings account's info</returns>
        public static Savings GetSavingsAccount(int savingsAccountNumber)
        {
            int savingsNumber = savingsAccountNumber;
            
            try
            {
                SqlConnection cnn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\12316\OneDrive - West Shore Community College\Programming II\Midterm\Midterm\CustomerDatabase.mdf""; Integrated Security = True; Connect Timeout = 30");
                cnn.Open();

                string sql = "SELECT * FROM tbl_Account WHERE Account_Number = @SavingsAccountNumber";
                SqlCommand command = new SqlCommand(sql, cnn);
                command.Parameters.AddWithValue("@SavingsAccountNumber", savingsNumber);
                SqlDataReader dataReader = command.ExecuteReader();

                Savings savingsAccount = null;

                while (dataReader.Read())
                {
                    savingsAccount = new Savings()
                    {
                        Savings_Account_Number = (int)dataReader["Account_Number"],
                        Balance = (decimal)dataReader["Balance"]
                    };
                }

                command.Dispose();
                cnn.Close();
                return savingsAccount;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return new Savings();
            }
        }

        /// <summary> Updated Account database with proper amount of money remaining after a specified deposit.</summary>
        /// <param name="accountNumber">The ID of the account being deposited into</param>
        /// <param name="currentAccountBalance">The current balance of the account being deposited into</param>
        /// <param name="amountMoneyDepositing">How many dollars is being deposited into the account</param>
        /// <returns>The amount of money remaining in the account after the deposit</returns>
        public static void DepositToAccount(int accountNumber, decimal currentAccountBalance, decimal amountMoneyDepositing)
        {
                int accountNum = accountNumber;
                decimal currentBalance = currentAccountBalance;
                decimal amountDepositing = amountMoneyDepositing;

                decimal updatedBalance = currentBalance + amountDepositing;
            try
            {
                SqlConnection cnn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\12316\OneDrive - West Shore Community College\Programming II\Midterm\Midterm\CustomerDatabase.mdf""; Integrated Security = True; Connect Timeout = 30");
                cnn.Open();

                string sql = "UPDATE tbl_Account SET Balance = @UpdatedBalance WHERE Account_Number = @AccountNumber";
                SqlCommand command = new SqlCommand(sql, cnn);
                command.Parameters.AddWithValue("@UpdatedBalance", updatedBalance);
                command.Parameters.AddWithValue("@AccountNumber", accountNum);
                command.ExecuteNonQuery();

                command.Dispose();
                cnn.Close();
                MessageBox.Show("Deposit to Account #" + accountNum + " for $" + amountDepositing + " was successful!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Withdraw from Account #" + accountNum + " was unsuccessful! " + ex.Message);
            }
        }

        /// <summary> Updated Account database with proper amount of money remaining after a specified withdrawal.</summary>
        /// <param name="accountNumber">The ID of the account being withdrawn from</param>
        /// <param name="currentAccountBalance">The current balance of the account being withdrawn from</param>
        /// <param name="amountMoneyDepositing">How many dollars is being withdrawn from the account</param>
        /// <returns>The amount of money remaining in the account after the withdrawal</returns>
        public static void WithdrawFromAccount(int accountNumber, decimal currentAccountBalance, decimal amountMoneyWithdrawing)
        {
            int accountNum = accountNumber;
            decimal currentBalance = currentAccountBalance;
            decimal amountWithdrawing = amountMoneyWithdrawing;

            decimal updatedBalance = currentBalance - amountWithdrawing;

            try
            {
                SqlConnection cnn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\12316\OneDrive - West Shore Community College\Programming II\Midterm\Midterm\CustomerDatabase.mdf""; Integrated Security = True; Connect Timeout = 30");
                cnn.Open();

                string sql = "UPDATE tbl_Account SET Balance = @UpdatedBalance WHERE Account_Number = @AccountNumber";
                SqlCommand command = new SqlCommand(sql, cnn);
                command.Parameters.AddWithValue("@UpdatedBalance", updatedBalance);
                command.Parameters.AddWithValue("@AccountNumber", accountNum);
                command.ExecuteNonQuery();

                command.Dispose();
                cnn.Close();
                MessageBox.Show("Withdraw from Account #" + accountNum + " for $" + amountWithdrawing + " was successful!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Withdraw from Account #" + accountNum + " was unsuccessful! " + ex.Message);
            }
        }
    }
}
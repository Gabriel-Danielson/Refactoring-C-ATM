using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{

    class Customer
    {
        //Fields
        private int _customerNumber;
        private int _pin;
        private int _checkingsAccountNumber;
        private int _savingsAccountNumber;

        //Constructor
        public Customer()
        {
            _customerNumber = 0;
            _pin = 0;
            _checkingsAccountNumber = 0;
            _savingsAccountNumber = 0;
        }

        //Properties
        public int Customer_Number
        {
            get { return _customerNumber; }
            set { _customerNumber = value; }
        }
        public int PIN
        {
            get { return _pin; }
            set { _pin = value; }
        }
        public int Checkings_Account_Number
        {
            get { return _checkingsAccountNumber ; }
            set { _checkingsAccountNumber = value; }
        }
        public int Savings_Account_Number
        {
            get { return _savingsAccountNumber; }
            set { _savingsAccountNumber = value; }
        }
    }
}
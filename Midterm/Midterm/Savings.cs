using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{

    internal class Savings : Customer
    {
        //Fields
        private int _accountNumber;
        private decimal _balance;

        //Constructor
        public Savings()
        {
            _accountNumber = 0;
        }

        //Properties
        public int Account_Number
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}
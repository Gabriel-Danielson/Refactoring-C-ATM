using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Midterm
{

    internal class Checkings : Customer
    {
        //Fields
        private int _accountNumber;
        private decimal _balance;

        //Constructor
        public Checkings()
        {
            _accountNumber = 0;
            _balance = 0;
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
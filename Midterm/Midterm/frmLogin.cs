using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Midterm
{

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Validation
            try
            {
                if (txb_CustomerNumber.Text == "" || txb_PIN.Text == "")
                {
                    MessageBox.Show("Please provide Customer Number and Password");
                }
                //Checks if either Customer Number or PIN is a positive whole number
                else if (Convert.ToDecimal(txb_CustomerNumber.Text) < 0m || (Convert.ToDecimal(txb_CustomerNumber.Text) % 1m) != 0m ||
                    Convert.ToDecimal(txb_PIN.Text) < 0m || (Convert.ToDecimal(txb_PIN.Text) % 1m) != 0m)
                {
                    MessageBox.Show("Please enter a valid Customer Number and Password.");
                }
                else
                {
                    DataSet loginDataSet = new DataSet();

                    loginDataSet = SQLHelper.LoginToAccount(txb_CustomerNumber.Text, txb_PIN.Text);
                    int count = loginDataSet.Tables[0].Rows.Count;
                    
                    //If count is equal to 1, than show frmMain form
                    if (count == 1)
                    {
                        MessageBox.Show("Account Login Successful!");
                        this.Hide();
                        frmBanking frm = new frmBanking(txb_CustomerNumber.Text);
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Account Login Failed!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

//Connection String 1 = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\Tim\OneDrive - West Shore Community College\Programming II\Midterm\Midterm\CustomerDatabase.mdf""; Integrated Security = True; Connect Timeout = 30"

//Connection String 2 = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\12316\OneDrive - West Shore Community College\Programming II\Midterm\Midterm\CustomerDatabase.mdf""; Integrated Security = True; Connect Timeout = 30"
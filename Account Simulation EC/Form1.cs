using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulation_EC
{
   
    public partial class bankaccountSimulator : Form
    {
        // BamkAccount field 
        private BankAccount account = new BankAccount(10000); // The acount starts with $10,000
        public bankaccountSimulator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Display Balance 
            balancecallabel.Text = account.Balance.ToString("c"); 
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal amount; 

            //Convert amount to decimal 
            if (decimal.TryParse(depositTextBox.Text, out amount))
            {
                // Deposit the amount into the account 
                account.Deposit(amount);

                // Display new balance 
                balancecallabel.Text = account.Balance.ToString("c");

                //Clear the textbox 
                depositTextBox.Clear(); 
            }

            else
            {
                // Display an error message 
                MessageBox.Show("Invaid Input. Please Try Again"); 
            }
        }

        private void withdrawlbutton_Click(object sender, EventArgs e)
        {
            decimal amount; 

            //Convert the amount to decimal 
            if (decimal.TryParse(withdrawTextBox.Text, out amount))
            {
                // Amount withdrawn from account 
                account.Withdraw(amount);

                // Display new balance 
                balancecallabel.Text = account.Balance.ToString("c");

                //Clear the textbox
                withdrawTextBox.Clear(); 
            }
            else
            {
                //Display an error message 
                MessageBox.Show("Invaid Input. Please Try Again");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit app 
            this.Close(); 
        }
    }
}

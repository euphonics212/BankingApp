using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class frmPayee : Form
    {
        public ATMConnector aTMConnector;
        public BankAccount myPayeeAccount;

        public BankAccount myLoggedinBankAccountUser;

        public frmPayee()
        {
            InitializeComponent();
        }

        //close the current window and open a new main form
        private void btnPayeeBack_Click(object sender, EventArgs e)
        {
            frmMain newfrmMain = new frmMain();
            newfrmMain.myLoggedinBankAccountUser = myLoggedinBankAccountUser;
            newfrmMain.aTMConnector = aTMConnector;
            newfrmMain.Show();
            this.Close();
        }

        private void frmPayee_Load(object sender, EventArgs e)
        {

            lbPayeeName.Text = myPayeeAccount.FirstName + " " + myPayeeAccount.LastName;
            lbPayeeAccNum.Text = myPayeeAccount.AccountNum;
         
        }

        //set the values for the numeric pad
        private void btn1_Click_1(object sender, EventArgs e)
        {
            txtBoxPayeeAmount.Text += "1";
       
        }
        private void btn2_Click_1(object sender, EventArgs e)
        {
            txtBoxPayeeAmount.Text += "2";
           
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            txtBoxPayeeAmount.Text += "3";
          
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            txtBoxPayeeAmount.Text += "4";
           
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            txtBoxPayeeAmount.Text += "5";
         
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            txtBoxPayeeAmount.Text += "6";
        
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            txtBoxPayeeAmount.Text += "7";
       
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            txtBoxPayeeAmount.Text += "8";
          
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            txtBoxPayeeAmount.Text += "9";
          
        }

        private void btn0_Click_1(object sender, EventArgs e)
        {
            txtBoxPayeeAmount.Text += "0";
            
        }

        //payee confirmation
        private void btnPayeeConfirm_Click(object sender, EventArgs e)
        {
            //balance of transfer
            double newBalance = 0;

            //if the customer has entered a value
            if (txtBoxPayeeAmount.Text != "")
            {
                //parse values
                double inputAmount = double.Parse(txtBoxPayeeAmount.Text);
                double accHolderBalance = myLoggedinBankAccountUser.Balance;
                string balance;

                //ensre the account has the available amount
                if (accHolderBalance > inputAmount)
                {
                    //confirmation of transfer
                    DialogResult res = MessageBox.Show("Transer €" + inputAmount.ToString() + " to " + lbPayeeName.Text, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        //newBalance is the difference of  account balance and the input value
                        newBalance = accHolderBalance - inputAmount;

                        //insert the new account balance
                        aTMConnector.updateAccntBalance(myLoggedinBankAccountUser.AccountNum, newBalance);
                      
                        //indicate the transfer was succesfull
                        MessageBox.Show("Transfer successful");

                      

                        string customer = aTMConnector.fetchCustomerGuidbyAccountNo(myLoggedinBankAccountUser.AccountNum);
                        string payee = aTMConnector.fetchCustomerGuidbyAccountNo(myPayeeAccount.AccountNum);

                        Guid firstguid = Guid.NewGuid();
                        string custNewGuid = firstguid.ToString();

                        var dateAndTime = DateTime.Now;
                        var date = dateAndTime.Date;

                        string formattedDate = date.ToString("ddMMyyyy").Substring(0, 8);

                        aTMConnector.insertIntoTransactions("InsertIntoTransactions", custNewGuid, customer, payee, -inputAmount, DateTime.Now.ToString("dd/MM/yyyy"));

                        Guid secondguid = Guid.NewGuid();
                        string payeeNewGuid = secondguid.ToString();

                        aTMConnector.insertIntoTransactions("InsertIntoTransactions", payeeNewGuid, payee, customer, inputAmount, DateTime.Now.ToString("dd/MM/yyyy"));

                        balance = "";
                        newBalance = 0.0;
                        accHolderBalance = 0.0;


                    }
                    //indicate the transfer was cancelled by the user
                    if (res == DialogResult.Cancel)
                    {
                        MessageBox.Show("Transaction cancelled");
                    }
                    

                }
                //indicate that the account has insuffiecient funds
                else
                {
                    MessageBox.Show("Insuffiecient Funds");
                }

                // if the balance is greater than 0 transfer the amount to the payees account
                if (newBalance >= 0)
                {
                    //new db connection
                    ATMConnector aTMConnector = new ATMConnector();
            

                    //get payyes account balance
                    aTMConnector.fetchAccountBalance("payeeAccBal", myPayeeAccount.AccountNum, myPayeeAccount);

                    //store the payee account balance
                    balance = aTMConnector.dataSet.Tables["payeeAccBal"].Rows[0]["balance"].ToString();
                
                    //parse the payee balance to a double
                    double payeeBalance = double.Parse(balance);

                    //add the transferred amount to the payee's account balance value
                    payeeBalance += inputAmount;

                    //update the database with the new balance
                    aTMConnector.updateAccntBalance(myPayeeAccount.AccountNum, payeeBalance);
                    
                }
                //close the form and return to a new main form window
                frmMain newfrmMain = new frmMain();
                newfrmMain.myLoggedinBankAccountUser = myLoggedinBankAccountUser;
                newfrmMain.aTMConnector = aTMConnector;
                newfrmMain.Show();
                this.Close();

            }

            //if no amount was entered
            else
            {
                MessageBox.Show("Please enter an amount");
            } 
        }

        //clear the amount in the textbox
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBoxPayeeAmount.Text = "";
        }
        // add a decimal point
        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtBoxPayeeAmount.Text += ".";
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string helpfilePath = Application.StartupPath;
            System.Diagnostics.Process.Start(helpfilePath + @"\BankingApp Help Files\index.html");
        }
    }
}

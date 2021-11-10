using System;
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
    public partial class frmMain : Form
    {   
       
        //global string to reference the account holder's account balance
        public static string accBalance;
        public ATMConnector aTMConnector;
        public BankAccount myLoggedinBankAccountUser;

        public string AccountNumber;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            //aTMConnector.decryptUserDatacrypt();


            //enable the timer that will animate the logo
            formMainTimer.Enabled = true;

            //get the account balance for the current user
            aTMConnector.fetchAccountBalance("accountBalance", myLoggedinBankAccountUser.AccountNum, myLoggedinBankAccountUser);

            //fill the textbox that indicates the account balance with the current users account balance
            accBalance = aTMConnector.dataSet.Tables["accountBalance"].Rows[0]["balance"].ToString();

            double accountBalance = double.Parse(accBalance);
            accountBalance = Math.Round(accountBalance, 2);

            //assign the account balance value
            textBoxMainBalance.Text = myLoggedinBankAccountUser.Balance.ToString();


            lblFullName.Text = myLoggedinBankAccountUser.FirstName;

            



        }

        //closes the application
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        //open the transfer window
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            frmTransfer frmTransfer = new frmTransfer();
            frmTransfer.myLoggedinBankAccountUser = myLoggedinBankAccountUser;
            frmTransfer.aTMConnector = aTMConnector;
            frmTransfer.Show();
            this.Close();
        }

        //opens account details window
        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            frmAccountDetails frmAccountDetails = new frmAccountDetails();
            frmAccountDetails.myLoggedinBankAccountUser = myLoggedinBankAccountUser;
            frmAccountDetails.aTMConnector = aTMConnector;
            frmAccountDetails.Show();
            this.Close();
        }

       //opens the bank statement window
        private void btnStatemnet_Click(object sender, EventArgs e)
        {
            frmStatement frmStatement = new frmStatement();
            frmStatement.aTMConnector = aTMConnector;
            frmStatement.myLoggedinBankAccountUser = myLoggedinBankAccountUser;
            frmStatement.Show();
            this.Close();
        }

        //method to animate the bank logo
        private void timerAnimateMainLogo_Tick(object sender, EventArgs e)
        {
            int x = mainLogo.Location.X;
            int y = mainLogo.Location.Y;

            mainLogo.Location = new Point(x, y + 3);

            if (mainLogo.Location.Y > 11)
                formMainTimer.Stop();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string helpfilePath = Application.StartupPath;
            System.Diagnostics.Process.Start(helpfilePath + @"\BankingApp Help Files\index.html");
        }

        private void textBoxMainBalance_MouseHover(object sender, EventArgs e)
        {
           
            textBoxMainBalance.Font = new Font(textBoxMainBalance.Font, FontStyle.Bold);
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.Font = new Font(btnCancel.Font, FontStyle.Bold);
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.Font = new Font(btnCancel.Font, FontStyle.Regular);
        }
    }
}

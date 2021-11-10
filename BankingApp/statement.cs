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
    public partial class frmStatement : Form
    {
        
        public BankAccount myLoggedinBankAccountUser;
        public ATMConnector aTMConnector;


        public frmStatement()
        {
            InitializeComponent();
        }

        private void btnPayeeBack_Click(object sender, EventArgs e)
        {
           

            frmMain newfrmMain = new frmMain();
            
            newfrmMain.aTMConnector = aTMConnector;
            newfrmMain.myLoggedinBankAccountUser = myLoggedinBankAccountUser;
            newfrmMain.Show();
            
            this.Close();
        }

        private void frmStatement_Load(object sender, EventArgs e)
        {
            
            lbAccountNum.Text = myLoggedinBankAccountUser.AccountNum;
            lbStatementName.Text = myLoggedinBankAccountUser.FirstName + " " + myLoggedinBankAccountUser.LastName;

            string customer = aTMConnector.fetchCustomerGuidbyAccountNo(myLoggedinBankAccountUser.AccountNum);
  
            aTMConnector.fetchBankTransActions("transactions", customer);
            dgTransactions.DataSource = aTMConnector.dataSet.Tables["transactions"];
            this.dgTransactions.Sort(this.dgTransactions.Columns["Transaction Num"], ListSortDirection.Descending);
            aTMConnector = new ATMConnector();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string helpfilePath = Application.StartupPath;
            System.Diagnostics.Process.Start(helpfilePath + @"\BankingApp Help Files\index.html");
        }
    }
}

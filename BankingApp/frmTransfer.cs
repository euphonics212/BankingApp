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
    public partial class frmTransfer : Form
    {
        public static string payeeAccNum;

        // for combobox payee, stops the datasource being populated twice because of object references bieng carried over
        public static bool payeeComboBoxIsFilled = false;

        public ATMConnector aTMConnector;
        public BankAccount myLoggedinBankAccountUser;
        public BankAccount myPayeeAccount = new BankAccount();

        public frmTransfer()
        {
            InitializeComponent();
        }

        
        private void frmTransfer_Load(object sender, EventArgs e)
        {

            if(payeeComboBoxIsFilled == false)
            {
                //get all listed payees
                aTMConnector.fetchPayees("customerPayees", myLoggedinBankAccountUser.AccountNum);
                payeeComboBoxIsFilled = true;
            }
            //fill the combo box with payees names 
            cmbBoxPayee.DataSource = aTMConnector.dataSet.Tables["customerPayees"];
            cmbBoxPayee.DisplayMember = "PAYFirst_name";


        }

        
        //closes the transfer window and opens a new frmMain object
        private void btTranserCancel_Click(object sender, EventArgs e)
        {
            frmMain newfrmMain = new frmMain();
            newfrmMain.myLoggedinBankAccountUser = myLoggedinBankAccountUser;
            newfrmMain.aTMConnector = aTMConnector;
            newfrmMain.Show();
            this.Close();
        }


        //connect to the database and get the selected payee's account details
        private void btnSelectPayee_Click(object sender, EventArgs e)
        {
            //string selected = this.cmbBoxPayee.GetItemText(this.cmbBoxPayee.SelectedItem);
            myPayeeAccount.FirstName = this.cmbBoxPayee.GetItemText(this.cmbBoxPayee.SelectedItem);

            aTMConnector.fetchPayeesAccountNum("payeeAccNum", myPayeeAccount.FirstName, myPayeeAccount);

            aTMConnector.fetchCustomerBankDetails("xxx", myPayeeAccount.AccountNum, myPayeeAccount);

            payeeAccNum = aTMConnector.dataSet.Tables["payeeAccNum"].Rows[0]["account_num"].ToString();
           
            frmPayee frmPayee = new frmPayee();
            frmPayee.myPayeeAccount = myPayeeAccount;
            frmPayee.myLoggedinBankAccountUser = myLoggedinBankAccountUser;
            frmPayee.aTMConnector = aTMConnector;
            frmPayee.Show();
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string helpfilePath = Application.StartupPath;
            System.Diagnostics.Process.Start(helpfilePath + @"\BankingApp Help Files\index.html");
        }
    }
}

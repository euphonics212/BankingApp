using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class frmAccountDetails : Form
    {
        //flag to identify the pin change
        bool isPinChanged = false;

        public BankAccount myLoggedinBankAccountUser;

        public ATMConnector aTMConnector;

        public frmAccountDetails()
        {
            InitializeComponent();
        }

        private void frmAccountDetails_Load(object sender, EventArgs e)
        {
            aTMConnector.fetchCustomerBankDetails("Login", myLoggedinBankAccountUser.AccountNum, myLoggedinBankAccountUser);

            txtBoxAcctDetailsFirstName.Text = myLoggedinBankAccountUser.FirstName;
            txtBoxAcctDetailsLastName.Text = myLoggedinBankAccountUser.LastName;
            txtBoxAcctDetailsAddress.Text = myLoggedinBankAccountUser.Address;
            txtBoxAcctDetailsPhoneNum.Text = myLoggedinBankAccountUser.PhoneNum;
            txtBoxAcctDetailsDOB.Text = myLoggedinBankAccountUser.DateOfBirth;

           
            //put focus on the first input field
            txtBoxAcctDetailsFirstName.Focus();
        }

        //exiting the window closes the current window, and opens a new main form object
        private void btnPayeeBack_Click(object sender, EventArgs e)
        {
            
            frmMain newfrmMain = new frmMain();
            newfrmMain.aTMConnector = aTMConnector;
            newfrmMain.myLoggedinBankAccountUser = myLoggedinBankAccountUser;
            newfrmMain.Show();
            this.Close();
        }

        //enabling the editing of account information and card PIN number
        private void cbEnableEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnableEdit.Checked)
            {
                //enable the fields and buttons
                gbCustomerDetails.Enabled = true;
                btnAccountInfoUpdate.Enabled = true;
                btnChangePin.Enabled = true;
                
                //Date of birth should not be changed be changed
                txtBoxAcctDetailsDOB.Enabled = false;

                //change the colour of the buttons - UX - Indicated they are selectable
                btnAccountInfoUpdate.BackColor = Color.Cornsilk;
                btnChangePin.BackColor = Color.Cornsilk;
            }
            else 
            {
                //disable the textbox fields id the checkbox is not checked
                gbCustomerDetails.Enabled = false;

                //disable the buttons if the checkbox is not checked
                btnAccountInfoUpdate.Enabled = false;
                btnChangePin.Enabled = false;

                //- UX -  indicate they are not selectable
                btnAccountInfoUpdate.BackColor = Color.Gray;
                btnChangePin.BackColor = Color.Gray;
            }
        }

        //enable the PIN change panel to be visiable 
        private void btnChangePin_Click(object sender, EventArgs e)
        {
            panelChangePin.Visible = true;
           
        }

        //Event to watch the text being entered is the correct type and format
        private void txtBoxNewPin_TextChanged(object sender, EventArgs e)
        {
            //remove white space if it is entered
            if(txtBoxNewPin.Text == " ")
            {
                txtBoxNewPin.Text = "";
            }
            //regex to check for numbers only
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtBoxNewPin.Text, @"^\d+$") && isPinChanged == false)
            {
                txtBoxNewPin.Text = "";
                //MessageBox.Show("Only numbers allowed");
            }
            //limit the input to 4 characters only
            if (txtBoxNewPin.Text.Length > 4)
            {
                MessageBox.Show("Only 4 numbers allowed");
                txtBoxNewPin.Text =  "";
            }


        }

        //close the panel and reset the input value
        private void btnNewPinCancel_Click(object sender, EventArgs e)
        {
            panelChangePin.Visible = false;
            txtBoxNewPin.Text = "";
        }

        //confirmation and writting the new PIN to the system
        private void btnNewPinConfirm_Click(object sender, EventArgs e)
        {
            //only write new PIN if it is 4 charaters long
            if(txtBoxNewPin.Text.Length == 4)
            {
                //get confirmation of pin change from user
                DialogResult res = MessageBox.Show("Are you sure you want to change your PIN number to " + txtBoxNewPin.Text, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    isPinChanged = true;
                    aTMConnector.openDbConnection();
                    aTMConnector.updateCustomerPIN(txtBoxNewPin.Text, frmLogin.currentCustomerAccNum);
                    aTMConnector.closeDbConnection();
                    MessageBox.Show("PIN changed to (" + txtBoxNewPin.Text + ")" );
                    txtBoxNewPin.Text = "";
                    panelChangePin.Visible = false;
                }
                //cancelling the PIN change
                if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("PIN change cancelled");
                    txtBoxNewPin.Text = "";
                }
            }
            //four digits not entered
            else
            {
                MessageBox.Show("Please Enter 4 digits");
            }
        }
        //write changes made to the account information to the database
        private void btnAccountInfoUpdate_Click(object sender, EventArgs e)
        {
            if(txtBoxAcctDetailsFirstName.Text != "" && txtBoxAcctDetailsLastName.Text != "" && txtBoxAcctDetailsAddress.Text != "" && txtBoxAcctDetailsPhoneNum.Text != "")
            {
                //update the details in the database from the textboxes in the form using the current logged-in customers' bank account number 
                string myCustomerGUId = aTMConnector.fetchCustomerGuidbyAccountNo(myLoggedinBankAccountUser.AccountNum);

                //get confirmation of pin change from user
                DialogResult res = MessageBox.Show("Are you sure you want to change account details?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    aTMConnector.updateCustomerDetails(txtBoxAcctDetailsFirstName.Text, txtBoxAcctDetailsLastName.Text, txtBoxAcctDetailsAddress.Text, txtBoxAcctDetailsPhoneNum.Text, myCustomerGUId);
                }
                //cancelling the PIN change
                if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Account details update cancelled");
                }
            }
            else
            {
                MessageBox.Show("Please enter data in all the account details section");
            }
           
        }


        public void updateToRecentAccountdeails()
        {
            if (txtBoxAcctDetailsFirstName.Text != "" && txtBoxAcctDetailsLastName.Text != "" && txtBoxAcctDetailsAddress.Text != "" && txtBoxAcctDetailsPhoneNum.Text != "")
            {
                //update the details in the database from the textboxes in the form using the current logged-in customers' bank account number 
                string myCustomerGUId = aTMConnector.fetchCustomerGuidbyAccountNo(myLoggedinBankAccountUser.AccountNum);

                //get confirmation of pin change from user
                DialogResult res = MessageBox.Show("Are you sure you want to change account details?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    aTMConnector.updateCustomerDetails(txtBoxAcctDetailsFirstName.Text, txtBoxAcctDetailsLastName.Text, txtBoxAcctDetailsAddress.Text, txtBoxAcctDetailsPhoneNum.Text, myCustomerGUId);
                }
                //cancelling the PIN change
                if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Account details update cancelled");
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string helpfilePath = Application.StartupPath;
            System.Diagnostics.Process.Start(helpfilePath + @"\BankingApp Help Files\index.html");
        }

        private void txtBoxNewPin_Enter(object sender, EventArgs e)
        {
            txtBoxNewPin.Text = "";
        }
    }
}

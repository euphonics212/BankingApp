using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace BankingApp
{
    public partial class frmLogin : Form
    {
        //store the user input for comparision, and validation   
        string userPinInput = "";

        public BankAccount myLoggedinBankAccountUser = new BankAccount();
        public ATMConnector aTMConnector = new ATMConnector(); // MASTER Connection!!!

        // get all the user pins and account numbers
        private List<String> pins = new List<String>();
        private List<String> accountNums = new List<String>();

        //static vairables to use within the systems when referencing the current user. 
        public static string currentCustomerPin = "";
        public static string currentCustomerAccNum = "";

        // variable to count the rows of bank customers
        int rowCount;

        //this bool will flag the login status
        bool PinIsCorrect = false;
        bool canLogIn = false;

        public frmLogin()
        {
            InitializeComponent();
        }

       
        // form on load
        private void frmLogin_Load(object sender, EventArgs e)
        {

            timerAnimateLogo.Enabled = true;
            // enable the timer that prompts the user for more time if nothing is entered
            timerLogin.Enabled = true;
            if (txtBoxPinIndicator.Text == "")
            {
                timerLogin.Tick += new System.EventHandler(OnTimerEvent);
            }
            else
            {
                timerLogin.Enabled = false;
            }
           

            //this will validate that the database file exists 
            aTMConnector.validateDBfileExist();

            aTMConnector.fetchLoginDetails("pinsAndAccntNums");
          
            rowCount = aTMConnector.dataSet.Tables["pinsAndAccntNums"].Rows.Count;

            //get
            for (int i = 0; i < rowCount; i++)
            {
                pins.Add("");
                accountNums.Add("");
                pins[i] = aTMConnector.dataSet.Tables["pinsAndAccntNums"].Rows[i]["account_pin"].ToString();
                accountNums[i] = aTMConnector.dataSet.Tables["pinsAndAccntNums"].Rows[i]["account_num"].ToString();
            }

            //encrypt data
            aTMConnector.encryptUserData();

        }


        //numeric pad 
        private void btn1_Click(object sender, EventArgs e)
        {
            if (PinIsCorrect == false)
            {
                txtBoxPinIndicator.Text += "*";
                userPinInput += btn1.Text;

            }
            else
            {
                txtBoxAccountNumLogin.Text += btn1.Text;
            }
           
           
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (PinIsCorrect == false)
            {
                txtBoxPinIndicator.Text += "*";
                userPinInput += btn2.Text;
            }
            else
            {
                
                txtBoxAccountNumLogin.Text += btn2.Text;
            }
           
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (PinIsCorrect == false)
            {
                txtBoxPinIndicator.Text += "*";
                userPinInput += btn3.Text;
            }
            else
            {
                txtBoxAccountNumLogin.Text += btn3.Text;
            }
            
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (PinIsCorrect == false)
            {
                txtBoxPinIndicator.Text += "*";
                userPinInput += btn4.Text;
            }
            else
            {
                txtBoxAccountNumLogin.Text += btn4.Text;
            }
            
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (PinIsCorrect == false)
            {
                txtBoxPinIndicator.Text += "*";
                userPinInput += btn5.Text;
            }
            else
            {
                txtBoxAccountNumLogin.Text += btn5.Text;
            }
           
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (PinIsCorrect == false)
            {
                txtBoxPinIndicator.Text += "*";
                userPinInput += btn6.Text;
            }
            else
            {
                txtBoxAccountNumLogin.Text += btn6.Text;
            }
            
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (PinIsCorrect == false)
            {
                txtBoxPinIndicator.Text += "*";
                userPinInput += btn7.Text;
            }
            else
            {
                txtBoxAccountNumLogin.Text += btn7.Text;
            }
           
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (PinIsCorrect == false)
            {
                txtBoxPinIndicator.Text += "*";
                userPinInput += btn8.Text;
            }
            else
            {
                txtBoxAccountNumLogin.Text += btn8.Text;
            }
            
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (PinIsCorrect == false)
            {
                txtBoxPinIndicator.Text += "*";
                userPinInput += btn9.Text;
            }
            else
            {
                txtBoxAccountNumLogin.Text += btn9.Text;
            }
           
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (PinIsCorrect == false)
            {
                txtBoxPinIndicator.Text += "*";
                userPinInput += btn0.Text;
            }
            else
            {
                txtBoxAccountNumLogin.Text += btn0.Text;
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //if the textbox is empty and the user clicks cancel, the login screen will prompt a close else it will clear the the text fields   
            if (txtBoxPinIndicator.Text == ""){
                DialogResult res = MessageBox.Show("Exit the account login screen", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    this.Close();
                }
                if (res == DialogResult.Cancel)
                {
                    txtBoxPinIndicator.Text = "";
                    userPinInput = "";
                }
            }
            else
            {
                PinIsCorrect = false;
                txtBoxAccountNumLogin.Text = "";
                txtBoxPinIndicator.Text = "";
                userPinInput = "";
                timerLogin.Enabled = true;
                timerLogin.Stop();
                timerLogin.Start();
            }
           
        }

        //login with user password
        private void btnOK_Click_1(object sender, EventArgs e)
        {
           int i = 0;
           if(PinIsCorrect == false)
            {
                foreach (String pin in pins)
                {
                    if (pins[i].ToString() == userPinInput)
                    {
                        currentCustomerAccNum = accountNums[i];
                        PinIsCorrect = true;
                        canLogIn = true;
                        if(txtBoxPinIndicator.Text.Length == 4 && txtBoxAccountNumLogin.Text == "")
                        {
                            MessageBox.Show("Please enter account number");
                            lbInstrunctions.Text = "Enter Account Number";;
                        }
                        else if(txtBoxPinIndicator.Text.Length < 4)
                        {
                            MessageBox.Show("Please enter PIN");
                        }
                       
                    }
                    i++;
                }
            }
            else
            {
                if (currentCustomerAccNum == txtBoxAccountNumLogin.Text)
                {
                    frmMain newfrmMain = new frmMain();

                    myLoggedinBankAccountUser.AccountNum = currentCustomerAccNum;

                    aTMConnector.fetchCustomerBankDetails("Login", myLoggedinBankAccountUser.AccountNum, myLoggedinBankAccountUser);

                    newfrmMain.aTMConnector = aTMConnector;
                    newfrmMain.AccountNumber = currentCustomerAccNum;
                    newfrmMain.myLoggedinBankAccountUser = myLoggedinBankAccountUser;

                    newfrmMain.Show();
                    txtBoxPinIndicator.Text = "";
                    userPinInput = "";
                   
                    timerLogin.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Incorrect account number");
                }

            }
            
            //error handeling
            if(canLogIn == false)
            {
                MessageBox.Show("Incorrect Pin");
                txtBoxPinIndicator.Text = "";
                userPinInput = "";
                timerLogin.Stop();
                timerLogin.Start();
                timerLogin.Enabled = true; 
            }

        }

        private void txtBoxPinIndicator_TextChanged(object sender, EventArgs e)
        {
            timerLogin.Enabled = false;
        }


        //communicate to the user for more time to entyer the pin
        private void OnTimerEvent(object sender, EventArgs e)
        {
            timerLogin.Stop();
            if (txtBoxPinIndicator.Text == "" || txtBoxAccountNumLogin.Text == "")
            {
                DialogResult res = MessageBox.Show("Do you require more time", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {

                    txtBoxPinIndicator.Text = "";
                    userPinInput = "";
                }
                if (res == DialogResult.No)
                {
                    this.Close();
                                       
                }
                timerLogin.Tick -= new System.EventHandler(OnTimerEvent);
                
               
            }
            timerLogin.Start();

        }

        //animate the logo
        private void timerAnimateLogo1_Tick(object sender, EventArgs e)
        {
            int x = loginLogo.Location.X;
            int y = loginLogo.Location.Y;

            loginLogo.Location = new Point(x + 3, y);

            if (loginLogo.Location.X > 0)
                timerAnimateLogo.Stop();
        }

        public void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\data\banking_app_resources\BankingApp Help Files\index.html");
        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {
            string helpfilePath = Application.StartupPath;
            System.Diagnostics.Process.Start(helpfilePath + @"\BankingApp Help Files\index.html");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            aTMConnector.decryptUserDatacrypt();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtBoxPinIndicator.Text = "****";
            userPinInput = "1121";
            txtBoxAccountNumLogin.Text = "4127451743";
        }
    }
}

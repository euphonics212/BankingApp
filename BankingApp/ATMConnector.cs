using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.CodeDom;

namespace BankingApp
{
    public class ATMConnector
    {
        //static string connString = "Data Source = C:/data/BankingApp.db"; // db file path

        public static string filepath = Application.StartupPath + "\\BankingApp.db";

        static string connString = "Data Source = "+ filepath; // db file path

        public SQLiteConnection bankDBconn = new SQLiteConnection(connString); //create SQlite onject

        public DataSet dataSet = new DataSet(); // create a data set to store the db tables

        public DataTable dataTable = new DataTable(); // create datatable to store individual tables

        public SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(); // create SQlite data adapter

        private string myGoldenKey = "foxtrot";


        //check the db file exist
        public bool validateDBfileExist()
        {
            if (!File.Exists(filepath))
            {
                MessageBox.Show("Database could not be found");
                return false;
            }
            else
            {
                return true;
            }
        }

        //open db connection if it is closed, and not if it is open
        public void openDbConnection()
        {
            if (bankDBconn.State != System.Data.ConnectionState.Open)
            {
                bankDBconn.Open();
            }
        }

        //close db connection if it is open and not if it closed
        public void closeDbConnection()
        {
            if (bankDBconn.State != System.Data.ConnectionState.Closed)
            {
                bankDBconn.Close();
            }
        }

        //get all bankCustomer's pins, and account numbers
        public void fetchLoginDetails(string tableName)
        {
            openDbConnection();
            string cmdString = @"SELECT account_pin, account_num
	                                FROM BankAccounts;";
            dataAdapter = new SQLiteDataAdapter(cmdString, bankDBconn);
            dataAdapter.Fill(dataSet, tableName);

            closeDbConnection();
        }
        //get account details
        public void fetchAccountBalance(string tableName, string accNum, BankAccount myLoggedinUser)
        {

            openDbConnection();


            DataTable myDT = new DataTable();

            string cmdString = @"SELECT balance
	                                FROM BankAccounts 
                                    WHERE account_num = '" + accNum + "';";
            dataAdapter = new SQLiteDataAdapter(cmdString, bankDBconn);
            dataAdapter.Fill(dataSet, tableName);
            dataAdapter.Fill(myDT);

            if (myDT.Rows.Count > 0)
            {
                myLoggedinUser.Balance = Convert.ToDouble(myDT.Rows[0].ItemArray[0].ToString());

            }

            closeDbConnection();


        }
        //get payees associated with the account of the customer 
        public void fetchPayees(string tableName, string accNum)
        {
            openDbConnection();

            string cmdString = @"SELECT a.first_name AS BCFirst_name, c.account_num , a.last_name AS BCLast_name, b.first_name AS PAYFirst_name, b.last_name AS PAYLast_name, d.account_num
	                                FROM Payees
                                LEFT JOIN BankCustomer AS a ON a.guid = Payees.Bank_Customer_Guid
                                LEFT JOIN BankCustomer AS b ON b.guid = Payees.Bank_Payee_Guid
                                LEFT JOIN BankAccounts AS c ON c.Bank_Customer_Guid =  Payees.Bank_Customer_Guid
                                LEFT JOIN BankAccounts AS d ON d.Bank_Customer_Guid =  Payees.Bank_Payee_Guid
                                WHERE c.account_num = '" + accNum + "';";
            dataAdapter = new SQLiteDataAdapter(cmdString, bankDBconn);
            dataAdapter.Fill(dataSet, tableName);

            closeDbConnection();
        }
        //get the account number of the payee
        public void fetchPayeesAccountNum(string tableName, string payee, BankAccount mypayeeAccount)
        {

            openDbConnection();
            DataTable myDT = new DataTable();


            string cmdString = @"SELECT account_num, first_name
	                                FROM BankCustomer
	                                LEFT JOIN BankAccounts ON BankAccounts.Bank_Customer_Guid = BankCustomer.guid
	                                WHERE first_name = '" + payee + "';";
            dataAdapter = new SQLiteDataAdapter(cmdString, bankDBconn);
            dataAdapter.Fill(dataSet, tableName);


            dataAdapter.Fill(myDT);

            if (myDT.Rows.Count > 0)
            {
                mypayeeAccount.AccountNum = myDT.Rows[0].ItemArray[0].ToString();
            }


            closeDbConnection();

        }

        //get the account details of the payee
        public void fetchPayeeAccountDetails(string tableName, string accNum)
        {
            openDbConnection();
            string cmdString = @"SELECT first_name
	                                FROM BankCustomer
	                                LEFT JOIN BankAccounts ON BankAccounts.Bank_Customer_Guid = BankCustomer.guid
	                                WHERE account_num = '"+ accNum+ "';";
            dataAdapter = new SQLiteDataAdapter(cmdString, bankDBconn);
            dataAdapter.Fill(dataSet, tableName);
            closeDbConnection();
        }

        //update account balance
        public void updateAccntBalance(string accNum, double amount )
        {
            openDbConnection();
            string cmdString = @"UPDATE BankAccounts
                                    SET  balance = " + amount + " WHERE account_num =" + accNum + " ;";
            dataAdapter = new SQLiteDataAdapter(cmdString, bankDBconn);
            dataAdapter.Fill(dataSet);
            closeDbConnection();
        }

        //get all customer account details
        public void fetchCustomerBankDetails(string tableName, string accNum, BankAccount myLoggedinUser) 
        {
            openDbConnection();
            DataTable myDT = new DataTable();
            
            string cmdString = @"SELECT first_name, last_name, address, phone_num, date_of_birth,encrypt,first_name AS FN
                                    FROM BankCustomer
                                    LEFT JOIN BankAccounts ON BankAccounts.Bank_Customer_Guid = BankCustomer.guid
                                    WHERE account_num = '" + accNum + "'; ";
            dataAdapter = new SQLiteDataAdapter(cmdString, bankDBconn);
            dataAdapter.Fill(dataSet, tableName);
            dataAdapter.Fill(myDT);

            if (myDT.Rows.Count > 0 )
            {


                if (myDT.Rows[0]["encrypt"].ToString() == "1")
                {
                    myLoggedinUser.FirstName = SSTCryptographer.Decrypt(myDT.Rows[0]["FN"].ToString(), myGoldenKey);
                }
                else
                {
                    myLoggedinUser.FirstName = myDT.Rows[0].ItemArray[0].ToString();
                }

                
                myLoggedinUser.LastName = myDT.Rows[0].ItemArray[1].ToString();
                myLoggedinUser.Address = myDT.Rows[0].ItemArray[2].ToString();
                myLoggedinUser.PhoneNum = myDT.Rows[0].ItemArray[3].ToString();
                myLoggedinUser.DateOfBirth = myDT.Rows[0].ItemArray[4].ToString();

            }

            closeDbConnection();
        }

        //update pin
        public void updateCustomerPIN(string PIN, string accNum)
        {
            openDbConnection();

            string cmdString = @"UPDATE BankAccounts
                                    SET  account_pin = " + PIN + " WHERE account_num =" + accNum + " ;";
            dataAdapter = new SQLiteDataAdapter(cmdString, bankDBconn);
            dataAdapter.Fill(dataSet);

            closeDbConnection();
        }

        //update customer details
        public void updateCustomerDetails(string fname, string lname, string address, string phoneNum, string accGuid)
        {
            openDbConnection();

            string cmdString = @"UPDATE BankCustomer
	                                SET first_name = '" + SSTCryptographer.Encrypt( fname , myGoldenKey) + "', last_name = '" + lname + "', address = '" + address + "', phone_num = '" + phoneNum + "',encrypt=1 WHERE guid = '"+ accGuid +"'";
            dataAdapter = new SQLiteDataAdapter(cmdString, bankDBconn);
            dataAdapter.Fill(dataSet);

            closeDbConnection();
        }


        public string fetchCustomerGuidbyAccountNo(string accNum)
        {
            openDbConnection();

            string myGuidforAccount = "";

            DataTable  myDT = new DataTable();

            string cmdString = @"SELECT Bank_Customer_Guid
                                    FROM BankAccounts
                                    WHERE account_num = '" + accNum + "'; ";
            dataAdapter = new SQLiteDataAdapter(cmdString, bankDBconn);
            dataAdapter.Fill(myDT);

            myGuidforAccount = myDT.Rows[0].ItemArray[0].ToString();

            closeDbConnection();
            return myGuidforAccount;

        }
        public void insertIntoTransactions(string tableName, string guid,  string custGuid, string PayeeGuid, double transAmount, string date)
        {
            openDbConnection();

            string cmdString = @"INSERT INTO 'main'.'BankTransfers'
                                    ('guid', 'Customer_Guid', 'Payee_Guid', 'amount', 'date')
                                    VALUES('" + guid + "', '" + custGuid + "', '" + PayeeGuid + "', " + transAmount + ",'"+ date+"');";
            dataAdapter = new SQLiteDataAdapter(cmdString, bankDBconn);
            dataAdapter.Fill(dataSet, tableName);

            closeDbConnection();
        }

        public void fetchBankTransActions(string tableName, string guid)
        {
            openDbConnection();

            string cmdString = @"SELECT  BankTransfers.uid AS 'Transaction Num', first_name AS 'First Name', last_name AS 'Last Name', amount As 'Amount', date
                                    FROM BankTransfers
                                    LEFT JOIN BankCustomer AS a ON a.guid = BankTransfers.Payee_Guid
                                    WHERE Customer_Guid = '" + guid + "';";
            dataAdapter = new SQLiteDataAdapter(cmdString, bankDBconn);
            dataAdapter.Fill(dataSet, tableName);

            closeDbConnection();
        }

        public void encryptUserData()
        {
            DataTable encryptDT = new DataTable();

            openDbConnection();

            string cmdString = @"SELECT guid, first_name, last_name 
                                    FROM BankCustomer
                                    WHERE encrypt = 0 AND guid='38d14606-cf58-43ab-b28d-12fe159d3e76'";
            dataAdapter = new SQLiteDataAdapter(cmdString, bankDBconn);
            dataAdapter.Fill(encryptDT);

            for(int i = 0;  i < encryptDT.Rows.Count; i++)
            {
                cmdString = @"UPDATE  BankCustomer
                                SET first_name = '" + SSTCryptographer.Encrypt(encryptDT.Rows[i]["first_name"].ToString(), myGoldenKey) + 
                                    "', encrypt = 1 WHERE guid ='" + encryptDT.Rows[i].ItemArray[0].ToString() + "';";

                SQLiteCommand encryptCmd = new SQLiteCommand(cmdString, bankDBconn);
                encryptCmd.ExecuteNonQuery();
            }                       

            closeDbConnection();

        }

        public void decryptUserDatacrypt()
        {
            DataTable decryptDT = new DataTable();

            openDbConnection();

            string cmdString = @"SELECT guid, first_name, last_name 
                                    FROM BankCustomer
                                    WHERE encrypt = 1 AND guid='38d14606-cf58-43ab-b28d-12fe159d3e76'";
            dataAdapter = new SQLiteDataAdapter(cmdString, bankDBconn);
            dataAdapter.Fill(decryptDT);

            for (int i = 0; i < decryptDT.Rows.Count; i++)
            {
                cmdString = @"UPDATE  BankCustomer
                                SET first_name = '" + SSTCryptographer.Decrypt(decryptDT.Rows[i]["first_name"].ToString(), myGoldenKey) +
                                    "', encrypt = 0 WHERE guid ='" + decryptDT.Rows[i]["guid"].ToString() + "';";

                SQLiteCommand decryptDTCmd = new SQLiteCommand(cmdString, bankDBconn);
                decryptDTCmd.ExecuteNonQuery();
            }

            closeDbConnection();

        }
        public int countTransfersRows(string guid)
        {
            DataTable dt = new DataTable();
         
            openDbConnection();

            string cmdString = @"SELECT COUNT(*)
                                        FROM BankTransfers
                                        WHERE Customer_Guid = '" + guid + "'; ";

            dataAdapter = new SQLiteDataAdapter(cmdString, bankDBconn);
            dataAdapter.Fill(dt);

            int rowcount = Int16.Parse(dt.Rows[0][0].ToString());
            return rowcount;
            closeDbConnection();
            
        }
    }
}

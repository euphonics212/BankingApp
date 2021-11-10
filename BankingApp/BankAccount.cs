using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class BankAccount : BankCustomer
    {
        
        private string accountNum;
        private double balance;

        //bank accounts of payees
        public List<BankAccount> Payee = new List<BankAccount>();

        //get, set account number
        public string AccountNum
        {
            get { return accountNum; }
            set { accountNum = value; }
        }

        //get, set balance
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

    }


}

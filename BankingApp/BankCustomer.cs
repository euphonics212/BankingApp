using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class BankCustomer : Person
    {
        
        private string dateOfBirth;
        private string address;
        private string phoneNum;
        private int pinNum;

        //get, set date of birth
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }

        }

        //get, set address
        public string Address
        {
            get { return address; }
            set { address = value; }

        }

        //get, set phone number
        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }

        }
        
        public int PinNum
        {
            get { return pinNum; }
            set { pinNum = value; }
        }
    }
}

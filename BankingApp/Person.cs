using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class Person
    {
        private string firstName;
        private string lastName;

        //Get,Set first name
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }

        }

        //Get,Set last name
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }

        }
    }
}

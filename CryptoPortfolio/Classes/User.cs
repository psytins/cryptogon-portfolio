using System;
using System.Collections.Generic;
using System.Linq;

namespace CryptoPortfolio
{
    class User
    {
        //Variables
        private int id;
        private String firstName;
        private String lastName;
        private String emailAddress;
        private String password;

        public User(String firstName, String lastName, String emailAddress, String password)
        {
            //ID increment
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.password = password;
        }
        public int ID 
        {
            get { return this.id; }
        }
        public String FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public String LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public String EmailAddress
        {
            get { return this.emailAddress; }
            set { this.emailAddress = value; }
        }
        public String Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        //Functions
        private int readLastID()
        {


            return 0;
        }
    }
}

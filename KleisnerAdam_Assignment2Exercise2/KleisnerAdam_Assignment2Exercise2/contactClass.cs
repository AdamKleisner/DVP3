using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KleisnerAdam_Assignment2Exercise2
{

    public class contactClass
    {
        // variables to hold contact info: name, number, email, then type of number it is
        string firstName;
        string lastName;
        string number;
        string email;
        bool mobile;
        bool work;
        bool home;

        //getter and setter for number
        public string Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }
        //getter and setter for email
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        //getter and setter for a mobile contact
        public bool Mobile
        {
            get
            {
                return mobile;
            }

            set
            {
                mobile = value;
            }
        }
        //getter and setter for a work contact
        public bool Work
        {
            get
            {
                return work;
            }

            set
            {
                work = value;
            }
        }
        //getter and setter for a home contact
        public bool Home
        {
            get
            {
                return home;
            }

            set
            {
                home = value;
            }
        }
        //getter and setter for first name
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }
        //getter and setter for last name
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }
        //constructor for class
        public contactClass (string _firstName, string _lastName, string _phoneNumber, string _email, bool _mobile, bool _work, bool _home)
        {
            FirstName = _firstName;
            LastName = _lastName;
            Number = _phoneNumber;
            Email = _email;
            Mobile = _mobile;
            Work = _work;
            Home = _home;
        }
        //overridng too string so that I can choose what will be shown when to string is called
        public override string ToString()
        {
            return FirstName + " " + LastName + "\n" + Number + "\n" + Email;
        }
    }
}

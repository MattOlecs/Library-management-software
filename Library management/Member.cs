using System;
using System.Collections.Generic;
using System.Text;

namespace Library_management
{
    public class Member : Person
    {
        private string _phoneNumber, _email, _libraryCardNumber;
        private int _memberId;

        public Member()
        { }

        //Member constructor for adding NEW member to database
        public Member(int memberId, string firstName, string lastName, string address, string phoneNumber, string email, string cardNumber)
        {
            //created array of function arguments to pass it to function that checks if any of them is null
            string[] args = { firstName, lastName, address, phoneNumber, email, cardNumber };

            CheckForNull(args);

            this.MemberId = memberId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.LibraryCardNumber = cardNumber;
        }

        public Member(string firstName, string lastName, string address, string phoneNumber, string email)
        {
            //created array of function arguments to pass it to function that checks if any of them is null
            string[] args = { firstName, lastName, address, phoneNumber, email };

            CheckForNull(args);

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        //This function checks if any of other function's string parameters is null
        //if yes, throws ArgumentNullException
        private void CheckForNull(params string[] args)
        {
            foreach (string arg in args)
                if (string.IsNullOrEmpty(arg))
                {
                    throw new ArgumentNullException("One or more values are empty");
                }
        }

        public int MemberId
        {
            get => _memberId;

            set => _memberId = value;
        }

        [System.ComponentModel.DisplayName("E-mail")]
        public string Email
        {
            get => _email;

            set => _email = value;
        }

        [System.ComponentModel.DisplayName("Phone number")]
        public string PhoneNumber
        {
            get => _phoneNumber;

            set => _phoneNumber = value;
        }

        [System.ComponentModel.DisplayName("Card number")]
        public string LibraryCardNumber
        {
            get => _libraryCardNumber;

            set => _libraryCardNumber = value;
        }
    }
}

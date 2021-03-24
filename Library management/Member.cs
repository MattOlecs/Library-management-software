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

        //Member constructor
        public Member(string firstName, string lastName, string address, string phoneNumber, string email)
        {
            string[] args = { firstName, lastName, address, phoneNumber, email };

            CheckForNull(args);

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        //this function check if any of function string parameters is null
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

        public string Email
        {
            get => _email;

            set => _email = value;
        }

        public string PhoneNumber
        {
            get => _phoneNumber;

            set => _phoneNumber = value;
        }

        public string LibraryCardNumber
        {
            get => _libraryCardNumber;

            set => _libraryCardNumber = value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Library_management
{
    class LibraryCard
    {
        private string _cardNumber;
        private int _memberId;

        public LibraryCard(int memberId)
        {
            this.MemberId = memberId;
            this.CardNumber = generateCardNumber();
        }

        public int MemberId 
        { 
            get => _memberId; 

            set => _memberId = value; 
        }

        public string CardNumber
        {
            get => _cardNumber;

            set => _cardNumber = value;
        }

        //this function generates 14 digit library card number
        private string generateCardNumber() 
        {
            Random rnd = new Random();

            string part1, part2, part3;

            part1 = rnd.Next(1, 4).ToString();
            part2 = rnd.Next(1000000, 8000000).ToString();
            part3 = rnd.Next(100000, 700000).ToString();

            return part1 + part2 + part3;
        }

    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace Library_management
{
    class Order
    {
        private int _memberId, _bookId;
        private DateTime _dateOfBorrow, _dateOfReturn;

        public Order(int memberId, int bookId, DateTime dateOfBorrow, DateTime dateOfReturn)
        {
            MemberId = memberId;
            BookId = bookId;
            DateOfBorrow = dateOfBorrow;
            DateOfReturn = dateOfReturn;
        }

        public int MemberId { get => _memberId; set => _memberId = value; }
        public int BookId { get => _bookId; set => _bookId = value; }
        public DateTime DateOfBorrow { get => _dateOfBorrow; set => _dateOfBorrow = value; }
        public DateTime DateOfReturn { get => _dateOfReturn; set => _dateOfReturn = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Medical_Clinic_Management
{
    class Item
    {
        public Item(string type, string genre, string title, string author, string publisher, int editionNumber, string isbn, int copies, string shelf)
        {
            Type = type;
            Genre = genre;
            Title = title;
            Author = author;
            Publisher = publisher;
            EditionNumber = editionNumber;
            Isbn = isbn;
            Copies = copies;
            Shelf = shelf;
        }

        public string Type { get; }
        public string Genre { get; }
        public string Title { get; }
        public string Author { get; }
        public string Publisher { get; }
        public int EditionNumber { get; }
        public string Isbn { get; }
        public int Copies{ get; }
        public string Shelf{ get; }

    }
}

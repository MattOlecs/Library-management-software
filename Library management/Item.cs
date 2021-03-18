using System;
using System.Collections.Generic;
using System.Text;

namespace Library_management
{
    class Item
    {

        private string _type, _genre, _title, _author, _publisher, _isbn, _shelf;
        private int _editionNumber, _pages, _copies;

        public Item()
        { }
        public Item(string type, string genre, string title, string author, string publisher, int editionNumber, int pages, string isbn, int copies, string shelf)
        {
            this.Type = type;
            this.Genre = genre;
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.EditionNumber = editionNumber;
            this.Pages = pages;
            this.Isbn = isbn;
            this.Copies = copies;
            this.Shelf = shelf;
        }

        public string Type
        { 
            get => _type; 
            
            set => _type = value; 
        }
        public string Genre
        {
            get => _genre;

            set => _genre = value;
        }
        public string Title
        {
            get => _title;

            set => _title = value;
        }
        public string Author
        {
            get => _author;

            set => _author = value;
        }
        public string Publisher
        {
            get => _publisher;

            set => _publisher = value;
        }
        public int EditionNumber
        {
            get => _editionNumber;

            set => _editionNumber = value;
        }
        public int Pages
        {
            get => _pages;

            set => _pages = value;
        }
        public string Isbn
        {
            get => _isbn;

            set => _isbn = value;
        }
        public int Copies
        {
            get => _copies;

            set => _copies = value;
        }
        public string Shelf
        {
            get => _shelf;

            set => _shelf = value;
        }

    }
}

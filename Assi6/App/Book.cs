using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Book
    {
        int _bookId;
        string _bookName;
        string _author;
        string _publisher;
        decimal _price;
        public Book(int bookId,string bookName,string author,string publisher,decimal price)
        {
            _bookId=bookId;
            _bookName=bookName;
         _author=author;
          _publisher=publisher;
          _price=price;
        }
        public int BookId { get => _bookId; set => _bookId = value; }
        public string BookName { get => _bookName; set => _bookName = value; }
        public string Author { get => _author; set => _author = value; }
        public string Publisher { get => _publisher; set => _publisher = value; }
        public decimal Price { get => _price; set => _price = value; }
    }
}

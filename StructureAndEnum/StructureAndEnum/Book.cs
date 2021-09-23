using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureAndEnum
{
    struct Book
    {
        int isbn;
        string bookName;
        string bookAuthor;

        public Book(int isbn, string bookName, string bookAuthor)
        {
            this.isbn = isbn;
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
        }
        public string Display()
        {
            return $"ISBN = {this.isbn}\nName = {this.bookName}\nAuthor = {this.bookAuthor}";
        }

    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BookCategory> bookCategories = new List<BookCategory>
            {
                new BookCategory{BookCategoryID=1, BookCategoryName="Edebiyat"},
                new BookCategory { BookCategoryID=2, BookCategoryName="Felsefe"}
            };

            List<BookType> bookTypes = new List<BookType>
            {
                new BookType{BookTypeID=1, BookCategoryID=1, BookTypeName="Roman", UnitStock=20, Price=50},
                new BookType{BookTypeID=2, BookCategoryID=1, BookTypeName="Hikaye", UnitStock=38, Price=38},
                new BookType{BookTypeID=3, BookCategoryID=2, BookTypeName="Sanat Felsefesi", UnitStock=74, Price=42}
            };

        }

        static List<BookType> GetBookTypes(List<BookType> bookTypes)
        {
            return bookTypes.Where(bookType => bookType.Price >  30 && bookType.UnitStock > 52);
        }

    }
    class BookCategory
    {
        public int BookCategoryID { get; set; }
        public string BookCategoryName { get; set; }
    }

    class BookType
    {
        public int BookTypeID { get; set; }
        public int BookCategoryID { get; set; }
        public string BookTypeName { get; set; }
        public int UnitStock { get; set; }
        public int Price { get; set; }
    }
}

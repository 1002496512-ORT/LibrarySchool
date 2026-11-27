using LibraryDTO;
using System.Data;
using System.Net;

namespace LibraryWS.LibraryORM
{
    public class BookCreator : IModelCreator<Book>
    {
        public Book CreateModel(IDataReader reader)
        {
            return new Book()
            {
                BookDescription = Convert.ToString(reader["BookDescription"]),
                BookId = Convert.ToString(reader["BookId"]),
                BookImage = Convert.ToString(reader["BookImage"]),
                BookName = Convert.ToString(reader["BookName"]),
            };
        }
    }
}

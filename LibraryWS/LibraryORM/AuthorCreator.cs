using LibraryDTO;
using System.Data;
namespace LibraryWS.LibraryORM
{
    public class AuthorCreator : IModelCreator<Author>
    {
        public Author CreateModel(IDataReader reader)
        {

            Author author = new Author();
            author.AuthorFirstName = Convert.ToString(reader["AuthorFirstName"]);
            author.AuthorLastName = Convert.ToString(reader["AuthorLastName"]);
            author.AuthorPicture = Convert.ToString(reader["AuthorPicture"]);
            author.AuthorYear = Convert.ToInt16(reader["AuthorPicture"]);
            author.CountryId = Convert.ToInt16(reader["CountryId"]);
            return author;
        }
    }
}

using LibraryDTO;
using System.Data;

namespace LibraryWS.LibraryORM
{
    public class BorrowCreator : IModelCreator<Borrow>
    {
        public Borrow CreateModel(IDataReader reader)
        {
            return new Borrow()
            {
                BookId = Convert.ToString(reader["BookId"]),
                BorrowDate = Convert.ToString(reader["BorrowDate"]),
                BorrowId = Convert.ToString(reader["BorrowId"]),
                BorrowStatus = Convert.ToString(reader["BorrowStatus"]),
                ReaderId = Convert.ToString(reader["ReaderId"])
            };
    }
}

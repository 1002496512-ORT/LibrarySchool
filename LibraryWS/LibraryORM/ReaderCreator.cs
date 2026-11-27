using LibraryDTO;
using System.Data;

namespace LibraryWS.LibraryORM
{
    public class ReaderCreator : IModelCreator<Reader>
    {
        public Reader CreateModel(IDataReader reader)
        {
            return new Reader()
            {
                CityId = Convert.ToString(reader["CityId"]),
                ReaderAdress = Convert.ToString(reader["ReaderAdress"]),
                ReaderFirstName = Convert.ToString(reader["ReaderFirstName"]),
                ReaderId = Convert.ToString(reader["ReaderId"]),
                ReaderImage = Convert.ToString(reader["ReaderImage"]),
                ReaderLastName = Convert.ToString(reader["ReaderLastName"]),
                ReaderNickName = Convert.ToString(reader["ReaderNickName"]),
                ReaderPassword = Convert.ToString(reader["ReaderPassword"]),
                ReaderSalt = Convert.ToString(reader["ReaderSalt"]),
                ReaderTelephone = Convert.ToString(reader["ReaderTelephone"]),
            };
        }
    }

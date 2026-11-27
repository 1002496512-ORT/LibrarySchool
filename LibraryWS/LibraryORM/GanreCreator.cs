using LibraryDTO;
using System.Data;

namespace LibraryWS.LibraryORM
{
    public class GanreCreator
    {
        public Ganre CreateModel(IDataReader reader)
        {
            return new Ganre()
            {
                 GanreId = Convert.ToString(reader["GanreId"]),
                 GanreName = Convert.ToString(reader["GanreName"])
            };
        }
    }
}

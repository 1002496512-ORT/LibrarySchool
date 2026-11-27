using LibraryDTO;
using System.Data;

namespace LibraryWS.LibraryORM
{
    public class CountryCreator : IModelCreator<Country>
    {
        public Country CreateModel(IDataReader reader)
        {
            return new Country()
            {
                 CountryId = Convert.ToString(reader["CountryId"]),
                 CountryName = Convert.ToString(reader["CountryName"])
            };
        }
    }
}

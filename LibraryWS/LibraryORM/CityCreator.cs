using LibraryDTO;
using System.Data;

namespace LibraryWS.LibraryORM
{
    public class CityCreator : IModelCreator<City>
    {
        public City CreateModel(IDataReader reader)
        {
            return new City()
            {
                CityId = Convert.ToString(reader["CityId"]),
                CityName = Convert.ToString(reader["CityName"])
            };
        }
    }
}

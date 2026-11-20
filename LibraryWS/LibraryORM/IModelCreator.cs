using System.Data;

namespace LibraryWS.LibraryORM
{
    public interface IModelCreator<T>
    {
        T CreateModel(IDataReader reader);
    }
}

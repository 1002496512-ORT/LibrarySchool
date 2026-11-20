using System.Data;
namespace LibraryWS.LibraryORM
{
    public interface IDbContext
    {
        void OpenDb();// פתיחת DB
        void CloseDb();// סגירת DB


        // קריאת מידה ממסד נתונים
        IDataReader Read(string sql); // קריאה מ-DB

        // הוספה נתונים לממסד נתונים
        int Insert(string sql);

        // עדכון נתונים לממסד נתונים
        int Update(string sql);

        // מחיקת נתונים ממסד נתונים
        int Delete(string sql);

        // טיפול בטטרנזקציה

        void OpenTaransaction();

        void RollBack();

        void Commit();

    }
}

using System.Data;
using System.Data.OleDb;

namespace LibraryWS.LibraryORM
{
    public class DbContext : IDbContext
    {
        OleDbConnection dbConnection;
        OleDbCommand dbCommand;
        OleDbTransaction dbTransaction;

        public DbContext()
        {
            this.dbConnection = new OleDbConnection();
            this.dbConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\AlexLesson\2026-2027\LibrarySchool\LibraryWS\App_Data\Library.accdb";
            this.dbCommand = new OleDbCommand();
            this.dbCommand.Connection = this.dbConnection;

        }

        public void CloseDb()
        {
            this.dbConnection.Close();
        }

        public void Commit()
        {
            if (this.dbTransaction == null)
                this.dbTransaction = this.dbConnection.BeginTransaction();
            this.dbTransaction.Commit();
        }

        public int Delete(string sql)
        {
            return ChangeDb(sql);
        }

        public int Insert(string sql)
        {
            return ChangeDb(sql);
        }

        public void OpenDb()
        {
            this.dbConnection.Open();
        }

        public void OpenTaransaction()
        {
            this.dbTransaction = this.dbConnection.BeginTransaction();
        }

        public IDataReader Read(string sql)
        {
            this.dbCommand.CommandText = sql;
            return this.dbCommand.ExecuteReader();
        }

        public void RollBack()
        {
            if (this.dbTransaction == null)
                this.dbTransaction = this.dbConnection.BeginTransaction();
            this.dbTransaction.Rollback();
        }

        public int Update(string sql)
        {
            return ChangeDb(sql);
        }

        private int ChangeDb(string sql)
        {
            this.dbCommand.CommandText = sql;
            return this.dbCommand.ExecuteNonQuery();
        }
    }
}

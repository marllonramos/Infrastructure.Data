using Infrastructure.Data.Interface;
using System.Data;

namespace Infrastructure.Data.Context
{
    public class DatabaseContext : IDatabaseContext
    {
        public DatabaseContext(IDatabase database) => Database = database;

        public IDbConnection Connection { get; private set; }
        public IDbTransaction Transaction { get; private set; }
        public IDatabase Database { get; private set; }

        public void BeginTransaction()
        {
            Connection = Database.GetConnection();
            if (Connection.State != ConnectionState.Open)
                Connection.Open();
            Transaction = Database.GetTransaction(Connection, IsolationLevel.ReadCommitted);
        }

        public void SaveChanges()
        {
            Transaction.Commit();
            Dispose();
        }

        public void RollBack()
        {
            Transaction.Rollback();
            Dispose();
        }

        private void Dispose()
        {
            if (Transaction != null)
            {
                Transaction.Dispose();
                Transaction = null;
            }

            if (Connection != null)
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
                Connection.Dispose();
                Connection = null;
            }
        }
    }
}

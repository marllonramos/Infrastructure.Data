using System.Data;

namespace Infrastructure.Data.Interface
{
    public interface IDatabase
    {
        DataTable GetData(string query);
        DataTable GetData(IDbConnection connection, IDbTransaction transaction, string query);
        DataTable GetData(IDbConnection connection, IDbTransaction transaction, IDbCommand command);
        void UpdateData(string commandText);
        void UpdateData(IDbConnection connection, IDbTransaction transaction, string commandText);
        void UpdateData(IDbConnection connection, IDbTransaction transaction, IDbCommand command);
        IDbConnection GetConnection();
        IDbTransaction GetTransaction(IDbConnection connection, IsolationLevel isolationLevel);
    }
}

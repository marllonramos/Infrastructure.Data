using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace Infrastructure.Data.Interface
{
    public interface IDatabase
    {
        DataTable GetData(string query);
        DataTable GetData(DbConnection connection, DbTransaction transaction, string query);
        DataTable GetData(DbConnection connection, DbTransaction transaction, DbCommand command);
        DbConnection GetConnection();
        DbTransaction GetTransaction(DbConnection connection, IsolationLevel isolationLevel);

        void UpdateData(string commandText);
        void UpdateData(DbConnection connection, DbTransaction transaction, string commandText);
        void UpdateData(DbConnection connection, DbTransaction transaction, DbCommand command);

        #region Asynchronous methods
        Task<DataTable> GetDataAsync(string query);
        Task<DataTable> GetDataAsync(DbConnection connection, DbTransaction transaction, string query);
        Task<DataTable> GetDataAsync(DbConnection connection, DbTransaction transaction, DbCommand command);
        Task<DbTransaction> GetTransactionAsync(DbConnection connection, IsolationLevel isolationLevel);

        Task UpdateDataAsync(string commandText);
        Task UpdateDataAsync(DbConnection connection, DbTransaction transaction, string commandText);
        Task UpdateDataAsync(DbConnection connection, DbTransaction transaction, DbCommand command);
        #endregion
    }
}

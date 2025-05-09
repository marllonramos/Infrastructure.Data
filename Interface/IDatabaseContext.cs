using System.Data.Common;
using System.Threading.Tasks;

namespace Infrastructure.Data.Interface
{
    public interface IDatabaseContext
    {
        DbConnection Connection { get; }
        DbTransaction Transaction { get; }
        IDatabase Database { get; }

        void BeginTransaction();
        void SaveChanges();
        void RollBack();

        #region Asynchronous methods
        Task BeginTransactionAsync();
        Task SaveChangesAsync();
        Task RollBackAsync();
        #endregion
    }
}

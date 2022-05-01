using System.Data;

namespace Infrastructure.Data.Interface
{
    public interface IDatabaseContext
    {
        IDbConnection Connection { get; }
        IDbTransaction Transaction { get; }
        IDatabase Database { get; }
        void BeginTransaction();
        void SaveChanges();
        void RollBack();
    }
}

using System.Threading.Tasks;

namespace Infrastructure.Data.Interface
{
    public interface IUnitOfWork
    {
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

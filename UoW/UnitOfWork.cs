using Infrastructure.Data.Interface;
using System.Threading.Tasks;

namespace Infrastructure.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseContext _context;

        public UnitOfWork(IDatabaseContext context) => _context = context;

        public void BeginTransaction() => _context.BeginTransaction();
        public void SaveChanges() => _context.SaveChanges();
        public void RollBack() => _context.RollBack();

        #region Asynchronous methods
        public async Task BeginTransactionAsync() => await _context.BeginTransactionAsync();
        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
        public async Task RollBackAsync() => await _context.RollBackAsync();
        #endregion
    }
}

using Infrastructure.Data.Interface;

namespace Infrastructure.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseContext _context;

        public UnitOfWork(IDatabaseContext context) => _context = context;

        public void BeginTransaction() => _context.BeginTransaction();
        public void SaveChanges() => _context.SaveChanges();
        public void RollBack() => _context.RollBack();
    }
}

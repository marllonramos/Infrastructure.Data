namespace Infrastructure.Data.Interface
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void SaveChanges();
        void RollBack();
    }
}

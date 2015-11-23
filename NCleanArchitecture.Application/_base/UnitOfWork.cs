namespace NCleanArchitecture.Application._base
{
    public interface UnitOfWork
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
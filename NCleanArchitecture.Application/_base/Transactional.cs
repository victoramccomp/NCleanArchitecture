namespace NCleanArchitecture.Application._base
{
    public interface Transactional
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
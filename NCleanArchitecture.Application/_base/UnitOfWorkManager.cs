namespace NCleanArchitecture.Application._base
{
    public interface UnitOfWorkManager
    {
        void SetUnitOfWork();
        void DisposeUnitOfWork();
    }
}

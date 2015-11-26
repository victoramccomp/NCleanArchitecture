using NCleanArchitecture.Application._base;

namespace NCleanArchitecture.Infrastructure
{
    public class FakeTransactional : Transactional
    {
        public void BeginTransaction()
        {
        }

        public void Commit()
        {
        }

        public void Rollback()
        {
        }
    }
}

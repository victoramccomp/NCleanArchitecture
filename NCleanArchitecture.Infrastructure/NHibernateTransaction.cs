using NCleanArchitecture.Application._base;
using NHibernate;
using System;

namespace NCleanArchitecture.Infrastructure
{
    public class NHibernateTransaction : Transactional, IDisposable
    {
        private readonly ISession _session;

        public NHibernateTransaction(ISession session)
        {
            _session = session;
        }

        public void BeginTransaction()
        {
            _session.BeginTransaction();
        }

        public void Commit()
        {
            _session.Transaction.Commit();
        }

        public void Rollback()
        {
            _session.Transaction.Rollback();
        }

        public void Dispose()
        {
            if (_session != null) _session.Dispose();
        }
    }
}

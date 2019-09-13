using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnCall.Web.Domain.Infrastructure.DP
{
    public interface IContext : IDisposable
    {
        bool IsTransactionStarted { get; }

        void BeginTransaction();

        void Commit();

        void Rollback();
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnCall.Web.Domain.Infrastructure.DP
{
    public class DapperUnitOfWorkFactory : IUnitOfWorkFactory
    {
        private readonly DapperDBContext _context;

        public DapperUnitOfWorkFactory(DapperDBContext context)
        {
            _context = context;
        }

        public IUnitOfWork Create()
        {
            return new UnitOfWork(_context);
        }
    }
}

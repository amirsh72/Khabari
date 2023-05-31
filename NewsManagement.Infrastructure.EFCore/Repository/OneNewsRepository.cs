using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using NewsManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsManagement.Infrastructure.EFCore.Repository
{
    public class OneNewsRepository : RepositoryBase<long, OneNews>, IOneNewRepository
    {
        private readonly OneNewsContext _oneNewsDBContext;
        public OneNewsRepository(OneNewsContext oneNewsDBContext) : base(oneNewsDBContext)
        {
            _oneNewsDBContext = oneNewsDBContext;
        }
    }
}

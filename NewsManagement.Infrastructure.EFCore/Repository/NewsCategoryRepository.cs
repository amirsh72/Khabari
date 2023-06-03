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
    public class NewsCategoryRepository : RepositoryBase<long, NewsCategory>, INewsCategoryRepository
    {
        public NewsCategoryRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}

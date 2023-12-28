using _0_Framework.Infrastructure;
using ServicesManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesManagement.Infrastructure.Repository
{
    public class ServiceCategoryRepository: RepositoryBase<long, ServicCategory>,IServiceCategoryRepository
    {
        public ServiceCategoryRepository(ServicesContext context) : base(context)
        {


        }

    }
}

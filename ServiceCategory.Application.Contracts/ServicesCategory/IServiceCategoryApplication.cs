using _0_Framework.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCategory.Application.Contracts.ServicesCategory
{
    public interface IServiceCategoryApplication
    {
        OperationResult Create(CreateServiceCategory createServiceCategory);
        OperationResult Edit(EditServiceCategory editServiceCategory);
        EditServiceCategory GetDetails(long id);
        List<ServiceCategoryViewModel> Search(ServiceCategorySearchModel serviceCategorySearch);
        List<ServiceCategoryViewModel> List();

    }
}

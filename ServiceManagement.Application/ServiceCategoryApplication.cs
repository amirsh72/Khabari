using _0_Framework.Application;
using ServiceCategory.Application.Contracts.ServicesCategory;
using ServicesManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagement.Application
{
    public class ServiceCategoryApplication : IServiceCategoryApplication
    {
        private readonly IServiceCategoryRepository _serviceCategoryRepository;

        public ServiceCategoryApplication(IServiceCategoryRepository serviceCategoryRepository)
        {
            _serviceCategoryRepository = serviceCategoryRepository;
        }

        public OperationResult Create(CreateServiceCategory createServiceCategory)
        {
            var oparation = new OperationResult();

            _serviceCategoryRepository.Create(new ServicCategory
            {
                Name= createServiceCategory.Name,
                Description= createServiceCategory.Description,
                
            } );
               
            _serviceCategoryRepository.SaveChange();

            return oparation.Succeded();
        }

        public OperationResult Edit(EditServiceCategory editServiceCategory)
        {
            var oparation=new OperationResult();

            _serviceCategoryRepository.Edit(new ServicCategory
            {
                Name = editServiceCategory.Name,
                Description = editServiceCategory.Description,
                Id = editServiceCategory.Id,
            });
            _serviceCategoryRepository.SaveChange();
            return oparation.Succeded();
        }

        public EditServiceCategory GetDetails(long id)
        {
            ServicCategory servicCategory= _serviceCategoryRepository.Get(id);
            return new EditServiceCategory
            {
                Name = servicCategory.Name,
                Description = servicCategory.Description,
                Id = servicCategory.Id,
            };
        }

        public List<ServiceCategoryViewModel> List()
        {
            return _serviceCategoryRepository.GetAll().Select(x => new ServiceCategoryViewModel
            {
                Name = x.Name,
                Description = x.Description,
                Id = x.Id,
            }).ToList();
        }

        public List<ServiceCategoryViewModel> Search(ServiceCategorySearchModel serviceCategorySearch)
        {
            throw new NotImplementedException();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceCategory.Application.Contracts.ServicesCategory;
using ServiceManagement.Application;

namespace Khabari.Areas.Administration.Pages.Services.ServiceCategory
{
    public class IndexModel : PageModel
    {
        private readonly IServiceCategoryApplication _serviceCategoryApplication;
        public ServiceCategorySearchModel searchModel;
        public List<ServiceCategoryViewModel> serviceCategory;
        public IndexModel(IServiceCategoryApplication serviceCategoryApplication)
        {
            _serviceCategoryApplication = serviceCategoryApplication;
        }

        public void OnGet()
        {
            serviceCategory = _serviceCategoryApplication.List();
        }
    }
}

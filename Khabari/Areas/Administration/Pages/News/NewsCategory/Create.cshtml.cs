using _0_Framework.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewsManagement.Application.Contracts.NewsCategory;

namespace Khabari.Areas.Administration.Pages.News.NewsCategory
{
    public class CreateModel : PageModel
    {
        public CreateNewsCategory createNewsCategory;
        private readonly INewsCategoryApplication _newsCategoryApplication;

        public CreateModel(INewsCategoryApplication newsCategoryApplication)
        {
            _newsCategoryApplication = newsCategoryApplication;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost(CreateNewsCategory createNewsCategory) 
        {
           OperationResult operation= _newsCategoryApplication.Create(createNewsCategory);
            return RedirectToPage("./Index");
        }

    }
}

using _0_Framework.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NewsManagement.Application.Contracts.NewsCategory;
using NewsManagement.Application.Contracts.OneNews;

namespace Khabari.Areas.Administration.Pages.News.OneNews
{
    public class CreateModel : PageModel
    {
        private readonly IOneNewsApplication _oneNewsApplication;
        
        private readonly INewsCategoryApplication _newsCategoryApplication;
        public CreateOneNews CreateOneNews ;
        public SelectList newsCategory;

        public CreateModel(IOneNewsApplication oneNewsApplication, IFileUploader fileUploader, INewsCategoryApplication newsCategoryApplication)
        {
            _oneNewsApplication = oneNewsApplication;
           
            _newsCategoryApplication = newsCategoryApplication;
        }

        public void OnGet()
        {
            newsCategory = new SelectList(_newsCategoryApplication.List(), "Id", "Name");
        }
        public IActionResult OnPost(CreateOneNews createOneNews)
        {
            _oneNewsApplication.Create(createOneNews);

            return RedirectToPage("Index");
        }
    }
}

using _0_Framework.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewsManagement.Application.Contracts.NewsCategory;

namespace Khabari.Areas.Administration.Pages.News.NewsCategory
{
    public class EditModel : PageModel
    {
        public EditNewsCategory editNewsCategory { get; set; }

        private readonly INewsCategoryApplication _newsCategoryApplication;

        public EditModel(INewsCategoryApplication newsCategoryApplication)
        {
            _newsCategoryApplication = newsCategoryApplication;
        }

        public void OnGet(long id)
        {
           editNewsCategory= _newsCategoryApplication.GetDetails(id);
        }
        public IActionResult OnPost(EditNewsCategory editNewsCategory)
        {
            OperationResult operation = _newsCategoryApplication.Edit(editNewsCategory);
            return RedirectToPage("./Index");
        }
    }
}

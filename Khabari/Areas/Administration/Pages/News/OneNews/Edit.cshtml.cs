using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NewsManagement.Application;
using NewsManagement.Application.Contracts.NewsCategory;
using NewsManagement.Application.Contracts.OneNews;

namespace Khabari.Areas.Administration.Pages.News.OneNews
{
    public class EditModel : PageModel
    {
        private readonly IOneNewsApplication _oneNewsApplication;
        private readonly INewsCategoryApplication _newsCategoryApplication;  
        public EditOneNews editOneNews { get; set; }
        public SelectList newsCategory;
        public EditModel(IOneNewsApplication oneNewsApplication,
            INewsCategoryApplication newsCategoryApplication)
        {
            _oneNewsApplication = oneNewsApplication;
            _newsCategoryApplication = newsCategoryApplication;
        }
        public void OnGet(int id)
        {
            editOneNews=_oneNewsApplication.GetDetails(id);
            newsCategory= new SelectList(_newsCategoryApplication.List(), "Id", "Name");
        }
        public IActionResult OnPost(EditOneNews editOneNews)
        {
            _oneNewsApplication.Edit(editOneNews);
            return RedirectToPage("Index");
        }
    }
}

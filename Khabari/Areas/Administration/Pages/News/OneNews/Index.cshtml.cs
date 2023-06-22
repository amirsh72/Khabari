using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewsManagement.Application.Contracts.OneNews;
using NewsManagement.Domain;

namespace Khabari.Areas.Administration.Pages.News.OneNews
{
    public class IndexModel : PageModel
    {
        private readonly IOneNewsApplication _oneNewsApplication;
        public OneNewsSearchModel searchModel;
        public List<OneNewsViewModel> oneNews;
        public EditOneNews News;
        public IndexModel(IOneNewsApplication oneNewsApplication)
        {
            _oneNewsApplication = oneNewsApplication;
        }

        public void OnGet()
        {
            oneNews = _oneNewsApplication.List();
        }
        public IActionResult OnGetPublish(int id)
        {
          News=_oneNewsApplication.GetDetails(id);
            
            if(News.IsPublished)
            {
                News.IsPublished = false;
            }
            else
            {
                News.IsPublished = true;
            }
            
            _oneNewsApplication.Edit(News);
            return RedirectToPage("Index");
        }
        public IActionResult OnGetDelete(int id)
        {
            News = _oneNewsApplication.GetDetails(id);
            _oneNewsApplication.Delete(News);
            
            return RedirectToPage("Index");

        }
    }
}

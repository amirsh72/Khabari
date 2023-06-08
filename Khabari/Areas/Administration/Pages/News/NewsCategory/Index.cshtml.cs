using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewsManagement.Application.Contracts.NewsCategory;
using System.Xml.Schema;

namespace Khabari.Areas.Administration.Pages.News.NewsCategory
{
    public class IndexModel : PageModel
    {
        private readonly INewsCategoryApplication _newsCategoryApplication;
        public NewsCategorySearchModel searchModel;
        public List<NewsCategoryViewModel> newsCategories;

        public IndexModel(INewsCategoryApplication newsCategoryApplication)
        {
            _newsCategoryApplication = newsCategoryApplication;
        }

        public void OnGet()
        {
            newsCategories = _newsCategoryApplication.List();
        }
    }
}

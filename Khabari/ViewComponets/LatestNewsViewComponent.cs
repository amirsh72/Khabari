using _1_KhabariQuery.Contracts.OneNews;
using _1_KhabariQuery.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Khabari.ViewComponets
{
    public class LatestNewsViewComponent:ViewComponent
    {
        private readonly IOneNewsQuery _oneNewsQuery;

        public LatestNewsViewComponent(IOneNewsQuery oneNewsQuery)
        {
            _oneNewsQuery = oneNewsQuery;
        }

        public IViewComponentResult Invoke()
        {
            var Onenews = _oneNewsQuery.GetAll();
            return View(Onenews);
        }

        
    }
}

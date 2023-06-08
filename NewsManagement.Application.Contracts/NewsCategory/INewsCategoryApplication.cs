using _0_Framework.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsManagement.Application.Contracts.NewsCategory
{
    public interface INewsCategoryApplication
    {
        OperationResult Create(CreateNewsCategory createNewsCategory);
        OperationResult Edit(EditNewsCategory editNewsCategory);
        EditNewsCategory GetDetails(long id);
        List<NewsCategoryViewModel> Search(NewsCategorySearchModel searchModel);
        List<NewsCategoryViewModel> List();

    }
}

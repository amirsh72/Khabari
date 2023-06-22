using _0_Framework.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsManagement.Application.Contracts.OneNews
{
    public interface IOneNewsApplication
    {

        OperationResult Create(CreateOneNews command);
        OperationResult Edit(EditOneNews command);
        EditOneNews GetDetails(long id);
        List<OneNewsViewModel> List();
        OperationResult Delete(EditOneNews command);

        List<OneNewsViewModel> Search(OneNewsSearchModel searchModel);
    }
}

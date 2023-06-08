using _0_Framework.Application;
using NewsManagement.Application.Contracts.OneNews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsManagement.Application
{
    public class OneNewsApplication : IOneNewsApplication
    {
        public OperationResult Create(CreateOneNews command)
        {
            throw new NotImplementedException();
        }

        public OperationResult Edit(CreateOneNews command)
        {
            throw new NotImplementedException();
        }

        public EditOneNews GetDetails(long id)
        {
            throw new NotImplementedException();
        }

        public List<OneNewsViewModel> Search(OneNewsSearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}

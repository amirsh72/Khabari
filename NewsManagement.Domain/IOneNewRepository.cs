using _0_Framework.Domain;
using NewsManagement.Application.Contracts.OneNews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsManagement.Domain
{
    public interface IOneNewRepository:IRepositoryBase<long,OneNews>
    {
        public List<OneNewsViewModel> List();
        public void Delete(OneNews one);
        public OneNews Getby(long id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_KhabariQuery.Contracts.OneNews
{
    public interface IOneNewsQuery
    {
        List<OneNewsModel> GetAll();
    }
}

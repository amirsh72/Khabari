using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsManagement.Application.Contracts.NewsCategory
{
    public class EditNewsCategory:CreateNewsCategory
    {
        public long Id { get; set; }
    }
}

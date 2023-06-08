using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsManagement.Application.Contracts.NewsCategory
{
    public class CreateNewsCategory:EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

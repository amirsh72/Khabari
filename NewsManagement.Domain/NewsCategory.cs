using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsManagement.Domain
{
    public class NewsCategory:EntityBase
    {
        public NewsCategory()
        {
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public List<OneNews> OneNews { get; set; }

    }
}

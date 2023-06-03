using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsManagement.Domain
{
    public class OneNews:EntityBase
    {
        public OneNews() 
        {

        }

        public string Subject { get; set; }
        public DateTime PublishDate { get; set; }
        public string Body { get; set; }
        public string Picture { get; set; }
        public string Tag { get; set; }
        public bool IsPublished { get; set; }
        public long NewsCategoryId { get; set; }
        public NewsCategory NewsCategory { get; set; }

    }
}

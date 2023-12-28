using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesManagement.Domain
{
    public class Service:EntityBase
    {
        public Service() 
        {

        }    

        public string Title { get; set; }
        public string Body { get; set; }
        public string Picture { get; set; }
        public string Tag { get; set; }
        public bool IsPublished { get; set; }
        public long ServiceCategoryId { get; set; }
        public ServicCategory  ServiceCategory { get; set; }



    }
}

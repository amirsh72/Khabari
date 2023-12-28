using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesManagement.Domain
{
    public  class ServicCategory:EntityBase
    {
        public ServicCategory()
        {

        }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Service> services { get; set; }


    }
}

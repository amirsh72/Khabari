using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsManagement.Application.Contracts.OneNews
{
    public class OneNewsSearchModel
    {
        public string Subject { get; set; }
        public long CategoryId { get; set; }
    }
}

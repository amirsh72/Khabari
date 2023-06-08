using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsManagement.Application.Contracts.OneNews
{
    public class CreateOneNews
    {
        public string Subject { get; set; }
        public DateTime PublishDate { get; set; }
        public string Body { get; set; }
        public IFormFile Picture { get; set; }
        public string Tag { get; set; }
        public bool IsPublished { get; set; }
        public long NewsCategoryId { get; set; }
    }
}

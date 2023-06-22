using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsManagement.Application.Contracts.OneNews
{
    public class EditOneNews:CreateOneNews
    {
        public long Id { get; set; }
        public string PictureTemp { get; set; }
        public string PublishDateTemp { get; set; }
    }
}

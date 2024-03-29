﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_KhabariQuery.Contracts.OneNews
{
    public class OneNewsModel
    {
        public long Id { get; set; }
        public string Subject { get; set; }
        public DateTime PublishDate { get; set; }
        public string Body { get; set; }
        public string Picture { get; set; }
        public string Tag { get; set; }
        public bool IsPublished { get; set; }
        public long NewsCategoryId { get; set; }
        public string NewsCategoryName { get; set; }
    }
}

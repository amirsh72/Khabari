using _1_KhabariQuery.Contracts.OneNews;

using Microsoft.EntityFrameworkCore;
using NewsManagement.Infrastructure.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_KhabariQuery.Query
{
    public class OneNewsQuery : IOneNewsQuery
    {
        private readonly OneNewsContext _oneNewsContext;

        public OneNewsQuery(OneNewsContext oneNewsContext)
        {
            _oneNewsContext = oneNewsContext;
        }

        public List<OneNewsModel> GetAll()
        {
          return  _oneNewsContext.News.Include(x => x.NewsCategory).Select(x => new OneNewsModel
            {
                Id = x.Id,
                Body = x.Body,
                IsPublished = x.IsPublished,
                NewsCategoryId = x.NewsCategoryId,
                Picture = x.Picture,
                PublishDate = x.PublishDate,
                Subject = x.Subject,
                Tag = x.Tag,
                NewsCategoryName = x.NewsCategory.Name
            }).ToList();
        }
    }
}

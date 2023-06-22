using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using NewsManagement.Application.Contracts.OneNews;
using NewsManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsManagement.Infrastructure.EFCore.Repository
{
    public class OneNewsRepository : RepositoryBase<long, OneNews>, IOneNewRepository
    {
        private readonly OneNewsContext _oneNewsDBContext;



        public OneNewsRepository(OneNewsContext oneNewsDBContext) : base(oneNewsDBContext)
        {
            _oneNewsDBContext = oneNewsDBContext;
        }

        public void Delete(OneNews one)
        {
            _oneNewsDBContext.Remove(one);
            

        }

        public OneNews Getby(long id)
        {
          return _oneNewsDBContext.News.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public List<OneNewsViewModel> List()
        {
            var query = _oneNewsDBContext.News.Include(x => x.NewsCategory)
                .Select(c => new OneNewsViewModel
                {
                    Id = c.Id,
                    Subject = c.Subject,
                    Body = c.Body,
                    IsPublished = c.IsPublished,
                    NewsCategoryId = c.NewsCategoryId,
                    NewsCategoryName = c.NewsCategory.Name,
                    Picture = c.Picture,
                    PublishDate = c.PublishDate,
                    Tag = c.Tag,

                }).ToList();
            return query;
        }

       
    }
}

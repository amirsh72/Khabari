using _0_Framework.Application;
using NewsManagement.Application.Contracts.NewsCategory;
using NewsManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsManagement.Application
{
    public class NewsCategoryApplication : INewsCategoryApplication
    {
        private readonly IFileUploader _fileUploader;
        private readonly INewsCategoryRepository _newsCategoryRepository;

        public NewsCategoryApplication(IFileUploader fileUploader,
            INewsCategoryRepository newsCategoryRepository)
        {
            _fileUploader = fileUploader;
            _newsCategoryRepository = newsCategoryRepository;
        }

        public OperationResult Create(CreateNewsCategory createNewsCategory)
        {
            var operation = new OperationResult();
            _newsCategoryRepository.Create(new NewsCategory
            {
                Name = createNewsCategory.Name,
                CreationDate = createNewsCategory.CreationDate,
                Description = createNewsCategory.Description,
            });
            _newsCategoryRepository.SaveChange();

            return operation.Succeded();

        }

        public OperationResult Edit(EditNewsCategory editNewsCategory)
        {

            var operation = new OperationResult();
            _newsCategoryRepository.Edit(new NewsCategory
            {
                Id=editNewsCategory.Id,
                Name = editNewsCategory.Name,
                CreationDate = editNewsCategory.CreationDate,
                Description = editNewsCategory.Description,
            });
            _newsCategoryRepository.SaveChange();

            return operation.Succeded();
        }

        public EditNewsCategory GetDetails(long id)
        {
            NewsCategory newsCategory= _newsCategoryRepository.Get(id);
            return new EditNewsCategory
            {
                Description = newsCategory.Description,
                CreationDate = newsCategory.CreationDate,
                Id = id,
                Name = newsCategory.Name,

            };
            
        }

        public List<NewsCategoryViewModel> List()
        {
            List<NewsCategoryViewModel> newsCategories = _newsCategoryRepository.
                GetAll().Select(x => new NewsCategoryViewModel
                {
                    Id = x.Id,
                    Description = x.Description,
                    Name = x.Name,
                    CreationDate=x.CreationDate.ToFarsi(),
                }).ToList();
            return newsCategories;
        }

        public List<NewsCategoryViewModel> Search(NewsCategorySearchModel searchModel)
        {
            throw new NotImplementedException();
        }

    }
}

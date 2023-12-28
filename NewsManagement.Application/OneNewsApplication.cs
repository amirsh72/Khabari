using _0_Framework.Application;
using NewsManagement.Application.Contracts.OneNews;
using NewsManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsManagement.Application
{
    public class OneNewsApplication : IOneNewsApplication
    {

        private readonly IOneNewRepository _oneNewRepository;
        private readonly IFileUploader _fileUploader;

        public OneNewsApplication(IOneNewRepository neNewRepository,
            IFileUploader fileUploader)
        {
            _oneNewRepository = neNewRepository;
            _fileUploader = fileUploader;
        }

        public OperationResult Create(CreateOneNews command)
        {
            OperationResult result = new OperationResult();
            Random random = new Random();
            string path = $"{random.Next(1, 10000)}&{DateTime.Now.Minute}&{DateTime.Now.Second}";
            var picturename = _fileUploader.Upload(command.Picture, path);
            OneNews oneNews = new OneNews
            {
                Body = command.Body,
                Subject = command.Subject,
                IsPublished = false,
                Tag = command.Tag,
                PublishDate = command.PublishDate,
                NewsCategoryId = command.NewsCategoryId,
                Picture = picturename,
            };
            _oneNewRepository.Create(oneNews);
            _oneNewRepository.SaveChange();
            return result.Succeded();
        }

        public OperationResult Delete(EditOneNews command)
        {
            var operation=new OperationResult();
            OneNews oneNews = new OneNews
            {
                Id= command.Id,
                Body = command.Body,
                Subject = command.Subject,
                IsPublished = false,
                Tag = command.Tag,
                PublishDate = command.PublishDate,
                NewsCategoryId = command.NewsCategoryId,
                Picture = command.PictureTemp,

            };
            _oneNewRepository.Delete(oneNews);
            _oneNewRepository.SaveChange();
            return operation;

        }

        public OperationResult Edit(EditOneNews command)
        {
            OperationResult operation = new OperationResult();

            OneNews oneNews = new OneNews
            {
                Id = command.Id,
                Subject = command.Subject,
                Body = command.Body,
                IsPublished = command.IsPublished,
                NewsCategoryId = command.NewsCategoryId,
                Picture = command.PictureTemp,
                PublishDate = command.PublishDate,
                Tag = command.Tag,
            };
            _oneNewRepository.Edit(oneNews);
            _oneNewRepository.SaveChange();
            return operation.Succeded();
        }

        public EditOneNews GetDetails(long id)
        {
            OneNews editOneNews = _oneNewRepository.Getby(id);
            
            return new EditOneNews
            {
                Id = editOneNews.Id,
                Subject = editOneNews.Subject,
                Body = editOneNews.Body,
                IsPublished = editOneNews.IsPublished,
                NewsCategoryId = editOneNews.NewsCategoryId,
                PictureTemp = editOneNews.Picture,
                PublishDateTemp = editOneNews.PublishDate.ToFarsi(),
                Tag = editOneNews.Tag,
            };
        }

        public List<OneNewsViewModel> List()
        {
            return _oneNewRepository.List();
        }

        

        public List<OneNewsViewModel> Search(OneNewsSearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}

using _0_Framework.Application;

namespace Khabari
{
    public class FileUploader:IFileUploader
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUploader(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public void Delete(string path)
        {
            if (path == null)
                File.Delete($"{_webHostEnvironment.WebRootPath}//Images//{path}");
        }

        public string Upload(IFormFile file, string path)
        {
            if (file == null)
                return "";
            var directoryPath = $"{_webHostEnvironment.WebRootPath}//Images//{path}";
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);
            var filename = $"{DateTime.Now.ToFileName()}-{file.FileName}";

            var filePath = $"{directoryPath}//{filename}";

            using var output = File.Create(filePath);
            file.CopyTo(output);
            return $"{path}/{filename}";
        }

    }
}

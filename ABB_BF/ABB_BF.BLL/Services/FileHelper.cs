using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using FileHelpers;

namespace ABB_BF.BLL.Services
{
    public class FileHelper : IFileHelper
    {
        private string _rootPath = "./././newFolder";

        public async Task<string> GetScv<T>(List<T> forms) where T : class
        {
            var engine = new FileHelperEngine<T>();

            engine.Encoding = System.Text.Encoding.UTF32;
            engine.HeaderText = engine.GetFileHeader();

            var fileName = $"{typeof(T)}_{DateTime.Now.ToShortDateString()}.csv";

            engine.WriteFile(fileName, forms);
            return fileName;
        }

        public async Task<string> CreateZipWithFormsInfo(List<AbstractEntityModel> list)
        {
            Directory.CreateDirectory(_rootPath);

            foreach (AbstractEntityModel model in list)
            {
                string firstname = model.Firstname;
                string secondname = model.Secondname;
                Directory.CreateDirectory($"{_rootPath}/{firstname}_{secondname}");

                foreach (AbstractFormFileModel file in model.Files)
                {
                    string filename = $"{_rootPath}/{firstname}_{secondname}/{file.Name}.{file.Extension}";
                    File.WriteAllBytes(filename, file.Data);
                }
            }

            return _rootPath;
        }
    }
}

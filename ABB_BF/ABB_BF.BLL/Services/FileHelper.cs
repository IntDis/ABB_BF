using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using OfficeOpenXml;
using System.IO.Compression;

namespace ABB_BF.BLL.Services
{
    public class FileHelper : IFileHelper
    {
        private string _rootPath = "./././";

        public async Task<string> GetScv<T>(List<T> forms) where T : class
        {
            Directory.CreateDirectory($"{_rootPath}newFolder");
            string excelName = $"{_rootPath}newFolder/{typeof(T).Name}_{DateTime.Now.ToShortDateString()}.xlsx";

            var stream = new MemoryStream();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(stream))
            {
                var workSheet = package.Workbook.Worksheets.Add("sheet");
                workSheet.Cells.LoadFromCollection(forms, true);
                package.SaveAs(excelName);
            }
          
            return excelName;
        }

        public string CreateXlsx<T>(List<T> forms) where T : class
        {
            string excelName = $"{_rootPath}{typeof(T).Name}_{DateTime.Now.ToShortDateString()}.xlsx";

            var stream = new MemoryStream();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(stream))
            {
                var workSheet = package.Workbook.Worksheets.Add("sheet");
                workSheet.Cells.LoadFromCollection(forms, true);
                package.SaveAs(excelName);
            }

            return excelName;
        }

        public async Task<string> CreateFolderWithFormsInfo<T>(List<AbstractEntityModel> list, List<T> models)
            where T : class
        {
            string pathToXltx = await GetScv(models);

            foreach (AbstractEntityModel model in list)
            {
                string firstname = model.Firstname;
                string secondname = model.Secondname;
                Directory.CreateDirectory($"{_rootPath}newFolder/{firstname}_{secondname}");

                foreach (AbstractFormFileModel file in model.Files)
                {
                    string filename = $"{_rootPath}newFolder/{firstname}_{secondname}/{file.Name}";
                    File.WriteAllBytes(filename, file.Data);
                }
            }

            return $"{_rootPath}newFolder";
        }

        public async Task<string> CreateZip(string startPath, string zipPath)
        {
            if (File.Exists(zipPath))
            {
                File.Delete(zipPath);
            }

            ZipFile.CreateFromDirectory(startPath, zipPath);
            Directory.Delete(startPath, true);
            return zipPath;
        }
    }
}

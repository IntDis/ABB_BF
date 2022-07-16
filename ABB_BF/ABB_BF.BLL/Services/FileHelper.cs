using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using OfficeOpenXml;
using System.IO.Compression;

namespace ABB_BF.BLL.Services
{
    // sorry for files and folders naming :(
    // fix it pls
    public class FileHelper : IFileHelper
    {
        private static readonly string _rootPathEnvVarName = "ROOT_PATH";
        private readonly string _rootPath = Environment.GetEnvironmentVariable(_rootPathEnvVarName);

        public async Task<string> CreateXlsx<T>(List<T> forms, string fileName) where T : class
        {
            Directory.CreateDirectory($"{_rootPath}newFolder");
            string excelName = $"{_rootPath}newFolder";

            var stream = new MemoryStream();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(stream))
            {
                var workSheet = package.Workbook.Worksheets.Add("sheet");
                workSheet.Cells.LoadFromCollection(forms, true);
                package.SaveAs($"{excelName}/{fileName}.xlsx");
            }

            return excelName;
        }

        public async Task<string> CreateFolderWithFormsInfo<T>(List<AbstractEntityModel> list, List<T> models)
            where T : class
        {
            await CreateXlsx(models, "tempfolder");

            foreach (AbstractEntityModel model in list)
            {
                string firstname = model.Firstname;
                string secondname = model.Secondname;
                int modelId = model.Id;

                Directory.CreateDirectory($"{_rootPath}newFolder/{modelId}_{firstname}_{secondname}");

                foreach (AbstractFormFileModel file in model.Files)
                {
                    string filename = $"{_rootPath}newFolder/{modelId}_{firstname}_{secondname}/{file.Name}";
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

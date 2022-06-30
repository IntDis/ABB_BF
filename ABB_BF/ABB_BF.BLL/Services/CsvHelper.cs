using ABB_BF.BLL.Services.Interfaces;
using FileHelpers;

namespace ABB_BF.BLL.Services
{
    public class CsvHelper : ICsvHelper
    {
        public async Task<string> GetScv<T>(List<T> forms) where T : class
        {
            var engine = new FileHelperEngine<T>();

            engine.Encoding = System.Text.Encoding.UTF32;
            engine.HeaderText = engine.GetFileHeader();

            var fileName = $"{typeof(T)}_{DateTime.Now.ToShortDateString()}.csv";

            engine.WriteFile(fileName, forms);
            return fileName;
        }
    }
}

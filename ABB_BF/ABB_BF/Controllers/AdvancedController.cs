using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ABB_BF.Controllers
{
    public class AdvancedController : Controller
    {
        protected byte[] GetBytes(IFormFile file)
        {
            var binaryReader = new BinaryReader(file.OpenReadStream());
            return binaryReader.ReadBytes((int)file.Length);
        }
    }
}

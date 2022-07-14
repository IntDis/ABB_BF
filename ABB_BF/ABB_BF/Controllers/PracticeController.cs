using ABB_BF.API.Models.Requests;
using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.Models.Requests;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ABB_BF.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class PracticeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPracticeService _practiceService;
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly IFileHelper _fileHelper;

        public PracticeController(IMapper mapper,
            IPracticeService practiceService,
            IWebHostEnvironment appEnvironment,
            IFileHelper fileHelper)
        {
            _mapper = mapper;
            _practiceService = practiceService;
            _appEnvironment = appEnvironment;
            _fileHelper = fileHelper;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddPractice([FromForm] AddPracticeRequest practiceRequest)
        {
            PracticeModel model = _mapper.Map<PracticeModel>(practiceRequest);
            return Ok(await _practiceService.AddPractice(model));
        }

        [HttpGet("download")]
        public async Task<ActionResult> DownloadZip(FilterRequest filters)
        {
            List<PracticeModel> models = await _practiceService.GetAll(_mapper.Map<FilterModel>(filters));

            string path = await _fileHelper
                .CreateFolderWithFormsInfo(
                _mapper.Map<List<AbstractEntityModel>>(models), models);

            string zipPath = await _fileHelper.CreateZip(path, $"{path}.zip");

            var fs = new FileStream(zipPath,
                FileMode.Open,
                FileAccess.Read,
                FileShare.None,
                4096,
                FileOptions.DeleteOnClose);

            return File(
                fileStream: fs,
                contentType: "application/zip",
                fileDownloadName: "file.zip");
        }
    }
}

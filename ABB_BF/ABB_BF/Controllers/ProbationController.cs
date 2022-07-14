using ABB_BF.API.Models.Requests;
using ABB_BF.API.Models.Responses;
using ABB_BF.BLL.Models;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.Models.Requests;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ABB_BF.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class ProbationController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProbationService _probationService;
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly IFileHelper _fileHelper;

        public ProbationController(IMapper mapper,
            IProbationService probationService,
            IWebHostEnvironment appEnvironment,
            IFileHelper fileHelper)
        {
            _mapper = mapper;
            _probationService = probationService;
            _appEnvironment = appEnvironment;
            _fileHelper = fileHelper;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddProbation([FromForm]AddProbationRequest requestModel)
        {
            ProbationModel model = _mapper.Map<ProbationModel>(requestModel);
            return Ok(await _probationService.AddProbation(model));
        }

        [HttpGet("download")]
        public async Task<ActionResult> DownloadZip(FilterRequest filter)
        {
            List<ProbationModel> models = await _probationService.GetAll(_mapper.Map<FilterModel>(filter));

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

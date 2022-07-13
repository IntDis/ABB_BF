﻿using ABB_BF.API.Models.Responses;
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

        [HttpGet]
        public async Task<ActionResult<List<ProbationResponse>>> GetAll()
        {
            return Ok(_mapper.Map<List<ProbationResponse>>(await _probationService.GetAll()));
        }

        [HttpGet("csv")]
        public async Task<ActionResult> DownloadCsv()
        {
            string fileName = await _probationService.CreateCsv();

            string fileType = "application/csv";
            string filePath = Path.Combine(_appEnvironment.ContentRootPath, fileName);

            var fs = new FileStream(filePath,
                FileMode.Open,
                FileAccess.Read,
                FileShare.None,
                4096,
                FileOptions.DeleteOnClose);
            
            return File(
                fileStream: fs,
                contentType: fileType,
                fileDownloadName: "File.xlsx");
        }

        [HttpGet("zip")]
        public async Task<ActionResult> CreateZip()
        {
            List<ProbationModel> models = await _probationService.GetAll();

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

        //[HttpGet("{id}/download")]
        //public async Task<ActionResult> GetFile(int id)
        //{
        //    ProbationModel probation = await _probationService.GetById(id);
        //    ProbationFileModel file = probation.Files[0];

        //    string filename = Path.Combine(_appEnvironment.ContentRootPath, file.Name) + "." + file.Extension;

        //    System.IO.File.WriteAllBytes(filename, file.Data);

        //    //var p = new Process();
        //    //p.StartInfo = new ProcessStartInfo(filename)
        //    //{
        //    //    UseShellExecute = true
        //    //};

        //    //p.Start();

        //    //p.Exited += (s, e) => File.Delete(filename);

        //    return PhysicalFile(filename, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", file.Name);
        //}
    }
}

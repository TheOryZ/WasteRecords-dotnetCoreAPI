using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WasteRecords.API.CustomFilters;
using WasteRecords.Core.Dtos.Record;
using WasteRecords.Core.Entities;
using WasteRecords.Core.Helpers;
using WasteRecords.Core.Interfaces.Services;

namespace WasteRecords.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private readonly IRecordService _recordService;
        private readonly IMapper _mapper;

        public RecordsController(IRecordService recordService, IMapper mapper)
        {
            _recordService = recordService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var records = await _recordService.GetAllAsync();
            Response<List<RecordListDto>> response = new()
            {
                Message = "Success",
                IsSuccess = true,
                StatusCode = 200,
                Content = _mapper.Map<List<RecordListDto>>(records)
            };
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var record = await _recordService.GetByIdAsync(id);
            Response<RecordListDto> response = new();
            if(record != null)
            {
                response.Message = "Success";
                response.StatusCode = 200;
                response.IsSuccess = true;
                response.Content = _mapper.Map<RecordListDto>(record);
                return Ok(response);
            }
            else
            {
                response.Message = "Fail";
                response.StatusCode = 404;
                response.IsSuccess = false;
                response.Errors = new Dictionary<string, List<string>>(){
                    {"BadRequest", new List<string>(){ "This record number is does not exist" }} 
                };
                return BadRequest(response);
            }
        }
        [HttpPost]
        [ValidModel]
        [Authorize]
        public async Task<IActionResult> Add(RecordAddDto recordAddDto)
        {
            var recordModel = await _recordService.AddAsync(_mapper.Map<Record>(recordAddDto));
            Response<RecordListDto> response = new();
            if(recordModel != null)
            {
                response.Message = "Success";
                response.StatusCode = 201;
                response.IsSuccess = true;
                response.Content = _mapper.Map<RecordListDto>(recordModel);
                return Created("", response);
            }
            else
            {
                response.Message = "Fail";
                response.StatusCode = 404;
                response.IsSuccess = false;
                response.Errors = new Dictionary<string, List<string>>(){
                    {"BadRequest", new List<string>(){ "This record could not be added" }}
                };
                return BadRequest(response);
            }
        }
        [HttpPut]
        [ValidModel]
        [Authorize]
        public IActionResult Update(RecordUpdateDto recordUpdateDto)
        {
            var recordModel = _recordService.Update(_mapper.Map<Record>(recordUpdateDto));
            Response<RecordListDto> response = new();
            if (recordModel != null)
            {
                response.Message = "Success";
                response.StatusCode = 204;
                response.IsSuccess = true;
                return Ok(response);
            }
            else
            {
                response.Message = "Fail";
                response.StatusCode = 404;
                response.IsSuccess = false;
                response.Errors = new Dictionary<string, List<string>>(){
                    {"BadRequest", new List<string>(){ "This record could not be updated" }}
                };
                return BadRequest(response);
            }
        }
        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Remove(int id)
        {
            var recordModel = _recordService.GetByIdAsync(id).Result;
            _recordService.Remove(recordModel);
            Response<RecordListDto> response = new();
            if (recordModel != null)
            {
                response.Message = "Success";
                response.StatusCode = 204;
                response.IsSuccess = true;
                return Ok(response);
            }
            else
            {
                response.Message = "Fail";
                response.StatusCode = 404;
                response.IsSuccess = false;
                response.Errors = new Dictionary<string, List<string>>(){
                    {"BadRequest", new List<string>(){ "This record could not be deleted" }}
                };
                return BadRequest(response);
            }
        }
    }
}

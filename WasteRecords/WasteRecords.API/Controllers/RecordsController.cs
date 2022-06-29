using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WasteRecords.Core.Dtos.Record;
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
    }
}

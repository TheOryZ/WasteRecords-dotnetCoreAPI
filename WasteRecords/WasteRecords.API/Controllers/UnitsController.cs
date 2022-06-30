using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WasteRecords.Core.Dtos.Unit;
using WasteRecords.Core.Helpers;
using WasteRecords.Core.Interfaces.Services;

namespace WasteRecords.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitsController : ControllerBase
    {
        private readonly IUnitService _unitService;
        private readonly IMapper _mapper;

        public UnitsController(IUnitService unitService, IMapper mapper)
        {
            _unitService = unitService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var units = await _unitService.GetAllAsync();
            Response<List<UnitListDto>> response = new()
            {
                Message = "Success",
                IsSuccess = true,
                StatusCode = 200,
                Content = _mapper.Map<List<UnitListDto>>(units)
            };
            return Ok(response);
        }
    }
}

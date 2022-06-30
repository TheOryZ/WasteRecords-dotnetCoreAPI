using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WasteRecords.Core.Dtos.WasteType;
using WasteRecords.Core.Helpers;
using WasteRecords.Core.Interfaces.Services;

namespace WasteRecords.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WasteTypesController : ControllerBase
    {
        private readonly IWasteTypeService _wasteTypeService;
        private readonly IMapper _mapper;

        public WasteTypesController(IWasteTypeService wasteTypeService, IMapper mapper)
        {
            _wasteTypeService = wasteTypeService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var wasteTypes = await _wasteTypeService.GetAllAsync();
            Response<List<WasteTypeListDto>> response = new()
            {
                Message = "Success",
                IsSuccess = true,
                StatusCode = 200,
                Content = _mapper.Map<List<WasteTypeListDto>>(wasteTypes)
            };
            return Ok(response);
        }
    }
}

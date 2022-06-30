using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WasteRecords.Core.Dtos.KindOfWaste;
using WasteRecords.Core.Helpers;
using WasteRecords.Core.Interfaces.Services;

namespace WasteRecords.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KindOfWastesController : ControllerBase
    {
        private readonly IKindOfWasteService _kindOfWasteService;
        private readonly IMapper _mapper;

        public KindOfWastesController(IKindOfWasteService kindOfWasteService, IMapper mapper)
        {
            _kindOfWasteService = kindOfWasteService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var kindOfWastes = await _kindOfWasteService.GetAllAsync();
            Response<List<KindOfWasteListDto>> response = new()
            {
                Message = "Success",
                IsSuccess = true,
                StatusCode = 200,
                Content = _mapper.Map<List<KindOfWasteListDto>>(kindOfWastes)
            };
            return Ok(response);
        }
    }
}

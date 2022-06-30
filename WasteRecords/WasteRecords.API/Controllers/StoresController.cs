using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WasteRecords.Core.Dtos.Store;
using WasteRecords.Core.Helpers;
using WasteRecords.Core.Interfaces.Services;

namespace WasteRecords.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        private readonly IStoreService _storeService;
        private readonly IMapper _mapper;

        public StoresController(IStoreService storeService, IMapper mapper)
        {
            _storeService = storeService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var stores = await _storeService.GetAllAsync();
            Response<List<StoreListDto>> response = new()
            {
                Message = "Success",
                IsSuccess = true,
                StatusCode = 200,
                Content = _mapper.Map<List<StoreListDto>>(stores)
            };
            return Ok(response);
        }
    }
}

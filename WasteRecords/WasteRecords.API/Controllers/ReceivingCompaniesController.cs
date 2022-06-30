using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WasteRecords.Core.Dtos.ReceivingCompany;
using WasteRecords.Core.Helpers;
using WasteRecords.Core.Interfaces.Services;

namespace WasteRecords.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceivingCompaniesController : ControllerBase
    {
        private readonly IReceivingCompanyService _receivingCompanyService;
        private readonly IMapper _mapper;

        public ReceivingCompaniesController(IReceivingCompanyService receivingCompanyService, IMapper mapper)
        {
            _receivingCompanyService = receivingCompanyService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var companies = await _receivingCompanyService.GetAllAsync();
            Response<List<ReceivingCompanyListDto>> response = new()
            {
                Message = "Success",
                IsSuccess = true,
                StatusCode = 200,
                Content = _mapper.Map<List<ReceivingCompanyListDto>>(companies)
            };
            return Ok(response);
        }
    }
}

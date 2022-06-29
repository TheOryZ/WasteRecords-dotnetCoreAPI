using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WasteRecords.API.CustomFilters;
using WasteRecords.Core.Dtos.User;
using WasteRecords.Core.Entities;
using WasteRecords.Core.Helpers;
using WasteRecords.Core.Interfaces.Services;
using WasteRecords.Service.Tools.JWT;

namespace WasteRecords.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IJwtService _jwtService;
        private readonly IMapper _mapper;

        public AuthController(IUserService userService, IJwtService jwtService, IMapper mapper)
        {
            _userService = userService;
            _jwtService = jwtService;
            _mapper = mapper;
        }
        [HttpPost("[action]")]
        [ValidModel]
        public async Task<IActionResult> SignIn(UserSignInDto userSignInDto)
        {
            Response<string> response = new Response<string>();
            var user = await _userService.CheckUserAsync(_mapper.Map<User>(userSignInDto));
            if(user != null)
            {
                response.Message = "Login is success";
                response.StatusCode = 201;
                response.IsSuccess = true;
                response.Content = _jwtService.GenerateJwt(user).Token;
                return Created("", response);
            }
            else
            {
                response.Message = "User email or password is wrong";
                response.StatusCode = 400;
                response.IsSuccess = false;
                response.Errors = new Dictionary<string, List<string>>(){
                    {"BadRequest", new List<string>(){ "User email or password is wrong" }} 
                };
                return BadRequest(response);
            }
        }
    }
}

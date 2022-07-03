using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using WasteRecords.WebUI.ApiServices.Interfaces;
using WasteRecords.WebUI.Models;
using WasteRecords.WebUI.Models.KinfOfWaste;
using WasteRecords.WebUI.Models.ReceivingCompany;
using WasteRecords.WebUI.Models.RecordModels;
using WasteRecords.WebUI.Models.Store;
using WasteRecords.WebUI.Models.Unit;
using WasteRecords.WebUI.Models.UserModels;
using WasteRecords.WebUI.Models.WasteType;

namespace WasteRecords.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAuthApiService _authApiService;
        private readonly IUnitApiService _unitApiService;
        private readonly IStoreApiService _storeApiService;
        private readonly IWasteTypeApiService _wasteTypeApiService;
        private readonly IKindOfWasteApiService _kindOfWasteApiService;
        private readonly IReceivingCompanyApiService _receivingCompanyApiService;
        private readonly IRecordApiService _recordApiService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string token;

        public HomeController(ILogger<HomeController> logger, IAuthApiService authApiService, IUnitApiService unitApiService,
            IStoreApiService storeApiService, IWasteTypeApiService wasteTypeApiService, IKindOfWasteApiService kindOfWasteApiService,
            IReceivingCompanyApiService receivingCompanyApiService, IRecordApiService recordApiService, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _authApiService = authApiService;
            _unitApiService = unitApiService;
            _storeApiService = storeApiService;
            _wasteTypeApiService = wasteTypeApiService;
            _kindOfWasteApiService = kindOfWasteApiService;
            _receivingCompanyApiService = receivingCompanyApiService;
            _recordApiService = recordApiService;
            _httpContextAccessor = httpContextAccessor;
            token = _httpContextAccessor.HttpContext.Session.GetString("token");
        }

        public IActionResult Index()
        {
            var response = _recordApiService.GetAllWithParameters();

            return View(response.Content);


        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(SignInViewModel model)
        {
            TempData["message"] = "Email or Password is wrong";
            TempData["status"] = "error";
            if (_authApiService.SignIn(model))
            {
                TempData["status"] = "success";
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
        [HttpGet]
        public JsonResult GetInformationById(int id)
        {
            //models
            List<UnitListViewModel> unitListViewModel = new List<UnitListViewModel>();
            List<StoreListViewModel> storeListViewModel = new List<StoreListViewModel>();
            List<WasteTypeListViewModel> wasteTypeListViewModel = new List<WasteTypeListViewModel>();
            List<KindOfWasteListViewModel> kindOfWasteListViewModel = new List<KindOfWasteListViewModel>();
            List<ReceivingCompanyListViewModel> receivingCompanyListViewModel = new List<ReceivingCompanyListViewModel>();
            RecordListViewModel recordListViewModel = new RecordListViewModel();
            //apiServices
            var responseUnit = _unitApiService.GetAll();
            unitListViewModel = responseUnit.Content;
            var responseStore = _storeApiService.GetAll();
            storeListViewModel = responseStore.Content;
            var responseWasteType = _wasteTypeApiService.GetAll();
            wasteTypeListViewModel = responseWasteType.Content;
            var responseKindOfWaste = _kindOfWasteApiService.GetAll();
            kindOfWasteListViewModel = responseKindOfWaste.Content;
            var responseCompany = _receivingCompanyApiService.GetAll();
            receivingCompanyListViewModel = responseCompany.Content;
            var responseRecord = _recordApiService.GetById(id);
            recordListViewModel = responseRecord.Content;
            //Model bind
            IndexViewModel model = new IndexViewModel()
            {
                Record = recordListViewModel,
                Stores = storeListViewModel,
                Units = unitListViewModel,
                wasteTypes = wasteTypeListViewModel,
                KindOfWastes = kindOfWasteListViewModel,
                ReceivingCompanies = receivingCompanyListViewModel
            };
            var result = JsonConvert.SerializeObject(model);
            return Json(new {success =true, content = result});
        }
        public JsonResult GetInformations()
        {
            //models
            List<UnitListViewModel> unitListViewModel = new List<UnitListViewModel>();
            List<StoreListViewModel> storeListViewModel = new List<StoreListViewModel>();
            List<WasteTypeListViewModel> wasteTypeListViewModel = new List<WasteTypeListViewModel>();
            List<KindOfWasteListViewModel> kindOfWasteListViewModel = new List<KindOfWasteListViewModel>();
            List<ReceivingCompanyListViewModel> receivingCompanyListViewModel = new List<ReceivingCompanyListViewModel>();
            //apiServices
            var responseUnit = _unitApiService.GetAll();
            unitListViewModel = responseUnit.Content;
            var responseStore = _storeApiService.GetAll();
            storeListViewModel = responseStore.Content;
            var responseWasteType = _wasteTypeApiService.GetAll();
            wasteTypeListViewModel = responseWasteType.Content;
            var responseKindOfWaste = _kindOfWasteApiService.GetAll();
            kindOfWasteListViewModel = responseKindOfWaste.Content;
            var responseCompany = _receivingCompanyApiService.GetAll();
            receivingCompanyListViewModel = responseCompany.Content;
            //Model bind
            IndexViewModel model = new IndexViewModel()
            {
                Stores = storeListViewModel,
                Units = unitListViewModel,
                wasteTypes = wasteTypeListViewModel,
                KindOfWastes = kindOfWasteListViewModel,
                ReceivingCompanies = receivingCompanyListViewModel
            };
            var result = JsonConvert.SerializeObject(model);
            return Json(result);
        }

        [HttpPost]
        public JsonResult Create(RecordAddViewModel model)
        {
            var response = _recordApiService.Add(model, token);
            if (response.IsSuccess)
                return Json(new { success = true });
            return Json(new { success = false });

        }
        [HttpDelete]
        public IActionResult Remove(int id)
        {
            var response = _recordApiService.Remove(id, token);
            if (response.IsSuccess)
                return Json(new { success = true, message = "The record has been successfully deleted" });
            return Json(new { success = false, message = "An unexpected error occurred while deleting the record" });
        }

        [HttpPut]
        public IActionResult Update(RecordUpdateViewModel model)
        {
            var response = _recordApiService.Update(model, token);
            if (response.IsSuccess)
                return Json(new { success = true, message = "The record has been successfully updated" });
            return Json(new { success = false, message = "An unexpected error occurred while updating the record" });


        }
    }
}
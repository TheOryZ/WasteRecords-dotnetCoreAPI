using AutoMapper;
using WasteRecords.Core.Dtos.KindOfWaste;
using WasteRecords.Core.Dtos.ReceivingCompany;
using WasteRecords.Core.Dtos.Record;
using WasteRecords.Core.Dtos.Store;
using WasteRecords.Core.Dtos.Unit;
using WasteRecords.Core.Dtos.User;
using WasteRecords.Core.Dtos.WasteType;
using WasteRecords.Core.Entities;

namespace WasteRecords.API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            #region User Mapping
            CreateMap<User, UserListDto>().ReverseMap();
            CreateMap<User, UserAddDto>().ReverseMap();
            CreateMap<User, UserUpdateDto>().ReverseMap();
            CreateMap<User, UserSignInDto>().ReverseMap();
            #endregion
            #region Store Mapping
            CreateMap<Store, StoreListDto>().ReverseMap();
            CreateMap<Store, StoreAddDto>().ReverseMap();
            CreateMap<Store, StoreUpdateDto>().ReverseMap();
            #endregion
            #region Unit Mapping
            CreateMap<Unit, UnitListDto>().ReverseMap();
            CreateMap<Unit, UnitAddDto>().ReverseMap();
            CreateMap<Unit, UnitUpdateDto>().ReverseMap();
            #endregion
            #region WasteType Mapping
            CreateMap<WasteType, WasteTypeListDto>().ReverseMap();
            CreateMap<WasteType, WasteTypeAddDto>().ReverseMap();
            CreateMap<WasteType, WasteTypeUpdateDto>().ReverseMap();
            #endregion
            #region KindOfWaste Mapping
            CreateMap<KindOfWaste, KindOfWasteListDto>().ReverseMap();
            CreateMap<KindOfWaste, KindOfWasteAddDto>().ReverseMap();
            CreateMap<KindOfWaste, KindOfWasteUpdateDto>().ReverseMap();
            #endregion
            #region ReceivingCompany Mapping
            CreateMap<ReceivingCompany, ReceivingCompanyListDto>().ReverseMap();
            CreateMap<ReceivingCompany, ReceivingCompanyAddDto>().ReverseMap();
            CreateMap<ReceivingCompany, ReceivingCompanyUpdateDto>().ReverseMap();
            #endregion
            #region Record Mapping
            CreateMap<Record, RecordListDto>().ReverseMap();
            CreateMap<Record, RecordListWithRelationsDto>().ReverseMap();
            CreateMap<Record, RecordAddDto>().ReverseMap();
            CreateMap<Record, RecordUpdateDto>().ReverseMap();
            #endregion
        }
    }
}

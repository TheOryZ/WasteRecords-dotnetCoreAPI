using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using WasteRecords.Core.Dtos.KindOfWaste;
using WasteRecords.Core.Dtos.ReceivingCompany;
using WasteRecords.Core.Dtos.Record;
using WasteRecords.Core.Dtos.Store;
using WasteRecords.Core.Dtos.Unit;
using WasteRecords.Core.Dtos.User;
using WasteRecords.Core.Dtos.WasteType;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Core.Interfaces.Services;
using WasteRecords.Data.Concrete.EntityFrameworkCore.Context;
using WasteRecords.Data.Concrete.EntityFrameworkCore.Repositories;
using WasteRecords.Service.Services;
using WasteRecords.Service.Tools.JWT;
using WasteRecords.Service.ValidationRules.FluentValidation;

namespace WasteRecords.Service.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();
            #region Generic repositories and services
            services.AddScoped(typeof(IGenericRepository<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
            #endregion
            #region Repositories
            services.AddScoped<IUserRepository, EfUserRepository>();
            services.AddScoped<IStoreRepository, EfStoreRepository>();
            services.AddScoped<IUnitRepository, EfUnitRepository>();
            services.AddScoped<IWasteTypeRepository, EfWasteTypeRepository>();
            services.AddScoped<IKindOfWasteRepository, EfKindOfWasteRepository>();
            services.AddScoped<IReceivingCompanyRepository, EfReceivingCompanyRepository>();
            services.AddScoped<IRecordRepository, EfRecordRepository>();
            #endregion
            #region Services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IStoreService, StoreService>();
            services.AddScoped<IUnitService, UnitService>();
            services.AddScoped<IWasteTypeService, WasteTypeService>();
            services.AddScoped<IKindOfWasteService, KindOfWasteService>();
            services.AddScoped<IReceivingCompanyService, ReceivingCompanyService>();
            services.AddScoped<IRecordService, RecordService>();
            #endregion
            #region Validators
            services.AddTransient<IValidator<UserAddDto>, UserAddValidator>();
            services.AddTransient<IValidator<UserUpdateDto>, UserUpdateValidator>();
            services.AddTransient<IValidator<StoreAddDto>, StoreAddValidator>();
            services.AddTransient<IValidator<StoreUpdateDto>, StoreUpdateValidator>();
            services.AddTransient<IValidator<UnitAddDto>, UnitAddValidator>();
            services.AddTransient<IValidator<UnitUpdateDto>, UnitUpdateValidator>();
            services.AddTransient<IValidator<WasteTypeAddDto>, WasteTypeAddValidator>();
            services.AddTransient<IValidator<WasteTypeUpdateDto>, WasteTypeUpdateValidator>();
            services.AddTransient<IValidator<KindOfWasteAddDto>, KindOfWasteAddValidator>();
            services.AddTransient<IValidator<KindOfWasteUpdateDto>, KindOfWasteUpdateValidator>();
            services.AddTransient<IValidator<ReceivingCompanyAddDto>, ReceivingCompanyAddValidator>();
            services.AddTransient<IValidator<ReceivingCompanyUpdateDto>, ReceivingCompanyUpdateValidator>();
            services.AddTransient<IValidator<RecordAddDto>, RecordAddValidator>();
            services.AddTransient<IValidator<RecordUpdateDto>, RecordUpdateValidator>();
            #endregion
            #region JWT
            services.AddScoped<IJwtService, JwtService>();
            #endregion
        }
    }
}

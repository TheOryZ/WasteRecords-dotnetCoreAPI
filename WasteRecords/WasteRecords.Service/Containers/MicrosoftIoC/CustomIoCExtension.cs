using Microsoft.Extensions.DependencyInjection;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Core.Interfaces.Services;
using WasteRecords.Data.Concrete.EntityFrameworkCore.Context;
using WasteRecords.Data.Concrete.EntityFrameworkCore.Repositories;
using WasteRecords.Service.Services;

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

            #endregion
            #region JWT

            #endregion
        }
    }
}

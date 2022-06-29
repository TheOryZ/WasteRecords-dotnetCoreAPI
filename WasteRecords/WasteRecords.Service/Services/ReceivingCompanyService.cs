using WasteRecords.Core.Entities;
using WasteRecords.Core.Interfaces.Repositories;
using WasteRecords.Core.Interfaces.Services;

namespace WasteRecords.Service.Services
{
    public class ReceivingCompanyService : GenericService<ReceivingCompany>, IReceivingCompanyService
    {
        private readonly IGenericRepository<ReceivingCompany> _genericRepository;
        public ReceivingCompanyService(IGenericRepository<ReceivingCompany> genericRepository) : base(genericRepository)
        {
            _genericRepository = genericRepository;
        }
    }
}

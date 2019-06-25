using SIGSUC.DAL.Context;
using SIGSUC.Domain.Entities.Common;
using SIGSUC.Domain.Interfaces;

namespace SIGSUC.DAL.Repository.Common
{
    public class UFRepository : BaseRepository<UF>, IUFRepository
    {
        public UFRepository(SIGSUCContext sigsucContext) : base(sigsucContext)
        {
        }
    }
}

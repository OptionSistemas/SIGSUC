using SIGSUC.DAL.Context;
using SIGSUC.Domain.Entities.Common;
using SIGSUC.Domain.Interfaces;

namespace SIGSUC.DAL.Repository.Common
{
    public class ContinenteRepository : BaseRepository<Continente>, IContinenteRepository
    {
        public ContinenteRepository(SIGSUCContext sigsucContext) : base(sigsucContext)
        {
        }
    }
}

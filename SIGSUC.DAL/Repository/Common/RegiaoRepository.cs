using SIGSUC.DAL.Context;
using SIGSUC.Domain.Entities.Common;
using SIGSUC.Domain.Interfaces;

namespace SIGSUC.DAL.Repository.Common
{
    public class RegiaoRepository : BaseRepository<Regiao>, IRegiaoRepository
    {
        public RegiaoRepository(SIGSUCContext sigsucContext) : base(sigsucContext)
        {
        }
    }
}

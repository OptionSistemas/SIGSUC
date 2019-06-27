using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SIGSUC.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IContinenteRepository Continentes { get; }
        IPaisRepository Paises { get; }
        IRegiaoRepository Regioes { get; }
        IUFRepository UFs { get; }
        Task<int> Commit();
    }
}

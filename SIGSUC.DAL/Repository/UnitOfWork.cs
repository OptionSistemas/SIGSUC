using SIGSUC.DAL.Context;
using SIGSUC.DAL.Repository.Common;
using SIGSUC.Domain.Interfaces;
using System.Threading.Tasks;

namespace SIGSUC.DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SIGSUCContext _context;

        // não esquecer que colocar as propriedades no constructor abaixo
        public IContinenteRepository Continentes { get; private set; }
        public IPaisRepository Paises { get; private set; }
        public IRegiaoRepository Regioes { get; private set; }
        public IUFRepository UFs { get; private set; }


        public UnitOfWork(SIGSUCContext context)
        {
            _context = context;
            Continentes = new ContinenteRepository(_context);
            Paises = new PaisRepository(_context);
            Regioes = new RegiaoRepository(_context);
            UFs = new UFRepository(_context);
        }



        public async Task<int> Commit()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

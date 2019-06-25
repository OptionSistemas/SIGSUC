
namespace SIGSUC.Domain.Entities.Common
{
    public class UF
    {
        public int PaisId { get; set; }
        public string SiglaId { get; set; }
        public string Descricao { get; set; }
        public virtual Pais Pais { get; set; }
    }
}

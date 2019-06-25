using System.Collections.Generic;

namespace SIGSUC.Domain.Entities.Common
{
    public class Pais
    {
        public int PaisId { get; set; }
        public string Nome { get; set; }
        public string CodigoArea { get; set; }
        public virtual ICollection<UF> UFs { get; set; }
    }
}

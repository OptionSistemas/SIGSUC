
using System.Collections.Generic;

namespace SIGSUC.Domain.Entities.Common
{
    public class Regiao : Entity
    {
        public int PaisId { get; set; }
        public virtual Pais Pais { get; set; }
        public int RegiaoId { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<UF> UFs { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}

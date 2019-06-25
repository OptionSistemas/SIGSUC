using System;
using System.Collections.Generic;
using System.Text;

namespace SIGSUC.Domain.Entities.Common
{
    public class Continente: Entity
    {
        public int ContinenteId { get; set; }
        public string Descricao{ get; set; }

        public virtual ICollection<Pais> Paises { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}

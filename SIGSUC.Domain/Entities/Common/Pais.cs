using System.Collections.Generic;

namespace SIGSUC.Domain.Entities.Common
{
    public class Pais: Entity
    {
        public int PaisId { get; set; }
        public string Nome { get; set; }
        public string CodigoArea { get; set; }
        public int ContinenteId { get; set; }
        public virtual Continente Continente { get; set; }


        public virtual ICollection<UF> UFs { get; set; }
        public virtual ICollection<Regiao> Regioes { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}



namespace SIGSUC.Domain.Entities.Common
{
    public class UF: Entity
    {
        public int PaisId { get; set; }
        public virtual Pais Pais { get; set; }
        public string SiglaId { get; set; }
        public string Descricao { get; set; }
        public int RegiaoId { get; set; }
        public virtual Regiao Regiao { get; set; }



        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}

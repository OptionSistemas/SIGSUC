using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIGSUC.Domain.Entities
{
    public abstract class Entity
    {
        private List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }
        public abstract void Validate();
        protected bool EhValido
        {
            get { return !mensagemValidacao.Any(); }
        }
    }
}

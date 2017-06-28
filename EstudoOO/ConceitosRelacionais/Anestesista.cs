using System;

namespace ConceitosRelacionais
{
    class Anestesista : Medico
    {
        private DateTime dataEspecializacao;

        public DateTime DataEspecializacao { get => dataEspecializacao; set => dataEspecializacao = value; }

        public override void Operar()
        {
            throw new NotImplementedException();
        }
    }
}

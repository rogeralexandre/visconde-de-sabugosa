using System;

namespace ConceitosRelacionais
{
    abstract class Pessoa
    {
        private String nome;
        private String sexo;

        // propriedade gerado ao clicar com o direito em cima do atributo.
        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }

        public override string ToString()
        {
            var retorno = nome + ";" + sexo;
            return retorno.ToString();
        }
    }
}

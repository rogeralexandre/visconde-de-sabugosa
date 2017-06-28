using System;

namespace ConceitosRelacionais
{
    abstract class Funcionario : Pessoa
    {
        private DateTime dataAdmissao;
        private String matricula;

        public DateTime DataAdmissao { get => dataAdmissao; set => dataAdmissao = value; }
        public string Matricula { get => matricula; set => matricula = value; }
      
    }
}

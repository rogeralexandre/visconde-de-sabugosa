using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Entidades
{
    public class Plano
    {
        private String nome;

        private double mensalidade;

        public Plano()
        {

        }

        public String Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public double Mensalidade
        {
            set { mensalidade = value; }
            get { return mensalidade; }
        }

        public override int GetHashCode()
        {
            int prime = 5;
            int result = 7;
            result = prime * result + ((nome == null) ? 0 : nome.GetHashCode());
            return result;
        }

        public override bool Equals(Object obj)
        {

            if (obj is Plano) {

                Plano plano = obj as Plano;
                return nome.Equals(plano.Nome, StringComparison.InvariantCultureIgnoreCase);
            }
            return false;
        }

        public override String ToString()
        {
            return "Nome: " + this.nome;
        }
    }
}

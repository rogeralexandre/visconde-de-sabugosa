using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Entidades
{
    public class Sala
    {
        private String nome;

        public Sala()
        {

        }

        public String Nome 
        {
            set { nome = value; }
            get { return nome; }
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

            if (obj is Sala) {

                Sala sala = (Sala) obj;
                return nome.Equals(sala.nome, StringComparison.InvariantCultureIgnoreCase);
            }
            return false;
        }

        public override String ToString()
        {
            return "Nome: " + this.nome;
        }
    }
}

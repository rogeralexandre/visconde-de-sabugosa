using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Entidades
{
    public class Endereco
    {
        public String logradouro { get; set; }

        public int numero { get; set; }

        public String bairro { get; set; }

        public String cep { get; set; }

        public Endereco()
        {

        }

        public override int GetHashCode()
        {
            int prime = 29;
            int result = 1;
            result = prime * result
                    + ((logradouro == null) ? 0 : logradouro.GetHashCode());
            result = prime * result + numero;
            return result;
        }

        public override bool Equals(Object obj)
        {

            if (obj is Endereco) {

                Endereco endereco = (Endereco) obj;
                return this.logradouro.Equals(endereco.logradouro, StringComparison.InvariantCultureIgnoreCase)
                        && this.numero == endereco.numero;
            }
            return false;
        }

        public override String ToString()
        {
            return logradouro + ",n " + numero + "," + bairro + "," + cep;
        }
    }
}

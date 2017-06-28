using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosRelacionais
{
    class Paciente:Pessoa
    {
        DateTime internacao;

        public DateTime Internacao { get => internacao; set => internacao = value; }
    }
}

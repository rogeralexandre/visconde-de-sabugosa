using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_LogSQL.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public int AnoLancamento { get; set; }

        public virtual Autor Autor { get; set; }
        public int AutorId { get; set; }
    }
}

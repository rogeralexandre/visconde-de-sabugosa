using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_LogSQL.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}

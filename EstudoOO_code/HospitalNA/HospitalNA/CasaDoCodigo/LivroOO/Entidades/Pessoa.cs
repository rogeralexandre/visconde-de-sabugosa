using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Entidades
{
    public class Pessoa
    {
        public String nome { get; }

        public DateTime dataNascimento { get; }

        public Endereco endereco { get; }

        public Pessoa()
        {

        }

        public Pessoa(String nome)
        {
            this.nome = nome;
        }

        public Pessoa(String nome, DateTime dataNascimento)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
        }

        public Pessoa(String nome, Endereco endereco)
        {
            this.nome = nome;
            this.endereco = endereco;
        }

        public Pessoa(String nome, DateTime dataNascimento, Endereco endereco)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.endereco = endereco;
        }
    }
}

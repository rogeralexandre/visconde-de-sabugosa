using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicoOO
{
    public class Personagem
    {
        //atributos
        string nome;
        string cor;
        int quantidadeDeCogumelos;
        float altura;
        string tipoFisico;
        bool possuiBigode;

        // GETs e SETs
        // estilo puxado do livro de OO da casa do código.
        public string Nome
        {
            get { return nome; }
            set { nome = value;  }
        }

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        // gerado ao fazer o build quando o atributo não tinha get,set cliquei com o direito e gerou;
        public int QuantidadeDeCogumelos { get => quantidadeDeCogumelos; set => quantidadeDeCogumelos = value; }
        public float Altura { get => altura; set => altura = value; }
        public string TipoFisico { get => tipoFisico; set => tipoFisico = value; }
        public bool PossuiBigode { get => possuiBigode; set => possuiBigode = value; }

        // método construtor
        public Personagem()
        {

        }

        // métodos
        void Pular()
        {

        }

        void PegarCogumelo(Cogumelo cogumelo)
        {

        }

        Bolafogo AtirarFogo()
        {
            return new Bolafogo();
        }

        // método destrutor
        ~Personagem()
        {

        }

        //Equals
        public override bool Equals(object obj)
        {
            if (obj is Personagem)
            {
                Personagem p = obj as Personagem;
                return this.nome.Equals(p.nome);
            }
            return false;
        }

    }

    class Cogumelo
    {

    }

    class Bolafogo
    {

    }
}
    
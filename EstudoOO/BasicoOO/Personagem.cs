using System;

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
            altura = 0.7F;
        }

        // métodos
        public String Pular()
        {
            return this.nome + " pulou!";
        }

        void PegarCogumelo(Cogumelo cogumelo)
        {
            
        }

        string PegarCogumelo()
        {
            return Cogumelo.Tipo;
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

        //GetHashCode
        public override int GetHashCode()
        {
            // usando o atributo de quantidade de cogumelos
            int result = 11;
            result = 43 * result + quantidadeDeCogumelos; // quantidade de cogumelos é int então se enquadra na regra 2 do livro (página 63)

            return result;
        }

        //Representação padrão do objeto ToString()
        public override string ToString()
        {
            return "Nome:" + nome + " Cor: " + cor + " Tipo físico: " + tipoFisico + " Cogumelo permitido:" + this.PegarCogumelo();
        }
    }

    class Cogumelo
    {
        // USO de STATIC
        public static String Tipo = "crescer";
                
    }

    class Bolafogo
    {
        
    }
}
    
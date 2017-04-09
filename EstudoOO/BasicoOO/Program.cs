using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem personagem = new Personagem();

            personagem.PossuiBigode = true;
            personagem.Altura = 1.5F;
            personagem.QuantidadeDeCogumelos = 0;
            personagem.TipoFisico = "parece um encanador italiano";
            personagem.Nome = "Mario";
            personagem.Cor = "Vermelho";

            Personagem personagem2 = new Personagem();

            // USO DE EQUALS
            if (personagem.Equals(personagem2))
            {
                Console.WriteLine("Os dois personagens são iguais.");
            }
            else
            {
                Console.WriteLine("Os personagens são diferentes.");
            }

            personagem2.Nome = personagem.Nome;
            if (personagem.Equals(personagem2))
            {
                Console.WriteLine("Agora os dois personagens são iguais.");
            }
            else
            {
                Console.WriteLine("Os personagens ainda são diferentes.");
            }

            // USO DE HASHCODE.
            Console.WriteLine("");
            Console.WriteLine("Retornando o valor do hashcode da baseado na quantidade de cogumelos");
            Console.WriteLine("Para quantidade de cogumelos igual a {0}: {1}", personagem.QuantidadeDeCogumelos, personagem.GetHashCode());
            personagem.QuantidadeDeCogumelos = 2;
            Console.WriteLine("Para quantidade de cogumelos igual a {0}: {1}", personagem.QuantidadeDeCogumelos, personagem.GetHashCode());
            personagem.QuantidadeDeCogumelos = 10;
            Console.WriteLine("Para quantidade de cogumelos igual a {0}: {1}", personagem.QuantidadeDeCogumelos, personagem.GetHashCode());

            // USO DE REPRESENTAÇÃO PADRÃO
            Console.WriteLine("Personagem 1: " + personagem.ToString());
            personagem2.Cor = "branco (fire)";
            
            Console.WriteLine("Personagem 2: " + personagem2.ToString());


            Console.WriteLine("USO DE STATIC");
            Console.WriteLine("Tipo do cogumelo (sem instanciar):" + Cogumelo.Tipo);

            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }
    }
}

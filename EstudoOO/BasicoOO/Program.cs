using System;

namespace BasicoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem mario = new Personagem();

            mario.PossuiBigode = true;
            mario.Altura = 1.5F;
            mario.QuantidadeDeCogumelos = 0;
            mario.TipoFisico = "parece um encanador italiano";
            mario.Nome = "Mario";
            mario.Cor = "Vermelho";

            Personagem luigi = new Personagem();

            luigi.Nome = "Luigi";
            luigi.Cor = "Verde";
            luigi.QuantidadeDeCogumelos = 0;
            luigi.Altura = 1.80F;
            luigi.TipoFisico = "magro";
            luigi.PossuiBigode = true;

            Console.WriteLine(mario.Pular());

            Console.WriteLine(luigi.Pular());


            // USO DE EQUALS
            if (mario.Equals(luigi))
            {
                Console.WriteLine("Os dois personagens são iguais.");
            }
            else
            {
                Console.WriteLine("Os personagens são diferentes.");
            }

            luigi.Nome = mario.Nome;
            if (mario.Equals(luigi))
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
            Console.WriteLine("Para quantidade de cogumelos igual a {0}: {1}", mario.QuantidadeDeCogumelos, mario.GetHashCode());
            mario.QuantidadeDeCogumelos = 2;
            Console.WriteLine("Para quantidade de cogumelos igual a {0}: {1}", mario.QuantidadeDeCogumelos, mario.GetHashCode());
            mario.QuantidadeDeCogumelos = 10;
            Console.WriteLine("Para quantidade de cogumelos igual a {0}: {1}", mario.QuantidadeDeCogumelos, mario.GetHashCode());

            // USO DE REPRESENTAÇÃO PADRÃO
            Console.WriteLine("Personagem 1: " + mario.ToString());
            luigi.Cor = "branco (fire)";
            
            Console.WriteLine("Personagem 2: " + luigi.ToString());


            Console.WriteLine("USO DE STATIC");
            Console.WriteLine("Tipo do cogumelo (sem instanciar):" + Cogumelo.Tipo);

            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }
    }
}

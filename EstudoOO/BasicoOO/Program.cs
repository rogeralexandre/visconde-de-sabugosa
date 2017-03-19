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

            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }
    }
}

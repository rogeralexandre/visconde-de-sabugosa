using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            string aulaIntro = "Introdução às coleções";
            string aulaModelando = "Modelando a classe aula";
            string aulaSets = "Trabalhando com conjuntos";

            string[] aulas = new string[]
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };

            Console.WriteLine(aulas);

            Imprimir(aulas);

            aulas[0] = "Trabalhando com arrays";
            Imprimir(aulas);


            Console.WriteLine($"Aula modelando está no índice: {Array.IndexOf(aulas,aulaModelando)}");
            Console.WriteLine(Array.LastIndexOf(aulas,aulaModelando));

            //Inverter a ordem do Array
            Array.Reverse(aulas);
            Imprimir(aulas);


            //Diminuindo o tamanho do array
            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

        }

        private static void Imprimir(string[] aulas)
        {
            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }

    }
}

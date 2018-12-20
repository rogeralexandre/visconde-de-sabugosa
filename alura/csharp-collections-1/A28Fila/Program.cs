using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A28Fila
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            string veiculo = "van";
            Console.WriteLine($"Entrou na fila: {veiculo}");

            Enfileirar("van");
            Enfileirar("kombi");
            Enfileirar("guincho");
            Enfileirar("pickup");

            Desinfileirar();
            Desinfileirar();
            Desinfileirar();
            Desinfileirar();
            Desinfileirar();

            Console.ReadLine();
        }

        static void Enfileirar(string veiculo)
        {
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        static void Desinfileirar()
        {
            if (pedagio.Any())
            {
                if (pedagio.Peek() == "guincho")
                {
                    Console.WriteLine("guincho está fazendo o pagamento");
                }
                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila: {veiculo}");
                ImprimirFila();
            }
            
        }

        static void ImprimirFila()
        {
            Console.WriteLine("Fila:");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeDescontos calculadora = new CalculadoraDeDescontos();

            Orcamento orcamento = new Orcamento(500.0);
            orcamento.AdicionaItem(new Item("Caneta", 250.0));
            orcamento.AdicionaItem(new Item("Lapis", 250.0));

            double desconto = calculadora.Calcula(orcamento);

            Console.WriteLine(desconto);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto iccc = new ICCC();

            Orcamento orcamento = new Orcamento(500);

            //CalculadoraDeImpostos calculador = new CalculadoraDeImpostos();
                        
            Console.WriteLine($"ISS = {iss.Calcula(orcamento)}");
            Console.WriteLine($"ICMS = {icms.Calcula(orcamento)}");
            Console.WriteLine($"ICCC = {iccc.Calcula(orcamento)}");

            Console.ReadKey();
        }
    }
}

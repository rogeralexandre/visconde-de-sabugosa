
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(1000);
            ICPP impostoICPP = new ICPP();
            double resultadoICPP = impostoICPP.Calcula(orcamento);

            Console.WriteLine($"Para um orcamento de {orcamento.Valor} o imposto ICPP é de {resultadoICPP}");

            IKCV impostoIKCV = new IKCV();
            double resultadoIKCV = impostoIKCV.Calcula(orcamento);
            Console.WriteLine($"Para um orcamento de {orcamento.Valor} o imposto IKCV é de {resultadoIKCV}");

            orcamento.AdicionaItem(new Item("carro", 1000));
            resultadoIKCV = impostoIKCV.Calcula(orcamento);
            Console.WriteLine($"Para um orcamento de {orcamento.Valor} e com itens o imposto IKCV é de {resultadoIKCV}");

            Console.ReadKey();

            Console.WriteLine("Teste do IHIT");

            IHIT impostoIHIT = new IHIT();
            double resultadoIHIT;
            resultadoIHIT = impostoIHIT.Calcula(orcamento);
            Console.WriteLine($"Para um orcamento de {orcamento.Valor} o imposto IHIT é de {resultadoIHIT}");

            orcamento.AdicionaItem(new Item("carro", 200));
            resultadoIHIT = impostoIHIT.Calcula(orcamento);
            Console.WriteLine($"Para um orcamento de {orcamento.Valor} o imposto IHIT é de {resultadoIHIT}");

            Console.ReadKey();

        }
    }
}

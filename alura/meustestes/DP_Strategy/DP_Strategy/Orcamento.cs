using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy
{
    public class Orcamento
    {
        public double Valor { get; private set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
        }
    }

    //public class CalculadoraDeImpostos
    //{
    //    public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
    //    {
    //        double valor = imposto.Calcula(orcamento);
    //        Console.WriteLine(valor);
    //    }
    //}
}
